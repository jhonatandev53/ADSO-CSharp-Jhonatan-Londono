using Inventario.Datos;
using Inventario.Modelos;
using Inventario.Servicios;

namespace Inventario.Escritorio;

public partial class FormPrincipal : Form
{
    private readonly ServicioInventario _servicio = new(new RepositorioJson("inventario.json"));

    public FormPrincipal()
    {
        InitializeComponent();
        CargarProductos();
    }

    private void CargarProductos(List<Producto>? productos = null)
    {
        dgvProductos.DataSource = null; // suelta la lista vieja
        var lista = productos ?? _servicio.Listar();
        dgvProductos.DataSource = lista;

        // Calcula el valor total de manera segura
        decimal valorTotal = lista.Sum(p => p.Precio * p.Stock);
        lblValor.Text = $"Valor del inventario: {valorTotal:C0}";
    }

    private Producto? Seleccionado() => dgvProductos.CurrentRow?.DataBoundItem as Producto;

    private void txtBuscar_TextChanged(object sender, EventArgs e) =>
        CargarProductos(_servicio.BuscarPorTexto(txtBuscar.Text));

    private void dgvProductos_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
    {
        if (dgvProductos.Columns["Precio"] is DataGridViewColumn precio)
            precio.DefaultCellStyle.Format = "C0";

        foreach (DataGridViewRow fila in dgvProductos.Rows)
        {
            if (fila.DataBoundItem is Producto { Stock: < 5 })
                fila.DefaultCellStyle.BackColor = Color.MistyRose; // rosado suave para stock bajo
        }
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        using var form = new FormProducto();
        if (form.ShowDialog() != DialogResult.OK || form.ProductoCreado is null) return;
        try
        {
            _servicio.Agregar(form.ProductoCreado);
            CargarProductos();
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "No se pudo agregar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnVender_Click(object sender, EventArgs e)
    {
        if (Seleccionado() is not Producto producto)
        {
            MessageBox.Show("Selecciona un producto de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        try
        {
            _servicio.Vender(producto.Codigo, (int)nudCantidad.Value);
            CargarProductos();
            nudCantidad.Value = 1;
        }
        catch (StockInsuficienteException ex)
        {
            MessageBox.Show(ex.Message, "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnAgregarStock_Click(object sender, EventArgs e)
    {
        if (Seleccionado() is not Producto producto)
        {
            MessageBox.Show("Selecciona un producto de la tabla.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }
        try
        {
            _servicio.AgregarStock(producto.Codigo, (int)nudCantidad.Value);
            CargarProductos();
            nudCantidad.Value = 1;
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (Seleccionado() is not Producto producto) return;
        var respuesta = MessageBox.Show($"¿Eliminar {producto.Nombre}?", "Confirmar",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        if (respuesta == DialogResult.Yes)
        {
            _servicio.Eliminar(producto.Codigo);
            CargarProductos();
        }
    }

    private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (Seleccionado() is not Producto productoSeleccionado) return;

        // Abrimos el formulario pasándole el producto seleccionado
        using var form = new FormProducto(productoSeleccionado);
        if (form.ShowDialog() != DialogResult.OK || form.ProductoCreado is null) return;

        try
        {
            // Llamamos al método de actualizar de nuestro servicio
            _servicio.Actualizar(form.ProductoCreado);
            CargarProductos();
        }
        catch (ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "No se pudo actualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }

    private void btnReportes_Click(object sender, EventArgs e)
    {
        using var formReportes = new FormReportes(_servicio);
        formReportes.ShowDialog();
    }
}
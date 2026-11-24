using Inventario.Modelos;

namespace Inventario.Escritorio;

public partial class FormProducto : Form
{
    public Producto? ProductoCreado { get; private set; }

    public FormProducto() => InitializeComponent();

    public FormProducto(List<Categoria> categorias) : this()
    {
        cmbCategoria.DataSource = categorias;
        cmbCategoria.DisplayMember = "Nombre";
        cmbCategoria.ValueMember = "Id";
    }

    private bool _esEdicion = false;

    // NUEVO Constructor (para cuando editamos)
    public FormProducto(Producto productoAEditar) : this()
    {
        _esEdicion = true;
        txtCodigo.Text = productoAEditar.Codigo;
        txtCodigo.Enabled = false; // El código no se debe cambiar porque es la llave
        txtNombre.Text = productoAEditar.Nombre;
        nudPrecio.Value = productoAEditar.Precio;
        nudStock.Value = productoAEditar.Stock;
        if (productoAEditar.CategoriaId is int catId)
            cmbCategoria.SelectedValue = catId;
    }

    private void GuardarProducto()
    {
        errorProvider1.Clear();
        try
        {
            ProductoCreado = new Producto(txtCodigo.Text, txtNombre.Text, nudPrecio.Value, (int)nudStock.Value);
            ProductoCreado.CambiarCategoria(cmbCategoria.SelectedValue as int?);
            DialogResult = DialogResult.OK; // Cierra la ventanilla: ¡aprobado!
        }
        catch (ArgumentException ex)
        {
            errorProvider1.SetError(btnGuardar, ex.Message);
        }
    }

    private void btnGuardar_Click(object sender, EventArgs e) => GuardarProducto();

    private void btnGuardar_Click_1(object sender, EventArgs e) => GuardarProducto();

    private void FormProducto_Load(object sender, EventArgs e)
    {
    }
}
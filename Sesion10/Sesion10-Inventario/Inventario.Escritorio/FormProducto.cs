using Inventario.Modelos;

namespace Inventario.Escritorio;

public partial class FormProducto : Form
{

    public Producto? ProductoCreado { get; private set; }

    public FormProducto() => InitializeComponent();

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
    }

    private void btnGuardar_Click(object sender, EventArgs e)
    {
        errorProvider1.Clear();
        try
        {
            ProductoCreado = new Producto(txtCodigo.Text, txtNombre.Text, nudPrecio.Value, (int)nudStock.Value);
            DialogResult = DialogResult.OK; // Cierra la ventanilla: ¡aprobado!
        }
        catch (ArgumentException ex)
        {
            errorProvider1.SetError(btnGuardar, ex.Message);
        }
    }

    private void btnGuardar_Click_1(object sender, EventArgs e)
    {
        errorProvider1.Clear();
        try
        {
            ProductoCreado = new Producto(txtCodigo.Text, txtNombre.Text, nudPrecio.Value, (int)nudStock.Value);
            DialogResult = DialogResult.OK; // Cierra la ventanilla: ¡aprobado!
        }
        catch (ArgumentException ex)
        {
            errorProvider1.SetError(btnGuardar, ex.Message);
        }
    }
}
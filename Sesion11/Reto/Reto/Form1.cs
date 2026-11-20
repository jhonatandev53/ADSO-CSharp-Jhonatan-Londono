using Microsoft.EntityFrameworkCore;

namespace Reto;

public partial class Form1 : Form
{
    private int? _idSeleccionado = null;

    public Form1()
    {
        InitializeComponent();

        using var db = new AgendaContext();
        db.Database.EnsureCreated();

        CargarContactos();
    }

    private void CargarContactos(string filtro = "")
    {
        using var db = new AgendaContext();

        dgvContactos.DataSource = db.Contactos
            .Where(c => EF.Functions.Like(c.Nombre, $"%{filtro}%"))
            .OrderBy(c => c.Nombre)
            .ToList();

        lblTotal.Text = $"{dgvContactos.Rows.Count} contactos";
    }

    private bool ValidarFormulario()
    {
        errorProvider1.Clear();

        if (string.IsNullOrWhiteSpace(txtNombre.Text))
        {
            errorProvider1.SetError(txtNombre, "El nombre es obligatorio.");
            txtNombre.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(txtCorreo.Text) || !txtCorreo.Text.Contains('@'))
        {
            errorProvider1.SetError(txtCorreo, "Ingresa un correo válido con '@'.");
            txtCorreo.Focus();
            return false;
        }

        return true;
    }

    private void LimpiarCampos()
    {
        _idSeleccionado = null;
        errorProvider1.Clear();
        txtNombre.Clear();
        txtPhone.Clear();
        txtCorreo.Clear();
        txtNombre.Focus();
    }

    private void txtBuscar_TextChanged(object sender, EventArgs e)
        => CargarContactos(txtBuscar.Text);

    private void btnAgregar_Click(object sender, EventArgs e)
    {
        if (!ValidarFormulario()) return;

        using var db = new AgendaContext();
        db.Contactos.Add(new Contacto
        {
            Nombre = txtNombre.Text.Trim(),
            Telefono = txtPhone.Text.Trim(),
            Correo = txtCorreo.Text.Trim()
        });
        db.SaveChanges();

        LimpiarCampos();
        CargarContactos(txtBuscar.Text);
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        if (dgvContactos.CurrentRow?.DataBoundItem is not Contacto contacto) return;

        var respuesta = MessageBox.Show(
            $"¿Eliminar a {contacto.Nombre}?",
            "Confirmar",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

        if (respuesta != DialogResult.Yes) return;

        using var db = new AgendaContext();
        var registro = db.Contactos.Find(contacto.Id);
        if (registro is not null)
        {
            db.Contactos.Remove(registro);
            db.SaveChanges();
        }

        if (_idSeleccionado == contacto.Id)
            LimpiarCampos();

        CargarContactos(txtBuscar.Text);
    }

    private void dgvContactos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex < 0) return;
        if (dgvContactos.CurrentRow?.DataBoundItem is not Contacto contacto) return;

        _idSeleccionado = contacto.Id;
        txtNombre.Text = contacto.Nombre;
        txtPhone.Text = contacto.Telefono;
        txtCorreo.Text = contacto.Correo;
    }

    private void btnGuardarCambios_Click(object sender, EventArgs e)
    {
        if (_idSeleccionado is null)
        {
            MessageBox.Show("Haz doble clic sobre un contacto en la tabla para editarlo.", "Aviso");
            return;
        }

        if (!ValidarFormulario()) return;

        using var db = new AgendaContext();
        var contacto = db.Contactos.Find(_idSeleccionado.Value);
        if (contacto is not null)
        {
            contacto.Nombre = txtNombre.Text.Trim();
            contacto.Telefono = txtPhone.Text.Trim();
            contacto.Correo = txtCorreo.Text.Trim();
            db.SaveChanges();
        }

        LimpiarCampos();
        CargarContactos(txtBuscar.Text);
    }

    private void btnCancelar_Click(object sender, EventArgs e)
        => LimpiarCampos();
}
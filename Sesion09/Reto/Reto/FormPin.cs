using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Reto
{
    public partial class FormPin : Form
    {
        public FormPin()
        {
            InitializeComponent();
        }

        private void FormPin_Load(object sender, EventArgs e)
        {

        }

        private int intentosRestantes = 3;
        private const string PIN_CORRECTO = "1234";

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtPin.Text == PIN_CORRECTO)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                intentosRestantes--;

                if (intentosRestantes > 0)
                {
                    MessageBox.Show($"PIN incorrecto. Te quedan {intentosRestantes} intentos.",
                        "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPin.Clear();
                    txtPin.Focus();
                }
                else
                {
                    MessageBox.Show("Se han agotado los 3 intentos. La aplicación se cerrará.",
                        "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                }
            }
        }
    }
}

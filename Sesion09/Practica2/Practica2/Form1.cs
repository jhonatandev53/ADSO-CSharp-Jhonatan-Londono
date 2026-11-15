namespace Practica2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtNombreCompleto.Text))
            {
                errorProvider1.SetError(txtNombreCompleto, "Escribe el nombre.");
                valido = false;
            }
            if (cmbPrograma.SelectedItem is null)
            {
                errorProvider1.SetError(cmbPrograma, "Elige un programa.");
                valido = false;
            }
            if (!chkTerminos.Checked)
            {
                errorProvider1.SetError(chkTerminos, "Debes aceptar los términos.");
                valido = false;
            }
            if (!valido) return;

            string jornada = rdbManana.Checked ? "Mañana" : "Tarde";
            lstInscritos.Items.Add($"{txtNombreCompleto.Text} · {nudEdad.Value} años · {cmbPrograma.SelectedItem} · {jornada}");

            txtNombreCompleto.Clear();
            nudEdad.Value = nudEdad.Minimum;
            cmbPrograma.Text = "Elije tu programa";
            chkTerminos.Checked = false;
            rdbManana.Checked = false;
            rdbTarde.Checked = false;
            errorProvider1.Clear();
        }
    }
}

namespace Practica_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblPregunta_Click(object sender, EventArgs e)
        {

        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            lblSaludo.Text = $"Hola, {txtNombre.Text} Bienvenido a mi programa";
        }

     
        // Metodo para obtener un numero entero
        private int ObtenerNumero(string texto, string nombreCampo)
        {
            if (string.IsNullOrWhiteSpace(texto))
                throw new ArgumentException($"El campo {nombreCampo} no puede estar vacío.", nombreCampo);

            if (!int.TryParse(texto, out int numero))
                throw new ArgumentException($"El campo {nombreCampo} debe ser un número entero válido.", nombreCampo);

            return numero;
        }

        // Metodo para mostrar error
        private void MostrarError(ArgumentException ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        // Metodo para dividir
        private int Dividir(int dividendo, int divisor)
        {
            if (divisor == 0)
                throw new ArgumentException("No se puede dividir entre cero (0).", nameof(divisor));

            return dividendo / divisor;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click_1(object sender, EventArgs e)
        {
            try
            {
                int n1 = ObtenerNumero(txtNumero1.Text, "Número 1");
                int n2 = ObtenerNumero(txtNumero2.Text, "Número 2");
                txtResultado.Text = Convert.ToString(n1 + n2);
            }
            catch (ArgumentException ex)
            {
                MostrarError(ex);
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {

            try
            {
                int n1 = ObtenerNumero(txtNumero1.Text, "Número 1");
                int n2 = ObtenerNumero(txtNumero2.Text, "Número 2");
                txtResultado.Text = Convert.ToString(n1 - n2);
            }
            catch (ArgumentException ex)
            {
                MostrarError(ex);
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                int n1 = ObtenerNumero(txtNumero1.Text, "Número 1");
                int n2 = ObtenerNumero(txtNumero2.Text, "Número 2");
                txtResultado.Text = Convert.ToString(n1 * n2);
            }
            catch (ArgumentException ex)
            {
                MostrarError(ex);
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

            try
            {
                int n1 = ObtenerNumero(txtNumero1.Text, "Número 1");
                int n2 = ObtenerNumero(txtNumero2.Text, "Número 2");
                txtResultado.Text = Convert.ToString(Dividir(n1, n2));
            }
            catch (ArgumentException ex)
            {
                MostrarError(ex);
            }
        }
    }
}

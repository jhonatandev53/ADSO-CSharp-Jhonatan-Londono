using Sesion09;

namespace Tarea
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private readonly ConversorTemperatura _conversor = new ConversorTemperatura();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            
            errorProvider1.Clear();
            bool valido = true;

           
            if (!double.TryParse(txtValor.Text, out double valorIngresado))
            {
                errorProvider1.SetError(txtValor, "Ingrese un número válido.");
                valido = false;
            }

            
            if (cmbOrigen.SelectedItem is null)
            {
                errorProvider1.SetError(cmbOrigen, "Seleccione la unidad de origen.");
                valido = false;
            }

           
            if (cmbDestino.SelectedItem is null)
            {
                errorProvider1.SetError(cmbDestino, "Seleccione la unidad de destino.");
                valido = false;
            }

            
            if (!valido) return;

            string origen = cmbOrigen.SelectedItem.ToString();
            string destino = cmbDestino.SelectedItem.ToString();

            
            double resultado = _conversor.Convertir(valorIngresado, origen, destino);

            
            lblResultado.Text = $"Resultado: {resultado:F2} {destino}";
        }

        private void btnConvertir_Click_1(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool valido = true;

     
            if (!double.TryParse(txtValor.Text, out double valorIngresado))
            {
                errorProvider1.SetError(txtValor, "Ingrese un número válido.");
                valido = false;
            }

            if (cmbOrigen.SelectedItem is null)
            {
                errorProvider1.SetError(cmbOrigen, "Seleccione la unidad de origen.");
                valido = false;
            }

            
            if (cmbDestino.SelectedItem is null)
            {
                errorProvider1.SetError(cmbDestino, "Seleccione la unidad de destino.");
                valido = false;
            }

          
            if (!valido) return;

            string origen = cmbOrigen.SelectedItem.ToString();
            string destino = cmbDestino.SelectedItem.ToString();

            double resultado = _conversor.Convertir(valorIngresado, origen, destino);

            lblResultado.Text = $"Resultado: {resultado:F2} {destino}";
        }
    }
}

namespace Reto
{
    public partial class Form1 : Form
    {

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private readonly CuentaBancaria _cuenta = new("Jhonatan Londoño", "001-123", 500000m);

        public Form1()
        {
            InitializeComponent();
            ActualizarInterfaz();
            lblCuentaDestino.Visible = false;
            txtCuentaDestino.Visible = false;
            btnEnviarTransferencia.Visible = false;
        }


        private void ActualizarInterfaz()
        {
            lblTitular.Text = $"Titular: {_cuenta.Titular} (Cuenta: {_cuenta.Numero})";
            lblSaldo.Text = $"Saldo actual: {_cuenta.Saldo:C2}";
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            decimal monto = nudMonto.Value;


            bool exito = _cuenta.Depositar(monto);

            if (exito)
            {
                ActualizarInterfaz();
                string hora = DateTime.Now.ToString("HH:mm:ss");
                lstMovimientos.Items.Insert(0, $"{hora} · Depósito · +{monto:C2}");
                nudMonto.Value = 0;
            }
            else
            {
                MessageBox.Show("El monto del depósito debe ser mayor a cero.", "Error en depósito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            decimal monto = nudMonto.Value;


            bool exito = _cuenta.Retirar(monto);

            if (exito)
            {
                ActualizarInterfaz();
                string hora = DateTime.Now.ToString("HH:mm:ss");
                lstMovimientos.Items.Insert(0, $"{hora} · Retiro · -{monto:C2}");
                nudMonto.Value = 0;
            }
            else
            {
                MessageBox.Show("Operación fallida: Verifique que tenga saldo suficiente y que el monto sea múltiplo de $10.000.", "Error en retiro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDepositar_Click_1(object sender, EventArgs e)
        {
            decimal monto = nudMonto.Value;


            bool exito = _cuenta.Depositar(monto);

            if (exito)
            {
                ActualizarInterfaz();
                string hora = DateTime.Now.ToString("HH:mm:ss");
                lstMovimientos.Items.Insert(0, $"{hora} · Depósito · +{monto:C2}");
                nudMonto.Value = 0;
            }
            else
            {
                MessageBox.Show("El monto del depósito debe ser mayor a cero.", "Error en depósito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRetirar_Click_1(object sender, EventArgs e)
        {
            decimal monto = nudMonto.Value;


            bool exito = _cuenta.Retirar(monto);

            if (exito)
            {
                ActualizarInterfaz();
                string hora = DateTime.Now.ToString("HH:mm:ss");
                lstMovimientos.Items.Insert(0, $"{hora} · Retiro · -{monto:C2}");
                nudMonto.Value = 0;
            }
            else
            {
                MessageBox.Show("Operación fallida: Verifique que tenga saldo suficiente y que el monto sea múltiplo de $10.000.", "Error en retiro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void nudMonto_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrarTransferencia_Click(object sender, EventArgs e)
        {
            lblCuentaDestino.Visible = true;
            txtCuentaDestino.Visible = true;
            btnEnviarTransferencia.Visible = true;
        }
    }
}

namespace Reto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitular = new Label();
            lblSaldo = new Label();
            nudMonto = new NumericUpDown();
            btnDepositar = new Button();
            btnRetirar = new Button();
            lstMovimientos = new ListBox();
            btnMostrarTransferencia = new Button();
            btnEnviarTransferencia = new Button();
            lblCuentaDestino = new Label();
            txtCuentaDestino = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudMonto).BeginInit();
            SuspendLayout();
            // 
            // lblTitular
            // 
            lblTitular.AutoSize = true;
            lblTitular.Location = new Point(50, 28);
            lblTitular.Name = "lblTitular";
            lblTitular.Size = new Size(136, 20);
            lblTitular.TabIndex = 0;
            lblTitular.Text = "Titular de la cuenta";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(73, 101);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(51, 20);
            lblSaldo.TabIndex = 1;
            lblSaldo.Text = "Saldo ";
            // 
            // nudMonto
            // 
            nudMonto.Increment = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMonto.Location = new Point(78, 162);
            nudMonto.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            nudMonto.Name = "nudMonto";
            nudMonto.Size = new Size(150, 27);
            nudMonto.TabIndex = 2;
            nudMonto.ValueChanged += nudMonto_ValueChanged;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(134, 247);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(94, 29);
            btnDepositar.TabIndex = 3;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click_1;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(134, 314);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(94, 29);
            btnRetirar.TabIndex = 4;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click_1;
            // 
            // lstMovimientos
            // 
            lstMovimientos.FormattingEnabled = true;
            lstMovimientos.Location = new Point(517, 212);
            lstMovimientos.Name = "lstMovimientos";
            lstMovimientos.Size = new Size(150, 104);
            lstMovimientos.TabIndex = 5;
            // 
            // btnMostrarTransferencia
            // 
            btnMostrarTransferencia.Location = new Point(134, 378);
            btnMostrarTransferencia.Name = "btnMostrarTransferencia";
            btnMostrarTransferencia.Size = new Size(94, 29);
            btnMostrarTransferencia.TabIndex = 6;
            btnMostrarTransferencia.Text = "Transferir";
            btnMostrarTransferencia.UseVisualStyleBackColor = true;
            btnMostrarTransferencia.Click += btnMostrarTransferencia_Click;
            // 
            // btnEnviarTransferencia
            // 
            btnEnviarTransferencia.Location = new Point(293, 378);
            btnEnviarTransferencia.Name = "btnEnviarTransferencia";
            btnEnviarTransferencia.Size = new Size(94, 29);
            btnEnviarTransferencia.TabIndex = 7;
            btnEnviarTransferencia.Text = "Enviar";
            btnEnviarTransferencia.UseVisualStyleBackColor = true;
            btnEnviarTransferencia.Visible = false;
            // 
            // lblCuentaDestino
            // 
            lblCuentaDestino.AutoSize = true;
            lblCuentaDestino.Location = new Point(332, 314);
            lblCuentaDestino.Name = "lblCuentaDestino";
            lblCuentaDestino.Size = new Size(145, 20);
            lblCuentaDestino.TabIndex = 8;
            lblCuentaDestino.Text = "Destino de la cuenta";
            lblCuentaDestino.Visible = false;
            // 
            // txtCuentaDestino
            // 
            txtCuentaDestino.Location = new Point(429, 379);
            txtCuentaDestino.Name = "txtCuentaDestino";
            txtCuentaDestino.Size = new Size(125, 27);
            txtCuentaDestino.TabIndex = 9;
            txtCuentaDestino.Text = "Numero de cuenta";
            txtCuentaDestino.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCuentaDestino);
            Controls.Add(lblCuentaDestino);
            Controls.Add(btnEnviarTransferencia);
            Controls.Add(btnMostrarTransferencia);
            Controls.Add(lstMovimientos);
            Controls.Add(btnRetirar);
            Controls.Add(btnDepositar);
            Controls.Add(nudMonto);
            Controls.Add(lblSaldo);
            Controls.Add(lblTitular);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudMonto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitular;
        private Label lblSaldo;
        private NumericUpDown nudMonto;
        private Button btnDepositar;
        private Button btnRetirar;
        private ListBox lstMovimientos;
        private Button btnMostrarTransferencia;
        private Button btnEnviarTransferencia;
        private Label lblCuentaDestino;
        private TextBox txtCuentaDestino;
    }
}

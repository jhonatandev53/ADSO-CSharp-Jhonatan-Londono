namespace Practica_1
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
            lblPregunta = new Label();
            txtNombre = new TextBox();
            btnSaludar = new Button();
            lblSaludo = new Label();
            lblNumero1 = new Label();
            lblNumero2 = new Label();
            lblResultado = new Label();
            txtNumero2 = new TextBox();
            txtResultado = new TextBox();
            txtNumero1 = new TextBox();
            btnSumar = new Button();
            btnRestar = new Button();
            btnMultiplicar = new Button();
            btnDividir = new Button();
            SuspendLayout();
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Font = new Font("Segoe UI Black", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPregunta.Location = new Point(221, 9);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(305, 46);
            lblPregunta.TabIndex = 0;
            lblPregunta.Text = "¿Como te llamas?";
            lblPregunta.Click += lblPregunta_Click;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = SystemColors.Info;
            txtNombre.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(269, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(216, 44);
            txtNombre.TabIndex = 1;
            // 
            // btnSaludar
            // 
            btnSaludar.BackColor = SystemColors.Highlight;
            btnSaludar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaludar.Location = new Point(296, 131);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(150, 41);
            btnSaludar.TabIndex = 2;
            btnSaludar.Text = "Saludar";
            btnSaludar.UseVisualStyleBackColor = false;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSaludo.Location = new Point(337, 184);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(0, 25);
            lblSaludo.TabIndex = 3;
            // 
            // lblNumero1
            // 
            lblNumero1.AutoSize = true;
            lblNumero1.Location = new Point(32, 207);
            lblNumero1.Name = "lblNumero1";
            lblNumero1.Size = new Size(75, 20);
            lblNumero1.TabIndex = 4;
            lblNumero1.Text = "Numero 1";
            // 
            // lblNumero2
            // 
            lblNumero2.AutoSize = true;
            lblNumero2.Location = new Point(32, 268);
            lblNumero2.Name = "lblNumero2";
            lblNumero2.Size = new Size(75, 20);
            lblNumero2.TabIndex = 5;
            lblNumero2.Text = "Numero 2";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(32, 336);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(75, 20);
            lblResultado.TabIndex = 6;
            lblResultado.Text = "Resultado";
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(148, 265);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(125, 27);
            txtNumero2.TabIndex = 7;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(148, 333);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(125, 27);
            txtResultado.TabIndex = 8;
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(148, 207);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(125, 27);
            txtNumero1.TabIndex = 9;
            // 
            // btnSumar
            // 
            btnSumar.BackColor = SystemColors.Desktop;
            btnSumar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSumar.Location = new Point(324, 259);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(94, 44);
            btnSumar.TabIndex = 10;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = false;
            btnSumar.Click += btnSumar_Click_1;
            // 
            // btnRestar
            // 
            btnRestar.BackColor = SystemColors.WindowFrame;
            btnRestar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRestar.Location = new Point(447, 259);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(94, 44);
            btnRestar.TabIndex = 11;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = false;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.BackColor = SystemColors.GradientActiveCaption;
            btnMultiplicar.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMultiplicar.Location = new Point(575, 259);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(94, 44);
            btnMultiplicar.TabIndex = 12;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = false;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(694, 259);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(94, 29);
            btnDividir.TabIndex = 13;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDividir);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(txtNumero1);
            Controls.Add(txtResultado);
            Controls.Add(txtNumero2);
            Controls.Add(lblResultado);
            Controls.Add(lblNumero2);
            Controls.Add(lblNumero1);
            Controls.Add(lblSaludo);
            Controls.Add(btnSaludar);
            Controls.Add(txtNombre);
            Controls.Add(lblPregunta);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPregunta;
        private TextBox txtNombre;
        private Button btnSaludar;
        private Label lblSaludo;
        private Label lblNumero1;
        private Label lblNumero2;
        private Label lblResultado;
        private TextBox txtNumero2;
        private TextBox txtResultado;
        private TextBox txtNumero1;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnMultiplicar;
        private Button btnDividir;
    }
}

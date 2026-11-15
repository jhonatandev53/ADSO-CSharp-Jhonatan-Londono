namespace Practica2
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
            components = new System.ComponentModel.Container();
            lblNombre = new Label();
            txtNombreCompleto = new TextBox();
            nudEdad = new NumericUpDown();
            cmbPrograma = new ComboBox();
            rdbManana = new RadioButton();
            rdbTarde = new RadioButton();
            chkTerminos = new CheckBox();
            btnInscribir = new Button();
            lstInscritos = new ListBox();
            lblEdad = new Label();
            lblPrograma = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(38, 21);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(132, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre completo";
            // 
            // txtNombreCompleto
            // 
            txtNombreCompleto.Location = new Point(45, 63);
            txtNombreCompleto.Name = "txtNombreCompleto";
            txtNombreCompleto.Size = new Size(125, 27);
            txtNombreCompleto.TabIndex = 0;
            // 
            // nudEdad
            // 
            nudEdad.Location = new Point(263, 63);
            nudEdad.Minimum = new decimal(new int[] { 14, 0, 0, 0 });
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(150, 27);
            nudEdad.TabIndex = 1;
            nudEdad.Value = new decimal(new int[] { 14, 0, 0, 0 });
            // 
            // cmbPrograma
            // 
            cmbPrograma.FormattingEnabled = true;
            cmbPrograma.Items.AddRange(new object[] { "ADSO", "Multimedia", "Contabilidad" });
            cmbPrograma.Location = new Point(568, 63);
            cmbPrograma.Name = "cmbPrograma";
            cmbPrograma.Size = new Size(151, 28);
            cmbPrograma.TabIndex = 2;
            cmbPrograma.Text = "elige tu carrera";
            // 
            // rdbManana
            // 
            rdbManana.AutoSize = true;
            rdbManana.Location = new Point(80, 164);
            rdbManana.Name = "rdbManana";
            rdbManana.Size = new Size(139, 24);
            rdbManana.TabIndex = 3;
            rdbManana.TabStop = true;
            rdbManana.Text = "Jornada mañana";
            rdbManana.UseVisualStyleBackColor = true;
            // 
            // rdbTarde
            // 
            rdbTarde.AutoSize = true;
            rdbTarde.Location = new Point(80, 221);
            rdbTarde.Name = "rdbTarde";
            rdbTarde.Size = new Size(121, 24);
            rdbTarde.TabIndex = 4;
            rdbTarde.TabStop = true;
            rdbTarde.Text = "Jornada tarde";
            rdbTarde.UseVisualStyleBackColor = true;
            // 
            // chkTerminos
            // 
            chkTerminos.AutoSize = true;
            chkTerminos.Location = new Point(322, 197);
            chkTerminos.Name = "chkTerminos";
            chkTerminos.Size = new Size(185, 24);
            chkTerminos.TabIndex = 5;
            chkTerminos.Text = "Terminos y condiciones";
            chkTerminos.UseVisualStyleBackColor = true;
            // 
            // btnInscribir
            // 
            btnInscribir.Location = new Point(301, 341);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(94, 29);
            btnInscribir.TabIndex = 7;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = true;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // lstInscritos
            // 
            lstInscritos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstInscritos.FormattingEnabled = true;
            lstInscritos.Location = new Point(569, 164);
            lstInscritos.Name = "lstInscritos";
            lstInscritos.Size = new Size(150, 104);
            lstInscritos.TabIndex = 6;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(322, 21);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(43, 20);
            lblEdad.TabIndex = 9;
            lblEdad.Text = "Edad";
            // 
            // lblPrograma
            // 
            lblPrograma.AutoSize = true;
            lblPrograma.Location = new Point(629, 23);
            lblPrograma.Name = "lblPrograma";
            lblPrograma.Size = new Size(74, 20);
            lblPrograma.TabIndex = 10;
            lblPrograma.Text = "Programa";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AcceptButton = btnInscribir;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPrograma);
            Controls.Add(lblEdad);
            Controls.Add(lstInscritos);
            Controls.Add(btnInscribir);
            Controls.Add(chkTerminos);
            Controls.Add(rdbTarde);
            Controls.Add(rdbManana);
            Controls.Add(cmbPrograma);
            Controls.Add(nudEdad);
            Controls.Add(txtNombreCompleto);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Inscripciones";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombreCompleto;
        private NumericUpDown nudEdad;
        private ComboBox cmbPrograma;
        private RadioButton rdbManana;
        private RadioButton rdbTarde;
        private CheckBox chkTerminos;
        private Button btnInscribir;
        private ListBox lstInscritos;
        private Label lblEdad;
        private Label lblPrograma;
        private ErrorProvider errorProvider1;
    }
}

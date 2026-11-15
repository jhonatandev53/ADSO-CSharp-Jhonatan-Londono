namespace Reto
{
    partial class FormPin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPin = new Label();
            txtPin = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // lblPin
            // 
            lblPin.AutoSize = true;
            lblPin.Location = new Point(340, 29);
            lblPin.Name = "lblPin";
            lblPin.Size = new Size(102, 20);
            lblPin.TabIndex = 0;
            lblPin.Text = "Ingrese su PIN";
            // 
            // txtPin
            // 
            txtPin.Location = new Point(331, 69);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(125, 27);
            txtPin.TabIndex = 1;
            txtPin.UseSystemPasswordChar = true;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(348, 137);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 29);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Ingresar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // FormPin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAceptar);
            Controls.Add(txtPin);
            Controls.Add(lblPin);
            Name = "FormPin";
            Text = "FormPin";
            Load += FormPin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPin;
        private TextBox txtPin;
        private Button btnAceptar;
    }
}
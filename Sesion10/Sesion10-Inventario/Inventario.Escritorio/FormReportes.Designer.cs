namespace Inventario.Escritorio
{
    partial class FormReportes
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
            dgvMasValiosos = new DataGridView();
            dgvStockBajo = new DataGridView();
            lbl1 = new Label();
            lbl2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMasValiosos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockBajo).BeginInit();
            SuspendLayout();
            // 
            // dgvMasValiosos
            // 
            dgvMasValiosos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMasValiosos.Location = new Point(35, 92);
            dgvMasValiosos.Name = "dgvMasValiosos";
            dgvMasValiosos.RowHeadersWidth = 51;
            dgvMasValiosos.Size = new Size(300, 188);
            dgvMasValiosos.TabIndex = 0;
            // 
            // dgvStockBajo
            // 
            dgvStockBajo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStockBajo.Location = new Point(448, 92);
            dgvStockBajo.Name = "dgvStockBajo";
            dgvStockBajo.RowHeadersWidth = 51;
            dgvStockBajo.Size = new Size(300, 188);
            dgvStockBajo.TabIndex = 1;
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Location = new Point(98, 40);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(163, 20);
            lbl1.TabIndex = 2;
            lbl1.Text = "Productos más valiosos";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Location = new Point(518, 49);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(175, 20);
            lbl2.TabIndex = 3;
            lbl2.Text = "Productos con stock bajo";
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(dgvStockBajo);
            Controls.Add(dgvMasValiosos);
            Name = "FormReportes";
            Text = "FormReportes";
            ((System.ComponentModel.ISupportInitialize)dgvMasValiosos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvStockBajo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMasValiosos;
        private DataGridView dgvStockBajo;
        private Label lbl1;
        private Label lbl2;
    }
}
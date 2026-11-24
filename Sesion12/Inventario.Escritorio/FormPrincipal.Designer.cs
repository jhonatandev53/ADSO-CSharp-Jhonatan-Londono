namespace Inventario.Escritorio
{
    partial class FormPrincipal
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
            txtBuscar = new TextBox();
            dgvProductos = new DataGridView();
            lblValor = new Label();
            btnAgregar = new Button();
            nudCantidad = new NumericUpDown();
            btnVender = new Button();
            btnAgregarStock = new Button();
            btnEliminar = new Button();
            btnReportes = new Button();
            cmbFiltroCategoria = new ComboBox();
            dgvResumenCategoria = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvResumenCategoria).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(351, 145);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(125, 27);
            txtBuscar.TabIndex = 0;
            // 
            // dgvProductos
            // 
            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Location = new Point(176, 196);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.ReadOnly = true;
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProductos.Size = new Size(300, 188);
            dgvProductos.TabIndex = 1;
            dgvProductos.CellDoubleClick += dgvProductos_CellDoubleClick;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(366, 64);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(50, 20);
            lblValor.TabIndex = 2;
            lblValor.Text = "label1";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(48, 102);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.Location = new Point(24, 155);
            nudCantidad.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(150, 27);
            nudCantidad.TabIndex = 4;
            nudCantidad.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnVender
            // 
            btnVender.Location = new Point(80, 227);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(94, 29);
            btnVender.TabIndex = 5;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // btnAgregarStock
            // 
            btnAgregarStock.Location = new Point(80, 277);
            btnAgregarStock.Name = "btnAgregarStock";
            btnAgregarStock.Size = new Size(94, 29);
            btnAgregarStock.TabIndex = 6;
            btnAgregarStock.Text = "Agregar stock";
            btnAgregarStock.UseVisualStyleBackColor = true;
            btnAgregarStock.Click += btnAgregarStock_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(80, 332);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(428, 409);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(94, 29);
            btnReportes.TabIndex = 8;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click;
            // 
            // cmbFiltroCategoria
            // 
            cmbFiltroCategoria.FormattingEnabled = true;
            cmbFiltroCategoria.Location = new Point(572, 144);
            cmbFiltroCategoria.Name = "cmbFiltroCategoria";
            cmbFiltroCategoria.Size = new Size(151, 28);
            cmbFiltroCategoria.TabIndex = 9;
            cmbFiltroCategoria.SelectedIndexChanged += cmbFiltroCategoria_SelectedIndexChanged;
            // 
            // dgvResumenCategoria
            // 
            dgvResumenCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvResumenCategoria.Location = new Point(488, 196);
            dgvResumenCategoria.Name = "dgvResumenCategoria";
            dgvResumenCategoria.RowHeadersWidth = 51;
            dgvResumenCategoria.Size = new Size(300, 188);
            dgvResumenCategoria.TabIndex = 10;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvResumenCategoria);
            Controls.Add(cmbFiltroCategoria);
            Controls.Add(btnReportes);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregarStock);
            Controls.Add(btnVender);
            Controls.Add(nudCantidad);
            Controls.Add(btnAgregar);
            Controls.Add(lblValor);
            Controls.Add(dgvProductos);
            Controls.Add(txtBuscar);
            Name = "FormPrincipal";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvResumenCategoria).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private DataGridView dgvProductos;
        private Label lblValor;
        private Button btnAgregar;
        private NumericUpDown nudCantidad;
        private Button btnVender;
        private Button btnAgregarStock;
        private Button btnEliminar;
        private Button btnReportes;
        private ComboBox cmbFiltroCategoria;
        private DataGridView dgvResumenCategoria;
    }
}

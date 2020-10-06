namespace PrimerParcial
{
    partial class FormComprar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormComprar));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.DGWCompras = new System.Windows.Forms.DataGridView();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreComprador = new System.Windows.Forms.TextBox();
            this.cmbProductos = new System.Windows.Forms.ComboBox();
            this.cmbCantidad = new System.Windows.Forms.ComboBox();
            this.btnFinalizarCompra = new System.Windows.Forms.Button();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.lblElegirProductos = new System.Windows.Forms.Label();
            this.lblCantidadProductos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGWCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SlateBlue;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(129, 444);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "TOTAL $";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DGWCompras
            // 
            this.DGWCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGWCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Producto,
            this.Cantidad});
            this.DGWCompras.Location = new System.Drawing.Point(192, 105);
            this.DGWCompras.Name = "DGWCompras";
            this.DGWCompras.Size = new System.Drawing.Size(247, 50);
            this.DGWCompras.TabIndex = 2;
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // txtNombreComprador
            // 
            this.txtNombreComprador.Location = new System.Drawing.Point(12, 12);
            this.txtNombreComprador.Name = "txtNombreComprador";
            this.txtNombreComprador.Size = new System.Drawing.Size(181, 20);
            this.txtNombreComprador.TabIndex = 3;
            // 
            // cmbProductos
            // 
            this.cmbProductos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductos.FormattingEnabled = true;
            this.cmbProductos.Location = new System.Drawing.Point(12, 132);
            this.cmbProductos.Name = "cmbProductos";
            this.cmbProductos.Size = new System.Drawing.Size(121, 21);
            this.cmbProductos.TabIndex = 4;
            this.cmbProductos.SelectedIndexChanged += new System.EventHandler(this.cmbProductos_SelectedIndexChanged);
            // 
            // cmbCantidad
            // 
            this.cmbCantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCantidad.FormattingEnabled = true;
            this.cmbCantidad.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbCantidad.Location = new System.Drawing.Point(12, 197);
            this.cmbCantidad.Name = "cmbCantidad";
            this.cmbCantidad.Size = new System.Drawing.Size(121, 21);
            this.cmbCantidad.TabIndex = 5;
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizarCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarCompra.Location = new System.Drawing.Point(129, 483);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(149, 41);
            this.btnFinalizarCompra.TabIndex = 6;
            this.btnFinalizarCompra.Text = "FINALIZAR COMPRA";
            this.btnFinalizarCompra.UseVisualStyleBackColor = false;
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(129, 384);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.Size = new System.Drawing.Size(149, 20);
            this.txtDescuento.TabIndex = 7;
            // 
            // lblElegirProductos
            // 
            this.lblElegirProductos.AutoSize = true;
            this.lblElegirProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblElegirProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblElegirProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElegirProductos.Location = new System.Drawing.Point(12, 105);
            this.lblElegirProductos.Name = "lblElegirProductos";
            this.lblElegirProductos.Size = new System.Drawing.Size(86, 15);
            this.lblElegirProductos.TabIndex = 8;
            this.lblElegirProductos.Text = "PRODUCTOS";
            // 
            // lblCantidadProductos
            // 
            this.lblCantidadProductos.AutoSize = true;
            this.lblCantidadProductos.BackColor = System.Drawing.Color.Transparent;
            this.lblCantidadProductos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCantidadProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidadProductos.Location = new System.Drawing.Point(12, 167);
            this.lblCantidadProductos.Name = "lblCantidadProductos";
            this.lblCantidadProductos.Size = new System.Drawing.Size(72, 15);
            this.lblCantidadProductos.TabIndex = 9;
            this.lblCantidadProductos.Text = "CANTIDAD";
            // 
            // FormComprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(480, 567);
            this.Controls.Add(this.lblCantidadProductos);
            this.Controls.Add(this.lblElegirProductos);
            this.Controls.Add(this.txtDescuento);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.cmbCantidad);
            this.Controls.Add(this.cmbProductos);
            this.Controls.Add(this.txtNombreComprador);
            this.Controls.Add(this.DGWCompras);
            this.Controls.Add(this.textBox1);
            this.MinimizeBox = false;
            this.Name = "FormComprar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "A COMPRAR!";
            this.Load += new System.EventHandler(this.FormComprar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGWCompras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView DGWCompras;
        private System.Windows.Forms.TextBox txtNombreComprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.ComboBox cmbProductos;
        private System.Windows.Forms.ComboBox cmbCantidad;
        private System.Windows.Forms.Button btnFinalizarCompra;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.Label lblElegirProductos;
        private System.Windows.Forms.Label lblCantidadProductos;
    }
}
namespace PrimerParcial
{
    partial class FrmCompra
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
            this.DgwCompra = new System.Windows.Forms.DataGridView();
            this.DgwProductos = new System.Windows.Forms.DataGridView();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.BtnFinalizar = new System.Windows.Forms.Button();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.CbxEmpleados = new System.Windows.Forms.ComboBox();
            this.CbxClientes = new System.Windows.Forms.ComboBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.LblEmpleado = new System.Windows.Forms.Label();
            this.LblCliente = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgwCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgwProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgwCompra
            // 
            this.DgwCompra.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.DgwCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwCompra.Location = new System.Drawing.Point(477, 43);
            this.DgwCompra.Name = "DgwCompra";
            this.DgwCompra.ReadOnly = true;
            this.DgwCompra.Size = new System.Drawing.Size(454, 265);
            this.DgwCompra.TabIndex = 0;
            // 
            // DgwProductos
            // 
            this.DgwProductos.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.DgwProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwProductos.Location = new System.Drawing.Point(12, 43);
            this.DgwProductos.Name = "DgwProductos";
            this.DgwProductos.Size = new System.Drawing.Size(412, 265);
            this.DgwProductos.TabIndex = 1;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidad.Location = new System.Drawing.Point(32, 330);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(70, 13);
            this.LblCantidad.TabIndex = 2;
            this.LblCantidad.Text = "CANTIDAD";
            // 
            // BtnFinalizar
            // 
            this.BtnFinalizar.Location = new System.Drawing.Point(781, 415);
            this.BtnFinalizar.Name = "BtnFinalizar";
            this.BtnFinalizar.Size = new System.Drawing.Size(123, 23);
            this.BtnFinalizar.TabIndex = 3;
            this.BtnFinalizar.Text = "Finalizar Compra";
            this.BtnFinalizar.UseVisualStyleBackColor = true;
            this.BtnFinalizar.Click += new System.EventHandler(this.BtnFinalizar_Click);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(126, 327);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(100, 20);
            this.TxtCantidad.TabIndex = 4;
            // 
            // CbxEmpleados
            // 
            this.CbxEmpleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxEmpleados.FormattingEnabled = true;
            this.CbxEmpleados.Location = new System.Drawing.Point(628, 327);
            this.CbxEmpleados.Name = "CbxEmpleados";
            this.CbxEmpleados.Size = new System.Drawing.Size(121, 21);
            this.CbxEmpleados.TabIndex = 7;
            // 
            // CbxClientes
            // 
            this.CbxClientes.FormattingEnabled = true;
            this.CbxClientes.Location = new System.Drawing.Point(628, 367);
            this.CbxClientes.Name = "CbxClientes";
            this.CbxClientes.Size = new System.Drawing.Size(121, 21);
            this.CbxClientes.TabIndex = 8;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(309, 335);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(115, 23);
            this.BtnAgregar.TabIndex = 10;
            this.BtnAgregar.Text = "Agregar al carrito";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpleado.Location = new System.Drawing.Point(480, 334);
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(142, 13);
            this.LblEmpleado.TabIndex = 11;
            this.LblEmpleado.Text = "Seleccione el empleado";
            // 
            // LblCliente
            // 
            this.LblCliente.AutoSize = true;
            this.LblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCliente.Location = new System.Drawing.Point(480, 367);
            this.LblCliente.Name = "LblCliente";
            this.LblCliente.Size = new System.Drawing.Size(126, 13);
            this.LblCliente.TabIndex = 12;
            this.LblCliente.Text = "Seleccione el cliente";
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(964, 450);
            this.Controls.Add(this.LblCliente);
            this.Controls.Add(this.LblEmpleado);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.CbxClientes);
            this.Controls.Add(this.CbxEmpleados);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.BtnFinalizar);
            this.Controls.Add(this.LblCantidad);
            this.Controls.Add(this.DgwProductos);
            this.Controls.Add(this.DgwCompra);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompra";
            this.ShowIcon = false;
            this.Text = "A comprar!";
            this.Load += new System.EventHandler(this.FrmCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgwCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgwProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgwCompra;
        private System.Windows.Forms.DataGridView DgwProductos;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Button BtnFinalizar;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.ComboBox CbxEmpleados;
        private System.Windows.Forms.ComboBox CbxClientes;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label LblEmpleado;
        private System.Windows.Forms.Label LblCliente;
    }
}
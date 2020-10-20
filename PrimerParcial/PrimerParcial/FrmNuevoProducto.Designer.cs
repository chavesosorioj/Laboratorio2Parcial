namespace PrimerParcial
{
    partial class FrmNuevoProducto
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
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.CbxTipoProducto = new System.Windows.Forms.ComboBox();
            this.TxtStock = new System.Windows.Forms.TextBox();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.LblStock = new System.Windows.Forms.Label();
            this.LblTipoP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(59, 38);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(128, 20);
            this.TxtNombre.TabIndex = 0;
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Location = new System.Drawing.Point(59, 85);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(128, 20);
            this.TxtPrecio.TabIndex = 1;
            // 
            // CbxTipoProducto
            // 
            this.CbxTipoProducto.FormattingEnabled = true;
            this.CbxTipoProducto.Location = new System.Drawing.Point(59, 196);
            this.CbxTipoProducto.Name = "CbxTipoProducto";
            this.CbxTipoProducto.Size = new System.Drawing.Size(128, 21);
            this.CbxTipoProducto.TabIndex = 3;
            // 
            // TxtStock
            // 
            this.TxtStock.Location = new System.Drawing.Point(59, 135);
            this.TxtStock.Name = "TxtStock";
            this.TxtStock.Size = new System.Drawing.Size(128, 20);
            this.TxtStock.TabIndex = 2;
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(84, 261);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 4;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.Location = new System.Drawing.Point(56, 22);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(104, 13);
            this.LblNombre.TabIndex = 5;
            this.LblNombre.Text = "Nombre producto";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.Location = new System.Drawing.Point(59, 69);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(43, 13);
            this.LblPrecio.TabIndex = 6;
            this.LblPrecio.Text = "Precio";
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStock.Location = new System.Drawing.Point(59, 121);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(40, 13);
            this.LblStock.TabIndex = 7;
            this.LblStock.Text = "Stock";
            // 
            // LblTipoP
            // 
            this.LblTipoP.AutoSize = true;
            this.LblTipoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoP.Location = new System.Drawing.Point(62, 178);
            this.LblTipoP.Name = "LblTipoP";
            this.LblTipoP.Size = new System.Drawing.Size(86, 13);
            this.LblTipoP.TabIndex = 8;
            this.LblTipoP.Text = "Tipo producto";
            // 
            // FrmNuevoProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(236, 346);
            this.Controls.Add(this.LblTipoP);
            this.Controls.Add(this.LblStock);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtStock);
            this.Controls.Add(this.CbxTipoProducto);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.TxtNombre);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoProducto";
            this.ShowIcon = false;
            this.Text = "Agregar nuevo producto";
            this.Load += new System.EventHandler(this.FrmNuevoProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtPrecio;
        private System.Windows.Forms.ComboBox CbxTipoProducto;
        private System.Windows.Forms.TextBox TxtStock;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.Label LblStock;
        private System.Windows.Forms.Label LblTipoP;
    }
}
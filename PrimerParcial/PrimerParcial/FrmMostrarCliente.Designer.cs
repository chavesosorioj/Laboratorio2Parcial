namespace PrimerParcial
{
    partial class FrmMostrarCliente
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
            this.DgwClientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgwClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // DgwClientes
            // 
            this.DgwClientes.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.DgwClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwClientes.Location = new System.Drawing.Point(35, 43);
            this.DgwClientes.Name = "DgwClientes";
            this.DgwClientes.ReadOnly = true;
            this.DgwClientes.Size = new System.Drawing.Size(470, 168);
            this.DgwClientes.TabIndex = 0;
            // 
            // FrmMostrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(566, 284);
            this.Controls.Add(this.DgwClientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMostrarCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Kwik E Mart";
            this.Load += new System.EventHandler(this.FrmMostrarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgwClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgwClientes;
    }
}
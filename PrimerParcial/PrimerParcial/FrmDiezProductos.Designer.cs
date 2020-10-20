namespace PrimerParcial
{
    partial class FrmDiezProductos
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
            this.DgwDiezProd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgwDiezProd)).BeginInit();
            this.SuspendLayout();
            // 
            // DgwDiezProd
            // 
            this.DgwDiezProd.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.DgwDiezProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwDiezProd.Location = new System.Drawing.Point(58, 30);
            this.DgwDiezProd.Name = "DgwDiezProd";
            this.DgwDiezProd.Size = new System.Drawing.Size(427, 232);
            this.DgwDiezProd.TabIndex = 0;
            // 
            // FrmDiezProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(564, 337);
            this.Controls.Add(this.DgwDiezProd);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDiezProductos";
            this.ShowIcon = false;
            this.Text = "Producos con pocas unidades";
            this.Load += new System.EventHandler(this.FrmDiezProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgwDiezProd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgwDiezProd;
    }
}
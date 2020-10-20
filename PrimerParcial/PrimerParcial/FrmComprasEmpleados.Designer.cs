namespace PrimerParcial
{
    partial class FrmComprasEmpleados
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
            this.DgwComprasEmpleados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgwComprasEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // DgwComprasEmpleados
            // 
            this.DgwComprasEmpleados.BackgroundColor = System.Drawing.Color.DarkSlateGray;
            this.DgwComprasEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgwComprasEmpleados.Location = new System.Drawing.Point(28, 27);
            this.DgwComprasEmpleados.Name = "DgwComprasEmpleados";
            this.DgwComprasEmpleados.Size = new System.Drawing.Size(347, 249);
            this.DgwComprasEmpleados.TabIndex = 0;
            // 
            // FrmComprasEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(433, 361);
            this.Controls.Add(this.DgwComprasEmpleados);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmComprasEmpleados";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compras por empleado";
            this.Load += new System.EventHandler(this.FrmComprasEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgwComprasEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgwComprasEmpleados;
    }
}
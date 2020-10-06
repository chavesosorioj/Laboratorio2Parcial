namespace PrimerParcial
{
    partial class FrmEmpleado
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtNombreEmp = new System.Windows.Forms.TextBox();
            this.txtIdemple = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lblNombreEmpleado = new System.Windows.Forms.Label();
            this.lblIdemple = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtNombreEmp
            // 
            this.txtNombreEmp.Location = new System.Drawing.Point(51, 54);
            this.txtNombreEmp.Name = "txtNombreEmp";
            this.txtNombreEmp.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEmp.TabIndex = 1;
            // 
            // txtIdemple
            // 
            this.txtIdemple.Location = new System.Drawing.Point(51, 104);
            this.txtIdemple.Name = "txtIdemple";
            this.txtIdemple.Size = new System.Drawing.Size(100, 20);
            this.txtIdemple.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(26, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Registrar empleado";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblNombreEmpleado
            // 
            this.lblNombreEmpleado.AutoSize = true;
            this.lblNombreEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreEmpleado.Location = new System.Drawing.Point(48, 38);
            this.lblNombreEmpleado.Name = "lblNombreEmpleado";
            this.lblNombreEmpleado.Size = new System.Drawing.Size(50, 13);
            this.lblNombreEmpleado.TabIndex = 4;
            this.lblNombreEmpleado.Text = "Nombre";
            // 
            // lblIdemple
            // 
            this.lblIdemple.AutoSize = true;
            this.lblIdemple.BackColor = System.Drawing.Color.Transparent;
            this.lblIdemple.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdemple.Location = new System.Drawing.Point(48, 88);
            this.lblIdemple.Name = "lblIdemple";
            this.lblIdemple.Size = new System.Drawing.Size(77, 13);
            this.lblIdemple.TabIndex = 5;
            this.lblIdemple.Text = "Id Empleado";
            // 
            // FrmEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrimerParcial.Properties.Resources.kwik;
            this.ClientSize = new System.Drawing.Size(211, 248);
            this.Controls.Add(this.lblIdemple);
            this.Controls.Add(this.lblNombreEmpleado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtIdemple);
            this.Controls.Add(this.txtNombreEmp);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEmpleado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login empleado";
            this.Load += new System.EventHandler(this.FrmEmpleado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNombreEmp;
        private System.Windows.Forms.TextBox txtIdemple;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblNombreEmpleado;
        private System.Windows.Forms.Label lblIdemple;
    }
}
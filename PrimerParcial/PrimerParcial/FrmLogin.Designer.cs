namespace PrimerParcial
{
    partial class FrmLogin
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
            this.txtBUsuario = new System.Windows.Forms.TextBox();
            this.txtBContraseña = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblAdmin1 = new System.Windows.Forms.Label();
            this.lblAdmin2 = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContrasenia = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBUsuario
            // 
            this.txtBUsuario.Location = new System.Drawing.Point(61, 62);
            this.txtBUsuario.Name = "txtBUsuario";
            this.txtBUsuario.Size = new System.Drawing.Size(140, 20);
            this.txtBUsuario.TabIndex = 0;
            // 
            // txtBContraseña
            // 
            this.txtBContraseña.Location = new System.Drawing.Point(61, 101);
            this.txtBContraseña.Name = "txtBContraseña";
            this.txtBContraseña.PasswordChar = '*';
            this.txtBContraseña.Size = new System.Drawing.Size(140, 20);
            this.txtBContraseña.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(61, 176);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(140, 23);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // lblAdmin1
            // 
            this.lblAdmin1.AutoSize = true;
            this.lblAdmin1.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin1.Location = new System.Drawing.Point(225, 69);
            this.lblAdmin1.Name = "lblAdmin1";
            this.lblAdmin1.Size = new System.Drawing.Size(35, 13);
            this.lblAdmin1.TabIndex = 5;
            this.lblAdmin1.Text = "admin";
            // 
            // lblAdmin2
            // 
            this.lblAdmin2.AutoSize = true;
            this.lblAdmin2.BackColor = System.Drawing.Color.Transparent;
            this.lblAdmin2.Location = new System.Drawing.Point(225, 108);
            this.lblAdmin2.Name = "lblAdmin2";
            this.lblAdmin2.Size = new System.Drawing.Size(35, 13);
            this.lblAdmin2.TabIndex = 6;
            this.lblAdmin2.Text = "admin";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(58, 46);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 13);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContrasenia
            // 
            this.lblContrasenia.AutoSize = true;
            this.lblContrasenia.BackColor = System.Drawing.Color.Transparent;
            this.lblContrasenia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasenia.Location = new System.Drawing.Point(58, 85);
            this.lblContrasenia.Name = "lblContrasenia";
            this.lblContrasenia.Size = new System.Drawing.Size(71, 13);
            this.lblContrasenia.TabIndex = 4;
            this.lblContrasenia.Text = "Contraseña";
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(289, 239);
            this.Controls.Add(this.lblContrasenia);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblAdmin2);
            this.Controls.Add(this.lblAdmin1);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtBContraseña);
            this.Controls.Add(this.txtBUsuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logueate!";
            this.Load += new System.EventHandler(this.FrmInicioCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBUsuario;
        private System.Windows.Forms.TextBox txtBContraseña;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblAdmin1;
        private System.Windows.Forms.Label lblAdmin2;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContrasenia;
    }
}
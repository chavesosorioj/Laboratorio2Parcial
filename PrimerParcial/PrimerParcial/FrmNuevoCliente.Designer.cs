namespace PrimerParcial
{
    partial class FrmNuevoCliente
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
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtDniCliente = new System.Windows.Forms.TextBox();
            this.txtContraseñaCliente = new System.Windows.Forms.TextBox();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.txtBoxDomicilio = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.lblContraseniaCliente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Location = new System.Drawing.Point(101, 258);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(75, 23);
            this.BtnAceptar.TabIndex = 0;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNombreCliente.Location = new System.Drawing.Point(66, 46);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(139, 20);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // txtDniCliente
            // 
            this.txtDniCliente.Location = new System.Drawing.Point(66, 135);
            this.txtDniCliente.Name = "txtDniCliente";
            this.txtDniCliente.Size = new System.Drawing.Size(139, 20);
            this.txtDniCliente.TabIndex = 3;
            // 
            // txtContraseñaCliente
            // 
            this.txtContraseñaCliente.Location = new System.Drawing.Point(66, 222);
            this.txtContraseñaCliente.Name = "txtContraseñaCliente";
            this.txtContraseñaCliente.Size = new System.Drawing.Size(139, 20);
            this.txtContraseñaCliente.TabIndex = 4;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(66, 89);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(139, 20);
            this.txtApellidoCliente.TabIndex = 5;
            // 
            // txtBoxDomicilio
            // 
            this.txtBoxDomicilio.Location = new System.Drawing.Point(66, 178);
            this.txtBoxDomicilio.Name = "txtBoxDomicilio";
            this.txtBoxDomicilio.Size = new System.Drawing.Size(139, 20);
            this.txtBoxDomicilio.TabIndex = 6;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.Location = new System.Drawing.Point(63, 30);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(50, 13);
            this.lblNombreCliente.TabIndex = 7;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoCliente.Location = new System.Drawing.Point(63, 69);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(52, 13);
            this.lblApellidoCliente.TabIndex = 8;
            this.lblApellidoCliente.Text = "Apellido";
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblDniCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDniCliente.Location = new System.Drawing.Point(63, 112);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(29, 13);
            this.lblDniCliente.TabIndex = 9;
            this.lblDniCliente.Text = "DNI";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.BackColor = System.Drawing.Color.Transparent;
            this.lblDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(63, 162);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(58, 13);
            this.lblDomicilio.TabIndex = 10;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // lblContraseniaCliente
            // 
            this.lblContraseniaCliente.AutoSize = true;
            this.lblContraseniaCliente.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseniaCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseniaCliente.Location = new System.Drawing.Point(63, 206);
            this.lblContraseniaCliente.Name = "lblContraseniaCliente";
            this.lblContraseniaCliente.Size = new System.Drawing.Size(74, 13);
            this.lblContraseniaCliente.TabIndex = 11;
            this.lblContraseniaCliente.Text = "Contrasenia";
            // 
            // FrmNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.BackgroundImage = global::PrimerParcial.Properties.Resources.kwik;
            this.ClientSize = new System.Drawing.Size(260, 326);
            this.Controls.Add(this.lblContraseniaCliente);
            this.Controls.Add(this.lblDomicilio);
            this.Controls.Add(this.lblDniCliente);
            this.Controls.Add(this.lblApellidoCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.txtBoxDomicilio);
            this.Controls.Add(this.txtApellidoCliente);
            this.Controls.Add(this.txtContraseñaCliente);
            this.Controls.Add(this.txtDniCliente);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.BtnAceptar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmNuevoCliente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Cliente :)";
            this.Load += new System.EventHandler(this.FrmNuevoCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtDniCliente;
        private System.Windows.Forms.TextBox txtContraseñaCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.TextBox txtBoxDomicilio;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.Label lblContraseniaCliente;
    }
}
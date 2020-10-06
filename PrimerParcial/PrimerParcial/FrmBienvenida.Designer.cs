namespace PrimerParcial
{
    partial class FormBienvenida
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.informacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosUltimas10ComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostrarClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridMostrar = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.informacionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(537, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.UseWaitCursor = true;
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.empleadoToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoClienteToolStripMenuItem,
            this.ingresarToolStripMenuItem});
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            // 
            // nuevoClienteToolStripMenuItem
            // 
            this.nuevoClienteToolStripMenuItem.Name = "nuevoClienteToolStripMenuItem";
            this.nuevoClienteToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.nuevoClienteToolStripMenuItem.Text = "Nuevo Cliente";
            this.nuevoClienteToolStripMenuItem.Click += new System.EventHandler(this.nuevoClienteToolStripMenuItem_Click);
            // 
            // ingresarToolStripMenuItem
            // 
            this.ingresarToolStripMenuItem.Name = "ingresarToolStripMenuItem";
            this.ingresarToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.ingresarToolStripMenuItem.Text = "Ingresar a comprar!";
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            // 
            // informacionToolStripMenuItem
            // 
            this.informacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empleadosUltimas10ComprasToolStripMenuItem,
            this.mostrarEmpleadosToolStripMenuItem,
            this.mostrarClientesToolStripMenuItem});
            this.informacionToolStripMenuItem.Name = "informacionToolStripMenuItem";
            this.informacionToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.informacionToolStripMenuItem.Text = "Informacion";
            // 
            // empleadosUltimas10ComprasToolStripMenuItem
            // 
            this.empleadosUltimas10ComprasToolStripMenuItem.Name = "empleadosUltimas10ComprasToolStripMenuItem";
            this.empleadosUltimas10ComprasToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.empleadosUltimas10ComprasToolStripMenuItem.Text = "Empleados ultimas 10 compras";
            // 
            // mostrarEmpleadosToolStripMenuItem
            // 
            this.mostrarEmpleadosToolStripMenuItem.Name = "mostrarEmpleadosToolStripMenuItem";
            this.mostrarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.mostrarEmpleadosToolStripMenuItem.Text = "Mostrar Empleados";
            this.mostrarEmpleadosToolStripMenuItem.Click += new System.EventHandler(this.mostrarEmpleadosToolStripMenuItem_Click);
            // 
            // mostrarClientesToolStripMenuItem
            // 
            this.mostrarClientesToolStripMenuItem.Name = "mostrarClientesToolStripMenuItem";
            this.mostrarClientesToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.mostrarClientesToolStripMenuItem.Text = "Mostrar Clientes";
            this.mostrarClientesToolStripMenuItem.Click += new System.EventHandler(this.mostrarClientesToolStripMenuItem_Click);
            // 
            // dataGridMostrar
            // 
            this.dataGridMostrar.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMostrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataGridMostrar.Location = new System.Drawing.Point(35, 72);
            this.dataGridMostrar.Name = "dataGridMostrar";
            this.dataGridMostrar.Size = new System.Drawing.Size(442, 150);
            this.dataGridMostrar.TabIndex = 8;
            // 
            // FormBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrimerParcial.Properties.Resources.kwik;
            this.ClientSize = new System.Drawing.Size(537, 281);
            this.Controls.Add(this.dataGridMostrar);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBienvenida";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "kwik E Mart";
            this.TransparencyKey = System.Drawing.Color.White;
            this.UseWaitCursor = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormBienvenida_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nuevoClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosUltimas10ComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mostrarEmpleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostrarClientesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridMostrar;
    }
}


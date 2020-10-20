using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PrimerParcial
{
    public partial class FrmNuevoCliente : Form
    {
        public FrmNuevoCliente()
        {
            InitializeComponent();
        }

        private void FrmNuevoCliente_Load(object sender, EventArgs e)
        {
            this.Text = "Nuevo Cliente :)";
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if(!(Validaciones.ContieneLetras(this.txtNombreCliente.Text) && Validaciones.ContieneLetras(this.txtApellidoCliente.Text) && 
                Validaciones.EsNumerico(this.txtDniCliente.Text) && Validaciones.VerificaDomicilio(txtBoxDomicilio.Text)))
            {
                int.TryParse(txtDniCliente.Text, out int auxDni);
                string desc = Validaciones.ConSinDescuento(txtNombreCliente.Text);
                KwikEMart.AgregarCliente(new Cliente(txtNombreCliente.Text, txtApellidoCliente.Text, auxDni, txtBoxDomicilio.Text, desc));
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error en los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            
        }

    }
}

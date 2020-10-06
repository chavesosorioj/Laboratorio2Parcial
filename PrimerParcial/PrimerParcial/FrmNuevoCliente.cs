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
        #region Atributo
        private Cliente cliente;
        #endregion

        #region Propiedad
        public Cliente Cliente
        {
            get { return this.cliente; }
            set { this.cliente = value; }
        }
        #endregion
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
            if(Validaciones.ContieneLetras(this.txtNombreCliente.Text) && Validaciones.ContieneLetras(this.txtApellidoCliente.Text) && 
                Validaciones.EsNumerico(this.txtDniCliente.Text) && Validaciones.EsNumerico(this.txtContraseñaCliente.Text)
                && Validaciones.VerificaDomicilio(txtBoxDomicilio.Text))
            {
                int.TryParse(txtDniCliente.Text, out int auxDni);
                int.TryParse(txtContraseñaCliente.Text, out int auxContrasenia);
                string desc = Validaciones.ConSinDescuento(txtNombreCliente.Text);
                cliente = new Cliente(txtNombreCliente.Text, txtApellidoCliente.Text, auxDni, txtBoxDomicilio.Text, auxContrasenia, desc);
            
            }
            else
            {
                MessageBox.Show("Error en los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); // ver si le pongo algo màs a los paràmetros
            }
        }

    }
}

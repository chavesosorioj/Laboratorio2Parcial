using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PrimerParcial
{
    public partial class FrmNuevoProducto : Form
    {
        public FrmNuevoProducto()
        {
            InitializeComponent();
        }

        private void FrmNuevoProducto_Load(object sender, EventArgs e)
        {
            CbxTipoProducto.DataSource = Enum.GetValues(typeof(ETipoProducto));
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if(Validaciones.ContieneLetras(this.TxtNombre.Text) && Validaciones.EsNumerico(this.TxtPrecio.Text) && Validaciones.EsNumerico(this.TxtStock.Text) && this.CbxTipoProducto.SelectedIndex != -1)
            {
                int.TryParse(this.TxtPrecio.Text, out int precio);
                int.TryParse(this.TxtStock.Text, out int stock);
                KwikEMart.AgregarProducto(new Producto(TxtNombre.Text, precio, stock, (ETipoProducto)CbxTipoProducto.SelectedItem));
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Error en los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

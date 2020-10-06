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
    public partial class FormComprar : Form
    {
        public FormComprar()
        {
            InitializeComponent();
        }

        private void FormComprar_Load(object sender, EventArgs e)
        {
            this.txtNombreComprador.Text = "Bienvenido"; // sumarle el nombre del que compra
            this.cmbProductos.DataSource = Enum.GetValues(typeof(EProductos));
        }

        private void cmbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

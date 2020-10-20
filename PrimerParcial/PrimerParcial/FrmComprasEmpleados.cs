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
    public partial class FrmComprasEmpleados : Form
    {
        public FrmComprasEmpleados()
        {
            InitializeComponent();
        }

        private void FrmComprasEmpleados_Load(object sender, EventArgs e)
        {
            CargaDatos();
            CargaDGW();
        }

        private void CargaDatos()
        {
            this.DgwComprasEmpleados.DataSource = null;
            this.DgwComprasEmpleados.DataSource = KwikEMart.ListaCompras;
        }
     private void CargaDGW()
        {
            this.DgwComprasEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwComprasEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

        }
    }
}

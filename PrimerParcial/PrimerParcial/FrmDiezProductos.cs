using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class FrmDiezProductos : Form
    {
        public DataGridView DataDProductos
        {
            get { return this.DgwDiezProd; }
        }
        public FrmDiezProductos()
        {
            InitializeComponent();
        }

        private void FrmDiezProductos_Load(object sender, EventArgs e)
        {
            this.DgwDiezProd.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwDiezProd.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}

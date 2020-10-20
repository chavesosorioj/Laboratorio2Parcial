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
    public partial class FrmMostrarEmpleado : Form
    {
        
        public DataGridView DataEmpleados
        {
            get{ return this.DgwEmpleados; }
        }
        
        public FrmMostrarEmpleado()
        {
            InitializeComponent();
        }

        private void FrmMostrarEmpleado_Load(object sender, EventArgs e)
        {

            this.DgwEmpleados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwEmpleados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

    }
}

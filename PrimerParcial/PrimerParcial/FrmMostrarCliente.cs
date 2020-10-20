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
    public partial class FrmMostrarCliente : Form
    {
        public object Cliente
        {
            get { return this.Cliente; }
        }
        public DataGridView DataClientes
        {
            get { return this.DgwClientes; }
        }
        public FrmMostrarCliente()
        {
            InitializeComponent();
        }


        private void FrmMostrarCliente_Load(object sender, EventArgs e)
        {
            this.DgwClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwClientes.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
    }
}

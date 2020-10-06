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
    public partial class FormBienvenida : Form
    {
        List<Cliente> listaClientes;
        List<Empleado> listaEmpleados;
        public FormBienvenida()
        {
            InitializeComponent();
            listaClientes = new List<Cliente>();
            listaEmpleados = new List<Empleado>();
            HardcodeoClientes();
            HardcodeoEmpleados();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Kwik E Mart";
        }

         private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEmpleado frmEmpe = new FrmEmpleado();
            frmEmpe.ShowDialog();
            this.Close();
        }

        private void FormBienvenida_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Gracias, vuelva prontosss!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                e.Cancel = true;
        }

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente frmNuevoCliente = new FrmNuevoCliente();
            if(frmNuevoCliente.ShowDialog() == DialogResult.OK)
            {
                if (frmNuevoCliente.ShowDialog() == DialogResult.OK)
                {
                    listaClientes.Add(frmNuevoCliente.Cliente);
                    MessageBox.Show("se agrego nuevo cliente", "Alta cliente");
                }
                    
            }
        }


        private void HardcodeoClientes()
        {
            listaClientes.Add(new Cliente("Homero", "Simpson", 834729, "siempreviva 742",111, "Con descuento"));
            listaClientes.Add(new Cliente("Marge", "Simpson", 834729, "siempreviva 742", 222, "Con descuento"));
            listaClientes.Add(new Cliente("Bart", "Simpson", 834729, "siempreviva 742", 333, "Con descuento"));
            listaClientes.Add(new Cliente("Lisa", "Simpson", 834729, "siempreviva 742", 444, "Con descuento"));
            listaClientes.Add(new Cliente("Maggie", "Simpson", 834729, "siempreviva 742", 555, "Con descuento"));
        }

        private void HardcodeoEmpleados()
        {
            listaEmpleados.Add(new Empleado("Apu", "Nahasapeemapetilon", 12345, EPuesto.Cajero));
            listaEmpleados.Add(new Empleado("Manjula", "Nahasapeemapetilon", 56789, EPuesto.Repositor));
            listaEmpleados.Add(new Empleado("Ned","Flanders",793458,EPuesto.Limpieza));

        }

        private void mostrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargaDatagridEmpleados(listaEmpleados);
        }

        private void ConfiguracionDatagrid()
        {
            this.dataGridMostrar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
         //   this.dataGridMostrar.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        }

       private void CargaDatagridEmpleados(List<Empleado> lista)
        {
            this.dataGridMostrar.DataSource = null;
            this.dataGridMostrar.DataSource = lista;
            ConfiguracionDatagrid();

        }

        private void CargaDatagridClientes(List<Cliente> lista)
        {
            this.dataGridMostrar.DataSource = null;
            this.dataGridMostrar.DataSource = lista;
            ConfiguracionDatagrid();

        }

        private void mostrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CargaDatagridClientes(listaClientes);
        }
    }
}

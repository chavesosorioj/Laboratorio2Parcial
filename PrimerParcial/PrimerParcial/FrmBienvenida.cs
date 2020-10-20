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
using Excepciones;

namespace PrimerParcial
{
    public partial class FormBienvenida : Form
    {
        public FormBienvenida()
        {
            InitializeComponent();

         }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Kwik E Mart";
            HardcodeoClientes();
            HardcodeoEmpleados();
            HarcodeoProductos();
            HarcodeoCompras();
        }

        private void mostrarEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrarEmpleado frmEmpleados = new FrmMostrarEmpleado();
            frmEmpleados.DataEmpleados.DataSource = KwikEMart.ListaEmpleados;
            frmEmpleados.ShowDialog();
          }


      private void mostrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMostrarCliente frmClientes = new FrmMostrarCliente();
            frmClientes.DataClientes.DataSource = KwikEMart.ListaClientes;
            frmClientes.ShowDialog();
        }

        #region harcodeo
        private void HardcodeoClientes()
        {
            KwikEMart.AgregarCliente(new Cliente("Homero", "Simpson", 1111111, "siempreviva 742", "Con descuento"));
            KwikEMart.AgregarCliente(new Cliente("Marge", "Simpson", 2222222, "siempreviva 742", "Con descuento"));
            KwikEMart.AgregarCliente(new Cliente("Bart", "Simpson", 3333333, "siempreviva 742", "Con descuento"));
            KwikEMart.AgregarCliente(new Cliente("Lisa", "Simpson", 4444444, "siempreviva 742", "Con descuento"));
            KwikEMart.AgregarCliente(new Cliente("Maggie", "Simpson", 5555555, "siempreviva 742", "Con descuento"));
        }


        private void HardcodeoEmpleados()
        {
            KwikEMart.AgregarEmpleado(new Empleado("Apu", "Nahasapeemapetilon", 7777777, 23));
            KwikEMart.AgregarEmpleado(new Empleado("Manjula", "Nahasapeemapetilon", 8888888, 45));
            KwikEMart.AgregarEmpleado(new Empleado("Ned", "Flanders", 9999999, 16));

        }

        private void HarcodeoProductos()
        {
            KwikEMart.AgregarProducto(new Producto("Salchichas",40,9, ETipoProducto.congelados));
            KwikEMart.AgregarProducto(new Producto("Tapa empanada",45,120,ETipoProducto.congelados));
            KwikEMart.AgregarProducto(new Producto("Manteca",70,78,ETipoProducto.congelados));
            KwikEMart.AgregarProducto(new Producto("Helado",80, 130, ETipoProducto.congelados));
            KwikEMart.AgregarProducto(new Producto("Banana",30,80,ETipoProducto.frutas));
            KwikEMart.AgregarProducto(new Producto("Mandarina", 50, 90, ETipoProducto.frutas));
            KwikEMart.AgregarProducto(new Producto("Frutilla", 90, 120, ETipoProducto.frutas));
            KwikEMart.AgregarProducto(new Producto("Manzana", 78, 98, ETipoProducto.frutas));
            KwikEMart.AgregarProducto(new Producto("Shampoo",80, 7, ETipoProducto.higiene));
            KwikEMart.AgregarProducto(new Producto("Acondicionador", 78, 7, ETipoProducto.higiene));
            KwikEMart.AgregarProducto(new Producto("Jabon", 45, 78, ETipoProducto.higiene));
            KwikEMart.AgregarProducto(new Producto("Desodorante", 80, 78, ETipoProducto.higiene));
            KwikEMart.AgregarProducto(new Producto("Lavandina",56,120,ETipoProducto.limpieza));
            KwikEMart.AgregarProducto(new Producto("Jabon en polvo", 90, 120, ETipoProducto.limpieza));
            KwikEMart.AgregarProducto(new Producto("Trapo de piso", 79, 120, ETipoProducto.limpieza));
            KwikEMart.AgregarProducto(new Producto("Limpia piso", 80, 120, ETipoProducto.limpieza));
            KwikEMart.AgregarProducto(new Producto("Fideos",37,96,ETipoProducto.secos));
            KwikEMart.AgregarProducto(new Producto("Arroz", 45, 98, ETipoProducto.secos));
            KwikEMart.AgregarProducto(new Producto("Galletitas", 37, 97, ETipoProducto.secos));
            KwikEMart.AgregarProducto(new Producto("Polenta", 37, 96, ETipoProducto.secos));
        }

        private void HarcodeoCompras()
        {
            KwikEMart.AgregarCompra(new Compra("Homero","Apu", 560));
            KwikEMart.AgregarCompra(new Compra("Marge", "Manjula", 790));
            KwikEMart.AgregarCompra(new Compra("Homero", "Manjula", 40));
            KwikEMart.AgregarCompra(new Compra("Bart", "Apu", 300));
            KwikEMart.AgregarCompra(new Compra("Lisa", "Apu", 20));
        }
        #endregion

        private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoCliente nuevoCliente = new FrmNuevoCliente();
            if (nuevoCliente.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Nuevo cliente agregado");
        }

        private void iniciarCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCompra frmCompra = new FrmCompra();
            frmCompra.ShowDialog();
        }

        private void agregarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoEmpleado nuevoEmpleado = new FrmNuevoEmpleado();
            if(nuevoEmpleado.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Nuevo empleado agregado");
        }

        private void cerrarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea salir?","Gracias, vuelva prontosss", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void totalStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"La cantidad de productos total en stock es de {Producto.TotalStock(KwikEMart.ListaProductos)}");
        }

        private void productosConMenosDe10UnidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDiezProductos diezProductos = new FrmDiezProductos();
            diezProductos.DataDProductos.DataSource = Producto.MenosDiezProd(KwikEMart.ListaProductos);
            diezProductos.ShowDialog();

        }

        private void agregarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoProducto nuevoProducto = new FrmNuevoProducto();
            if (nuevoProducto.ShowDialog() == DialogResult.OK)
                MessageBox.Show("Nuevo producto agregado");
        }

        private void empleadosUltimas10ComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmComprasEmpleados comprasEmplados = new FrmComprasEmpleados();
            comprasEmplados.ShowDialog();
        }

        private void menuStrip1_MouseHover(object sender, EventArgs e)
        {
            this.menuStrip1.Visible = true;
        }
    }
}

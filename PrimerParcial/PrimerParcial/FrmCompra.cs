using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using Entidades;

namespace PrimerParcial
{
    public partial class FrmCompra : Form
    {
        List<ItemProducto> listaCarrito;
        ItemProducto item;
        Producto productoSeleccionado;
        public double precioTotal;
        public int cantidadUnidades;
        public int descuento;
        public string nombreCliente;
        public string nombreEmpleado;
        SoundPlayer sonidoCaja;

        public FrmCompra()
        {
            InitializeComponent();
            this.sonidoCaja = new SoundPlayer(@"..\sound\registradora.wav");
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            listaCarrito = new List<ItemProducto>();
            CargaDatos();
            ConfiguracionDProd();
            CargaCmb();
           }

        private void CargaDatos()
        {
            this.DgwProductos.DataSource = null;
            this.DgwProductos.DataSource = KwikEMart.ListaProductos;
        }
        private void ConfiguracionDProd()
        {
            this.DgwProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwProductos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
         }
        private void ConfiguracionDCompra()
        {
            this.DgwCompra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.DgwCompra.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void CargaCmb()
        {
            this.CbxClientes.DataSource = KwikEMart.ListaClientes;
            this.CbxClientes.DisplayMember = "nombre";
            this.CbxEmpleados.DataSource = KwikEMart.ListaEmpleados;
            this.CbxEmpleados.DisplayMember = "nombre";
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            if(this.DgwProductos.SelectedRows.Count >0 && Validaciones.NumMayorACero(this.TxtCantidad.Text))
            {
                int.TryParse(this.TxtCantidad.Text, out int cantidadUnidades);
               productoSeleccionado = (Producto)DgwProductos.CurrentRow.DataBoundItem;
                item = new ItemProducto(productoSeleccionado, cantidadUnidades, productoSeleccionado.precio);
                listaCarrito.Add(item);
                CargaDCompra();
                ConfiguracionDCompra();
              }

        }

        private void CargaDCompra()
        {
            this.DgwCompra.DataSource = null;
            this.DgwCompra.DataSource = listaCarrito;
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
            if(this.DgwCompra.Rows.Count >0)
            {
                 nombreCliente = ((Cliente)CbxClientes.SelectedItem).Nombre;
                nombreEmpleado = ((Empleado)CbxEmpleados.SelectedItem).Nombre;
                precioTotal = CalcularPrecioDescuento(nombreCliente);
                Producto.ActualizarStock(KwikEMart.ListaProductos, productoSeleccionado,cantidadUnidades);
                KwikEMart.AgregarCompra(new Compra(nombreCliente,nombreEmpleado,precioTotal));

                sonidoCaja.Play();
                this.DialogResult = DialogResult.OK;
            }
        }
        private double CalcularPrecioDescuento(string nombre)
        {
            double total;
            double costoTotal;
            if(Validaciones.CheckDescuento(nombre))
            {
                costoTotal = ItemProducto.TotalCostoProductos(listaCarrito);
                total =costoTotal-( costoTotal * 0.13);
            }
            else
                total = ItemProducto.TotalCostoProductos(listaCarrito);

            return total;
        }

    }
}

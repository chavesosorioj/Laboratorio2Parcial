using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Compra
    {
        #region atributos
        string nombreCliente;
        string nombreEmpleado;
        List<ItemProducto> itemProducto;
        double costoTotal;
        #endregion

        #region Propiedades

        public string NombreCliente
        {
            get { return nombreCliente; }
            set { nombreCliente = value; }
        }
        public string NombreEmpleado
        {
            get { return nombreEmpleado; }
            set { nombreEmpleado = value; }
        }
        public List<ItemProducto> ItemProd
        {
            get { return itemProducto; }
        }
        public double CostoTotal
        {
            get { return costoTotal; }
            set { this.costoTotal = value; }
        }
        #endregion

        #region Constructor

        public Compra()
        {
            this.itemProducto = new List<ItemProducto>();
        }

        public Compra(string cliente, string empleado, double costoTotal):this()
        {
            this.nombreCliente = cliente;
            this.nombreEmpleado = empleado;
            this.costoTotal = costoTotal;
        }
        #endregion

        static public bool operator +(List<Compra> listacompra, Compra compra)
        {
            bool ret = false;
            if(compra is Compra)
            {
                listacompra.Add(compra);
                ret = true;
            }

            return ret;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Cliente: {this.nombreCliente}");
            if(Validaciones.ConSinDescuento(this.NombreCliente) == "Con descuento")
            {
                sb.AppendLine($"Cliente con 13% de descuento");
            }
            sb.AppendLine($"Vendedor: {this.nombreEmpleado}");
            sb.AppendLine("----------");

            sb.AppendLine("COMPRA:");
            foreach (var p in this.itemProducto)
            {
                sb.AppendLine($"{p.Producto}\t{p.Cantidad}\t{p.CostoFinal}");
            }

            sb.AppendLine($"El total es ${this.costoTotal}");
            sb.AppendLine("----------");

            return sb.ToString();
        }
      }
}

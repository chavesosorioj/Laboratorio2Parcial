using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ItemProducto
    {
        #region Atributos

        Producto producto;
        int cantidad;
        double costoFinal;
        double precioUnidad;

        #endregion

        #region Propiedad

        public string Producto
        {
            get { return producto.nombreProduc; }
        }

        public int Cantidad
        {
            get { return this.cantidad; }
            set { this.cantidad = value; }
        }

        public double CostoFinal
        {
            get { return this.costoFinal; }
            set { this.costoFinal = value; }
        }

        public double PrecioUnidad
        {
            get { return this.precioUnidad; }
            set { this.precioUnidad = value; }
        }

        #endregion

        #region Constructor
        /// <summary>
        /// constructor de un itemProducto
        /// </summary>
        /// <param name="prod"></param>
        /// <param name="cant"></param>
        /// <param name="costo"></param>
        /// <param name="unidad"></param>
        public ItemProducto(Producto prod, int cant, double unidad)
        {
            this.producto = prod;
            this.cantidad = cant;
            this.costoFinal = unidad * cant;
            this.precioUnidad = unidad; 
        }
        #endregion

        #region Metodo


        #endregion

        public static bool operator +(List<ItemProducto> listaItems, ItemProducto item)
        {
            bool ret = false;
            if(item is ItemProducto)
            {
                listaItems.Add(item);
                ret = true;
            }
            return ret;
        }

        public static double TotalCostoProductos(List<ItemProducto> lista)
        {
            double ret = 0;
            foreach (ItemProducto item in lista)
                ret += item.costoFinal;
            
            return ret;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {

        #region Atributos
        public string nombreProduc;
        public double precio;
        public int stock;
        public ETipoProducto tipo;

        #endregion

        #region Propiedades 
        public string NombreProduc
        {
            get { return nombreProduc; }
           
        }
        public double Precio
        {
            get { return this.precio; }
          
        }

        public int Stock
        {
            get { return stock; }
           
         }

        public ETipoProducto Tipo
        {
            get { return tipo; }
           
        }


        #endregion

        #region Constructor
        public Producto(string nombre, int precio, int stock, ETipoProducto tipo)
        {
            this.nombreProduc = nombre;
            this.precio = precio;
            this.stock = stock;
            this.tipo = tipo;
        }
        #endregion

        #region Metodo

        public static int TotalStock(List<Producto> listaProductos)
        {
            int total = 0;
            foreach (Producto item in listaProductos)
            {
                total += item.stock;
            }
            return total;
        }

        public static List<Producto> MenosDiezProd(List<Producto> listaProductos)
        {
            List<Producto> auxLista = new List<Producto>();

            foreach (Producto item in listaProductos)
            {
                if(item.stock < 10)
                     auxLista.Add(item);
            }

            return auxLista;
         }

        public static bool ActualizarStock(List<Producto> lista, Producto prod, int cantidad)
        {
            bool ret = false;

            foreach (Producto item in lista)
            {
                if(item.nombreProduc == prod.nombreProduc)
                {
                    prod.stock -= cantidad;
                    ret = true;
                }
            }
            return ret;

        }
       public string MostrarProducto() // quizàs esta en to string porque no esta al momento de declarar el metodo
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.nombreProduc.ToString()); 
            sb.AppendLine(this.precio.ToString());
            sb.AppendLine(this.stock.ToString());
            sb.AppendLine(this.tipo.ToString());

            return sb.ToString();
        }
      
        public override string ToString()
        {
            return this.nombreProduc;
        }
        #endregion

        #region Sobrecarga

       static public bool operator +(List<Producto> listaProductos, Producto p)
        {
            bool ret = false;
            if( p is Producto) 
            {
                listaProductos.Add(p);
                ret = true;
            }

            return ret;
        }
        #endregion
    }
}

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
        public EProductos nombreProduc; // List<EProductos> produc     ES UNA LISTA?
        public float precio;
        public int stock; // desde aca o desde el stock?
        public ETipoProducto tipo;
        
        #endregion

        #region Propiedades

        public EProductos NombreProduc //                                   CHEQUEAR SI ES ASI O UNA LISTA
        {
            get { return nombreProduc; }
            set { nombreProduc = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int Stock
        {
            get { return stock; }
            set { stock = value; }
        }

        public ETipoProducto Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


        #endregion

        #region Constructor
        public Producto(EProductos nombre, int precio, int stock, ETipoProducto tipo)
        {
            this.nombreProduc = nombre;
            this.precio = precio;
            this.stock = stock;
            this.tipo = tipo;
        }
        #endregion

        #region Metodo

        public string MostrarProducto() // quizàs esta en to string porque no esta al momento de declarar el metodo
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(this.nombreProduc.ToString()); // ESTO NO CREO QUE SEA ASI
            sb.AppendLine(this.precio.ToString());
            sb.AppendLine(this.stock.ToString());
            sb.AppendLine(this.tipo.ToString());

            return sb.ToString();
        }


        #endregion
    }
}

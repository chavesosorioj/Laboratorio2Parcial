using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static public class KwikEMart
    {
        #region Atributos
        static List<Cliente> listaClientes;
        static List<Empleado> listaEmpleados;
        static List<Producto> listaProductos;
        static List<Compra> listaCompras;
        static Dictionary<string, int> usuarios;
        static int numCompra;
        #endregion

        #region Propiedad

        public static List<Cliente> ListaClientes
        {
            get { return listaClientes; }
        }

        public static List<Empleado> ListaEmpleados
        {
            get { return listaEmpleados; }
        }
        public static List<Producto> ListaProductos
        {
            get { return listaProductos; }
        }

        public static List<Compra> ListaCompras
        {
            get { return listaCompras; }
        }

        public static int NumCompra
        {
            get { return numCompra; }
        }

        public static Dictionary<string, int> Usuarios
        {
            get { return usuarios; }
        }
        #endregion

        #region Constructor

        static KwikEMart()
        {
            listaClientes = new List<Cliente>();
            listaEmpleados = new List<Empleado>();
            listaCompras = new List<Compra>();
            listaProductos = new List<Producto>();
            usuarios = new Dictionary<string, int>();
            numCompra = 0;
        }
        #endregion

        #region Sobrecarga

        static public bool AgregarProducto(Producto producto)
        {
            bool ret = false;
            if (listaProductos + producto)
                ret = true;

            return ret;
        }

        static public bool AgregarCliente(Cliente cliente)
        {
            bool ret = false;
            if (listaClientes + cliente)
                ret = true;

            return ret;
        }

        static public bool AgregarEmpleado(Empleado empleado)
        {
            bool ret = false;
            if (listaEmpleados + empleado)
                ret = true;

            return ret;
        }

        static public bool AgregarCompra(Compra compra)
        {
            bool ret = false;
            if (listaCompras + compra)
                ret = true;

            return ret;
        }


        /*
        static public bool operator ==()
        {
            bool ret = false;

          return ret;
        }
        */

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        #region Atributos
        public string domicilio;
        public string descuento;
        List<Compra> listaCompra;
        #endregion

        #region Propiedades

         public string Descuento 
        {
            get { return descuento; }
            set { descuento = value; }
        }

        #endregion

        #region Constructores
        public Cliente(string nombre, string apellido, int dni,string dom,string desc) : base(nombre, apellido, dni)
        {
            this.domicilio = dom;
             this.descuento = desc;
            listaCompra = new List<Compra>();
        }

        #endregion

        #region Metodo
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine(this.domicilio);

            return sb.ToString();
        }
        #endregion

        #region Sobrecarga operadores

        public static bool operator +(List<Cliente> listaCliente, Cliente cliente) 
        {
            bool ret = false;
           if(cliente is Cliente)
            {
                listaCliente.Add(cliente);
                ret = true;
            }
            return ret;
        }

        public static bool operator ==(List<Cliente> listaClientes, Cliente cliente)
        {
            bool ret= false;
            foreach (Cliente item in listaClientes)
            {
                if (item.dni == cliente.dni)
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }

        public static bool operator !=(List<Cliente> listaClientes, Cliente cliente)
        {
            return !(listaClientes == cliente);
        }

        #endregion
    }
}

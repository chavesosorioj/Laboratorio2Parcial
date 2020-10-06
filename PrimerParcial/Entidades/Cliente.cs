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
        public int contrasenia;
        public string domicilio;
        public string descuento;
        List<Compra> listaCompra;
        #endregion

        #region Propiedades

       public int Constrasenia
        {
            get { return contrasenia;}
            set { contrasenia = value;}
        }

        public string Descuento 
        {
            get { return descuento; }
            set { descuento = value; }
        }

        #endregion

        #region Constructores
        public Cliente(string nombre, string apellido, int dni,string dom, int contr, string desc) : base(nombre, apellido, dni)
        {
            this.domicilio = dom;
           this.contrasenia = contr;
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
    }
}

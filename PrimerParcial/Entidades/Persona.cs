using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona // es la base
    {
        #region Atributos
        protected string nombre;
        protected string apellido;
        protected int dni;
        #endregion

        #region Propiedades
        public string Nombre 
        {
            get { return nombre; }
            set { nombre = value;}
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public int Dni 
        {
            get { return dni; }
            set { dni = value; }
        }
        #endregion 
        #region Constructor
        /// <summary>
        ///Constructor de Persona
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        #endregion

        #region Metodo

        public virtual string Mostrar()
        {
            return (string)this;
        }
        #endregion

        #region Explicit
        public static explicit operator  string(Persona p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(p.nombre);
            sb.AppendLine(p.apellido);
            sb.AppendLine(p.dni.ToString());

            return sb.ToString();
        }
        #endregion

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado: Persona
    {
        
        #region Atributos
        public EPuesto puesto;
        #endregion

        #region Propiedades

        public EPuesto Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        #endregion

        #region Constructor
        /// <summary>
        /// Constructor Empleado
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="idEmpl"></param>
        /// <param name="puesto"></param>
        public Empleado(string nombre, string apellido, int dni, EPuesto puesto):base(nombre,apellido,dni) 
        {
             this.puesto = puesto;
        }
        #endregion

        #region Metodo
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine(this.puesto.ToString()); // CHEQUEAR SI ESTA BIEN. creo que me devuelve el num

            return sb.ToString();
        }
        #endregion
    }
}

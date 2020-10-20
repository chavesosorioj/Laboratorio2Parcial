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
        public int idEmpleado;
        #endregion

        #region Propiedades

        public int Id
        {
            get { return this.idEmpleado; }
            set { this.idEmpleado = value; }
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
        public Empleado(string nombre, string apellido, int dni, int id):base(nombre,apellido,dni) 
        {
            this.idEmpleado = id;
        }
        #endregion

        #region Metodo
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine(this.idEmpleado.ToString());
            return sb.ToString();
        }
        #endregion

        #region Sobrecarga operadores

        public static bool operator +(List<Empleado> listaEmpleados, Empleado empleado)
        {
            bool ret = false;
            if(empleado is Empleado)
            {
                listaEmpleados.Add(empleado);
                ret = true;
            }
            return ret;
        }

        public static bool operator ==(List<Empleado> listaEmpleados, Empleado empleado)
        {
            bool ret = false;
            foreach (Empleado item in listaEmpleados)
            {
                if (item.dni == empleado.dni)
                {
                    ret = true;
                    break;
                }
            }
            return ret;
        }

        public static bool operator !=(List<Empleado> listaEmpleados, Empleado empleado)
        {
            return !(listaEmpleados == empleado);
        }

        #endregion
    }
}

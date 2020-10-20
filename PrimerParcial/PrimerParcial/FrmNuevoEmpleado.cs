using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace PrimerParcial
{
    public partial class FrmNuevoEmpleado : Form
    {
        public FrmNuevoEmpleado()
        {
            InitializeComponent();
        }

        private void FrmNuevoEmpleado_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if(Validaciones.ContieneLetras(this.TxtNombre.Text) && Validaciones.ContieneLetras(this.TxtApellido.Text) && Validaciones.EsNumerico(this.TxtDni.Text) && Validaciones.EsNumerico(this.TbxId.Text))
            {
                int.TryParse(TxtDni.Text, out int auxDni);
                int.TryParse(TbxId.Text, out int auxId);
                KwikEMart.AgregarEmpleado(new Empleado(this.TxtNombre.Text, this.TxtApellido.Text, auxDni, auxId));
            }
            else
            {
                MessageBox.Show("Error en los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.DialogResult = DialogResult.OK;
        }

     }
}

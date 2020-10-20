using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimerParcial
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmInicioCliente_Load(object sender, EventArgs e)
        {
            this.Text = "Bienvenido!";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtBUsuario.Text == lblAdmin1.Text && txtBContraseña.Text == lblAdmin2.Text)
            {
                this.Hide();
                FormBienvenida frmBienvenida = new FormBienvenida();
                frmBienvenida.ShowDialog();
                if (!(frmBienvenida.DialogResult == DialogResult.OK))
                {
                    this.Close();
                }

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña incorrectos", "Datos invalidos", MessageBoxButtons.OK);
                txtBUsuario.Text = String.Empty;
                txtBContraseña.Text = String.Empty;
            }
        }
    }


    }


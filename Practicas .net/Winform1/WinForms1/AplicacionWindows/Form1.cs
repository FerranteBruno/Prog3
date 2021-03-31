using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if(txtApellido.Text == "")
            {
                txtApellido.BackColor = Color.Red;
                txtApellido.ForeColor = Color.White;
                txtApellido.Text = "Ingrese su apellido";
            }
            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
                txtNombre.ForeColor = Color.White;
                txtNombre.Text = "Ingrese su Nombre";
            }
            if (txtEdad.Text == "")
            {
                txtEdad.BackColor = Color.Red;
                txtEdad.ForeColor = Color.White;
                txtEdad.Text = "Ingrese su Edad";
            }
            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
                txtDireccion.ForeColor = Color.White;
                txtDireccion.Text = "Ingrese su Dirección";
            }

            if(txtApellido.Text == "Ingrese su apellido" || txtNombre.Text == "Ingrese su Nombre" ||
                txtEdad.Text == "Ingrese su Edad" || txtDireccion.Text == "Ingrese su Dirección")
            {
                txtResultado.BackColor = Color.Red;
                txtResultado.ForeColor = Color.White;
                txtResultado.Text = "No se pudo validar el ingreso de datos";
            }
            else
            {
                txtApellido.BackColor = Color.White;
                txtApellido.ForeColor = Color.Black;

                txtNombre.BackColor = Color.White;
                txtNombre.ForeColor = Color.Black;

                txtEdad.BackColor = Color.White;
                txtEdad.ForeColor = Color.Black;

                txtDireccion.BackColor = Color.White;
                txtDireccion.ForeColor = Color.Black;

                txtResultado.BackColor = Color.White;
                txtResultado.ForeColor = Color.Black;

                txtResultado.Text = "Apellido y nombre: " + txtApellido.Text + "\r\n"
                    + "Edad: " + txtEdad.Text + "\r\n"
                    + "Dirección: " + txtEdad.Text + "\r\n";
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
    }
}

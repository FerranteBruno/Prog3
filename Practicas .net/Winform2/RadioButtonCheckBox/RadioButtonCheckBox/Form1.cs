using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButtonCheckBox
{
    public partial class frmRadioButtonCheckBox : Form
    {
        private void ValidarOK()
        {
            btnOK.Enabled = (txtNombre.BackColor != Color.Red);
        }
        public frmRadioButtonCheckBox()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmRadioButtonCheckBox_Load(object sender, EventArgs e)
        {
            //Deshabilito botoncin
            btnOK.Enabled = false;
        }

        private void txtNombre_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if(tb.TextLength == 0)
            {
                tb.BackColor = Color.Red;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;

            }
            ValidarOK();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            String salida;

            salida = "Nombre: " + txtNombre.Text + "\r\n";
            salida += "ocupación: " + (string)(chkbProgramador.Checked ?
            "Programador " : "No es programador") + "\r\n";

            salida += "Sexo: " + (string)(rbFemenino.Checked ? "Mujer" : "Hombre") + "\r\n";

            txtSalida.Text = salida;
        }
    }
}

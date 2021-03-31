using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlTextbox
{
    public partial class frmForm : Form
    {
        public frmForm()
        {
            InitializeComponent();
        }

        private void frmForm_Load(object sender, EventArgs e)
        {
        }
        private void txtbCajaDeTesto_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnElBoton_Click(object sender, EventArgs e)
        {
            if (txtbCajaDeTesto.Text == "") txtbCajaDeTesto.BackColor = Color.Red;
            else txtbCajaDeTesto.BackColor = System.Drawing.SystemColors.Control;
        }

        private void txtbCajaDeTesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar <48 || e.KeyChar > 59) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void txtCajaNombre_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene" + txtCajaNombre.Text.Length + "Caracteres");
        }
    }
}
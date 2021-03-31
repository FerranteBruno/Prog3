using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class FormUno : Form
    {
        public FormUno()
        {
            InitializeComponent();
        }

        private void FormUno_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void FormUno_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Cerrando...");
        }
    }
}

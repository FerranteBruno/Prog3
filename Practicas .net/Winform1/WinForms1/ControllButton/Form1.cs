using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControllButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MouseEventArgs click = (MouseEventArgs)e;

            if (click.Button == MouseButtons.Left) MessageBox.Show("Se Clickeo el izq");
            else if (click.Button == MouseButtons.Right) MessageBox.Show("Se Clickeo el izq");
            else if (click.Button == MouseButtons.Middle) MessageBox.Show("Se Clickeo el izq");

            //MessageBox.Show("Se Clickeo!", "ojota");
            //this.BackColor = Color.Blue;

        }
    }
}

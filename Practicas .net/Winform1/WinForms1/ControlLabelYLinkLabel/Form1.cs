using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlLabelYLinkLabel
{
    public partial class frmElForm : Form
    {
        public frmElForm()
        {
            InitializeComponent();
        }

        private void frmElForm_Load(object sender, EventArgs e)
        {

        }

        private void lbElLabel_MouseMove(object sender, MouseEventArgs e)
        {
            lbElLabel.BackColor = Color.DarkCyan;
            lbElLabel.Cursor = Cursors.Hand;
        }

        private void lbElLabel_MouseLeave(object sender, EventArgs e)
        {
            lbElLabel.BackColor = System.Drawing.SystemColors.Control;
            lbElLabel.Cursor = Cursors.Arrow;
        }
    }
}

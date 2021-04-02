using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxYChekedListBox
{
    public partial class frmListBoxYCheckedListBox : Form
    {
        public frmListBoxYCheckedListBox()
        {
            InitializeComponent();

            clbCheck.Items.Add("Diez");
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMover_Click(object sender, EventArgs e)
        {
            if(clbCheck.CheckedItems.Count > 0)
            {
                lboxTextBox.Items.Clear();



                foreach(string item in clbCheck.CheckedItems)
                {
                    lboxTextBox.Items.Add(item.ToString());
                }

                for(int i=0;i<clbCheck.Items.Count; i++)
                {
                    clbCheck.SetItemChecked(i, false);
                }
            }
        }
    }
}

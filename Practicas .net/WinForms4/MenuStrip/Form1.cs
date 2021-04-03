using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MenuStrip
{
    public partial class frmMenuStrip : Form
    {
        public frmMenuStrip()
        {
            InitializeComponent();
            toolStripComboBox.SelectedIndex = 0;
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripNew_Click(object sender, EventArgs e)
        {
            rtbText.Text = "";
        }

        private void toolStripShowHelp_CheckedChanged(object sender, EventArgs e)
        {
            ToolStripMenuItem Item = (ToolStripMenuItem)sender;
            toolStripHelp.Visible = Item.Checked;
        }

        private void toolStripOpen_Click(object sender, EventArgs e)
        {
            try
            {
                rtbText.LoadFile(@"Example.rtf");
            }
            catch
            {
            }
        }

        private void toolStripSave_Click(object sender, EventArgs e)
        {
            try
            {
                rtbText.SaveFile(@"Example.rtf");
            }
            catch
            {

            }
        }

        private void rtbText_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripBold_CheckedChanged(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            bool checkState = ((ToolStripButton)sender).Checked;

            oldFont = this.rtbText.SelectionFont;

            if (!checkState)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);

            rtbText.SelectionFont = newFont;
            rtbText.Focus();
            toolStripBold.CheckedChanged -= new
                EventHandler(toolStripBold_CheckedChanged);
            toolStripBold.Checked = checkState;
            toolStripBold.CheckedChanged += new
                EventHandler(toolStripBold_CheckedChanged);
        }


        private void toolStripItalic_CheckedChanged(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            bool checkState = ((ToolStripButton)sender).Checked;

            oldFont = this.rtbText.SelectionFont;

            if (!checkState)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);

            rtbText.SelectionFont = newFont;
            rtbText.Focus();
            toolStripItalic.CheckedChanged -= new
                EventHandler(toolStripItalic_CheckedChanged);
            toolStripItalic.Checked = checkState;
            toolStripItalic.CheckedChanged += new
                EventHandler(toolStripItalic_CheckedChanged);

        }

        private void toolStripUnderline_CheckedChanged(object sender, EventArgs e)
        {
            Font oldFont, newFont;

            bool checkState = ((ToolStripButton)sender).Checked;

            oldFont = this.rtbText.SelectionFont;

            if (!checkState)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);

            rtbText.SelectionFont = newFont;
            rtbText.Focus();
            toolStripItalic.CheckedChanged -= new
                EventHandler(toolStripUnderline_CheckedChanged);
            toolStripUnderline.Checked = checkState;
            toolStripUnderline.CheckedChanged += new
                EventHandler(toolStripUnderline_CheckedChanged);
        }

        private void toolStripExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = ((ToolStripComboBox)sender).SelectedItem.ToString();
            Font newFont = null;
            if (rtbText.SelectionFont == null)
                newFont = new Font(text, rtbText.Font.Size);
            else
                newFont = new Font(text, rtbText.SelectionFont.Size,
                rtbText.SelectionFont.Style);
            rtbText.SelectionFont = newFont;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ListView
{
    public partial class ListView : Form
    {
        private System.Collections.Specialized.StringCollection carpetaCol;

        public ListView()
        {
            InitializeComponent();
            carpetaCol = new System.Collections.Specialized.StringCollection();
            CrearCabeceraYLlenarListView();
            DibujarListView(@"C:\");
            carpetaCol.Add(@"C:\");
        }

        private void ListView_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CrearCabeceraYLlenarListView()
        {
            ColumnHeader colCab;

            colCab = new ColumnHeader();
            colCab.Text = "Nombre de Archivo";
            lvEditor.Columns.Add(colCab);
            colCab = new ColumnHeader();
            colCab.Text = "Tamaño";
            lvEditor.Columns.Add(colCab);
            colCab = new ColumnHeader();
            colCab.Text = "Ultima Modificación";
            lvEditor.Columns.Add(colCab);
        }

        private void DibujarListView(string root)
        {
            try
            {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;
                if (string.IsNullOrEmpty(root)) return;

                DirectoryInfo dir = new DirectoryInfo(root);
                DirectoryInfo[] dirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();
                lvEditor.Items.Clear();
                lblDirectorioActual.Text = root;
                lvEditor.BeginUpdate();
                foreach(DirectoryInfo di in dirs)
                {
                    lvi = new ListViewItem();
                    lvi.Text = di.Name;
                    lvi.ImageIndex = 0;
                    lvi.Tag = di.FullName;
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = "";
                    lvi.SubItems.Add(lvsi);
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = di.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);
                    lvEditor.Items.Add(lvi);
                }
                foreach(FileInfo fi in files)
                {
                    lvi = new ListViewItem();
                    lvi.Text = fi.Name;
                    lvi.ImageIndex = 1;
                    lvi.Tag = fi.FullName;
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.Length.ToString();
                    lvi.SubItems.Add(lvsi);
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);
                    lvEditor.Items.Add(lvi);
                }
                lvEditor.EndUpdate();
            }
            catch(System.Exception err)
            {
                MessageBox.Show("Error: " + err);
            }
        }
        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            if (carpetaCol.Count > 1)
            {
                DibujarListView(carpetaCol[carpetaCol.Count - 2].ToString());
                carpetaCol.RemoveAt(carpetaCol.Count - 1);
            }
            else DibujarListView(carpetaCol[0].ToString());
        }

        private void lvEditor_ItemActivate(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView lw = (System.Windows.Forms.ListView)sender;
            string filename = lw.SelectedItems[0].Tag.ToString();
            if (lw.SelectedItems[0].ImageIndex != 0)
            {
                try
                {
                    System.Diagnostics.Process.Start(filename);
                }
                catch
                {
                    return;
                }
            }
            else
            {
                DibujarListView(filename);
                carpetaCol.Add(filename);
            }
        }

        private void rdbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.lvEditor.View = View.LargeIcon;
        }

        private void rdbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.lvEditor.View = View.SmallIcon;
        }

        private void rdbLista_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.lvEditor.View = View.List;
        }

        private void rdbDetalle_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.lvEditor.View = View.Details;
        }

        private void rdbTitulo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
                this.lvEditor.View = View.Tile;
        }
    }
}

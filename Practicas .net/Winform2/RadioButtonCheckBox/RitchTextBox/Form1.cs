using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RitchTextBox
{
    public partial class frmRichTextBox : Form
    {
        public frmRichTextBox()
        {
            InitializeComponent();
        }

        private void btnNegrita_Click(object sender, EventArgs e)
        {
            Font viejaFuente;
            Font nuevaFuente;

            viejaFuente = rtxtContenido.SelectionFont;

            if (viejaFuente.Bold)
            {
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style & ~FontStyle.Bold);
            }
            else
            {
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style | FontStyle.Bold);
            }

            rtxtContenido.SelectionFont = nuevaFuente;

            rtxtContenido.Focus();
        }

        private void btnSubrayado_Click(object sender, EventArgs e)
        {
            Font viejaFuente;
            Font nuevaFuente;


            viejaFuente = rtxtContenido.SelectionFont;


            if (viejaFuente.Underline)
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style & ~FontStyle.Underline);
            else
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style | FontStyle.Underline);


            rtxtContenido.SelectionFont = nuevaFuente;

            rtxtContenido.Focus();
        }

        private void btnCursiva_Click(object sender, EventArgs e)
        {
            Font viejaFuente;
            Font nuevaFuente;

            viejaFuente = rtxtContenido.SelectionFont;

            if (viejaFuente.Italic)
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style & ~FontStyle.Italic);
            else
                nuevaFuente = new Font(viejaFuente, viejaFuente.Style | FontStyle.Italic);


            rtxtContenido.SelectionFont = nuevaFuente;

            rtxtContenido.Focus();
        }

        private void btnCentrado_Click(object sender, EventArgs e)
        {
            if (rtxtContenido.SelectionAlignment == HorizontalAlignment.Center)
                rtxtContenido.SelectionAlignment = HorizontalAlignment.Left;
            else
                rtxtContenido.SelectionAlignment = HorizontalAlignment.Center;

            rtxtContenido.Focus();
        }

        private void AplicarTamañoaTexto(string textsize)
        {
            float nuevoTam = Convert.ToSingle(textsize);

            FontFamily actualFuenteFamily;

            Font nuevaFuente;


            actualFuenteFamily = rtxtContenido.SelectionFont.FontFamily;



            nuevaFuente = new Font(actualFuenteFamily, nuevoTam);


            rtxtContenido.SelectionFont = nuevaFuente;

        }

        private void txtTamaño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 & e.KeyChar > 59) && e.KeyChar != 8) e.Handled = true;


            else if(e.KeyChar == 13)
            {
                if(txtTamaño.Text.Length > 0)
                    AplicarTamañoaTexto(txtTamaño.Text);

                e.Handled = true;

                rtxtContenido.Focus();
            }


        }

        private void txtTamaño_Validated(object sender, EventArgs e)
        {
            AplicarTamañoaTexto(((TextBox)sender).Text);
            rtxtContenido.Focus();
        }

        private void rtxtContenido_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            try
            {
                rtxtContenido.LoadFile("text.rtf");
            }
            catch(System.IO.FileNotFoundException)
            {
                MessageBox.Show("No se encuentra el archivo");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                rtxtContenido.SaveFile("text.rtf");
            }
            catch (System.Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}

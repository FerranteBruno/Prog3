
namespace ControlTextbox
{
    partial class frmForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForm));
            this.txtbCajaDeTesto = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnElBoton = new System.Windows.Forms.Button();
            this.txtCajaNombre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtbCajaDeTesto
            // 
            this.txtbCajaDeTesto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtbCajaDeTesto.Location = new System.Drawing.Point(183, 143);
            this.txtbCajaDeTesto.MaxLength = 35;
            this.txtbCajaDeTesto.Name = "txtbCajaDeTesto";
            this.txtbCajaDeTesto.Size = new System.Drawing.Size(100, 23);
            this.txtbCajaDeTesto.TabIndex = 0;
            this.txtbCajaDeTesto.TextChanged += new System.EventHandler(this.txtbCajaDeTesto_TextChanged);
            this.txtbCajaDeTesto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbCajaDeTesto_KeyPress);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btnElBoton
            // 
            this.btnElBoton.Location = new System.Drawing.Point(195, 172);
            this.btnElBoton.Name = "btnElBoton";
            this.btnElBoton.Size = new System.Drawing.Size(75, 23);
            this.btnElBoton.TabIndex = 2;
            this.btnElBoton.Text = "Clika";
            this.btnElBoton.UseVisualStyleBackColor = true;
            this.btnElBoton.Click += new System.EventHandler(this.btnElBoton_Click);
            // 
            // txtCajaNombre
            // 
            this.txtCajaNombre.Location = new System.Drawing.Point(183, 105);
            this.txtCajaNombre.Multiline = true;
            this.txtCajaNombre.Name = "txtCajaNombre";
            this.txtCajaNombre.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCajaNombre.Size = new System.Drawing.Size(100, 23);
            this.txtCajaNombre.TabIndex = 3;
            this.txtCajaNombre.Leave += new System.EventHandler(this.txtCajaNombre_Leave);
            // 
            // frmForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.txtCajaNombre);
            this.Controls.Add(this.btnElBoton);
            this.Controls.Add(this.txtbCajaDeTesto);
            this.Name = "frmForm";
            this.Load += new System.EventHandler(this.frmForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbCajaDeTesto;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btnElBoton;
        private System.Windows.Forms.TextBox txtCajaNombre;
    }
}


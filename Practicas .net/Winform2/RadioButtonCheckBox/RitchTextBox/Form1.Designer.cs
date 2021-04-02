
namespace RitchTextBox
{
    partial class frmRichTextBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRichTextBox));
            this.btnNegrita = new System.Windows.Forms.Button();
            this.btnSubrayado = new System.Windows.Forms.Button();
            this.btnCursiva = new System.Windows.Forms.Button();
            this.btnCentrado = new System.Windows.Forms.Button();
            this.lblTamaño = new System.Windows.Forms.Label();
            this.txtTamaño = new System.Windows.Forms.TextBox();
            this.rtxtContenido = new System.Windows.Forms.RichTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNegrita
            // 
            this.btnNegrita.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNegrita.BackColor = System.Drawing.Color.Transparent;
            this.btnNegrita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNegrita.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNegrita.Location = new System.Drawing.Point(120, 116);
            this.btnNegrita.Name = "btnNegrita";
            this.btnNegrita.Size = new System.Drawing.Size(75, 23);
            this.btnNegrita.TabIndex = 0;
            this.btnNegrita.Text = "Negrita";
            this.btnNegrita.UseVisualStyleBackColor = false;
            this.btnNegrita.Click += new System.EventHandler(this.btnNegrita_Click);
            // 
            // btnSubrayado
            // 
            this.btnSubrayado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSubrayado.BackColor = System.Drawing.Color.Transparent;
            this.btnSubrayado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubrayado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSubrayado.Location = new System.Drawing.Point(440, 117);
            this.btnSubrayado.Name = "btnSubrayado";
            this.btnSubrayado.Size = new System.Drawing.Size(75, 23);
            this.btnSubrayado.TabIndex = 1;
            this.btnSubrayado.Text = "Subrayado";
            this.btnSubrayado.UseVisualStyleBackColor = false;
            this.btnSubrayado.Click += new System.EventHandler(this.btnSubrayado_Click);
            // 
            // btnCursiva
            // 
            this.btnCursiva.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCursiva.BackColor = System.Drawing.Color.Transparent;
            this.btnCursiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCursiva.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCursiva.Location = new System.Drawing.Point(700, 116);
            this.btnCursiva.Name = "btnCursiva";
            this.btnCursiva.Size = new System.Drawing.Size(75, 23);
            this.btnCursiva.TabIndex = 2;
            this.btnCursiva.Text = "Cursiva";
            this.btnCursiva.UseVisualStyleBackColor = false;
            this.btnCursiva.Click += new System.EventHandler(this.btnCursiva_Click);
            // 
            // btnCentrado
            // 
            this.btnCentrado.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCentrado.BackColor = System.Drawing.Color.Transparent;
            this.btnCentrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCentrado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCentrado.Location = new System.Drawing.Point(1011, 116);
            this.btnCentrado.Name = "btnCentrado";
            this.btnCentrado.Size = new System.Drawing.Size(75, 23);
            this.btnCentrado.TabIndex = 3;
            this.btnCentrado.Text = "Centrado";
            this.btnCentrado.UseVisualStyleBackColor = false;
            this.btnCentrado.Click += new System.EventHandler(this.btnCentrado_Click);
            // 
            // lblTamaño
            // 
            this.lblTamaño.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTamaño.AutoSize = true;
            this.lblTamaño.BackColor = System.Drawing.Color.Transparent;
            this.lblTamaño.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTamaño.ForeColor = System.Drawing.Color.White;
            this.lblTamaño.Location = new System.Drawing.Point(525, 233);
            this.lblTamaño.Name = "lblTamaño";
            this.lblTamaño.Size = new System.Drawing.Size(49, 15);
            this.lblTamaño.TabIndex = 4;
            this.lblTamaño.Text = "Tamaño";
            // 
            // txtTamaño
            // 
            this.txtTamaño.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTamaño.Location = new System.Drawing.Point(584, 230);
            this.txtTamaño.Name = "txtTamaño";
            this.txtTamaño.Size = new System.Drawing.Size(100, 23);
            this.txtTamaño.TabIndex = 5;
            this.txtTamaño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTamaño_KeyPress);
            this.txtTamaño.Validated += new System.EventHandler(this.txtTamaño_Validated);
            // 
            // rtxtContenido
            // 
            this.rtxtContenido.Location = new System.Drawing.Point(12, 310);
            this.rtxtContenido.MinimumSize = new System.Drawing.Size(1000, 50);
            this.rtxtContenido.Name = "rtxtContenido";
            this.rtxtContenido.Size = new System.Drawing.Size(1160, 266);
            this.rtxtContenido.TabIndex = 6;
            this.rtxtContenido.Text = "";
            this.rtxtContenido.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.rtxtContenido_LinkClicked);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.BackColor = System.Drawing.Color.Transparent;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(440, 590);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnAbrir.BackColor = System.Drawing.Color.Transparent;
            this.btnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbrir.ForeColor = System.Drawing.Color.White;
            this.btnAbrir.Location = new System.Drawing.Point(700, 590);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(75, 23);
            this.btnAbrir.TabIndex = 8;
            this.btnAbrir.Text = "Abrir";
            this.btnAbrir.UseVisualStyleBackColor = false;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // frmRichTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.rtxtContenido);
            this.Controls.Add(this.txtTamaño);
            this.Controls.Add(this.lblTamaño);
            this.Controls.Add(this.btnCentrado);
            this.Controls.Add(this.btnCursiva);
            this.Controls.Add(this.btnSubrayado);
            this.Controls.Add(this.btnNegrita);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRichTextBox";
            this.Text = "RichTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNegrita;
        private System.Windows.Forms.Button btnSubrayado;
        private System.Windows.Forms.Button btnCursiva;
        private System.Windows.Forms.Button btnCentrado;
        private System.Windows.Forms.Label lblTamaño;
        private System.Windows.Forms.TextBox txtTamaño;
        private System.Windows.Forms.RichTextBox rtxtContenido;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAbrir;
    }
}


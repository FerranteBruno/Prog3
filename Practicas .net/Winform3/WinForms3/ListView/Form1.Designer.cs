
namespace ListView
{
    partial class ListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListView));
            this.lblDirectorioActual = new System.Windows.Forms.Label();
            this.lvEditor = new System.Windows.Forms.ListView();
            this.ilLarge = new System.Windows.Forms.ImageList(this.components);
            this.ilSmall = new System.Windows.Forms.ImageList(this.components);
            this.grbModeloDeVista = new System.Windows.Forms.GroupBox();
            this.rdbTitulo = new System.Windows.Forms.RadioButton();
            this.rdbDetalle = new System.Windows.Forms.RadioButton();
            this.rdbLista = new System.Windows.Forms.RadioButton();
            this.rdbSmallIcon = new System.Windows.Forms.RadioButton();
            this.rdbLargeIcon = new System.Windows.Forms.RadioButton();
            this.btnAtras = new System.Windows.Forms.Button();
            this.grbModeloDeVista.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDirectorioActual
            // 
            this.lblDirectorioActual.BackColor = System.Drawing.Color.Transparent;
            this.lblDirectorioActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDirectorioActual.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDirectorioActual.Location = new System.Drawing.Point(12, 9);
            this.lblDirectorioActual.Name = "lblDirectorioActual";
            this.lblDirectorioActual.Size = new System.Drawing.Size(954, 23);
            this.lblDirectorioActual.TabIndex = 0;
            // 
            // lvEditor
            // 
            this.lvEditor.HideSelection = false;
            this.lvEditor.LargeImageList = this.ilLarge;
            this.lvEditor.Location = new System.Drawing.Point(12, 27);
            this.lvEditor.Name = "lvEditor";
            this.lvEditor.Size = new System.Drawing.Size(953, 538);
            this.lvEditor.SmallImageList = this.ilSmall;
            this.lvEditor.TabIndex = 1;
            this.lvEditor.UseCompatibleStateImageBehavior = false;
            this.lvEditor.ItemActivate += new System.EventHandler(this.lvEditor_ItemActivate);
            this.lvEditor.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // ilLarge
            // 
            this.ilLarge.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilLarge.ImageStream")));
            this.ilLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.ilLarge.Images.SetKeyName(0, "cyan logo 32.ico");
            this.ilLarge.Images.SetKeyName(1, "iconazo.png");
            this.ilLarge.Images.SetKeyName(2, "rota games portada.jpg");
            // 
            // ilSmall
            // 
            this.ilSmall.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ilSmall.ImageSize = new System.Drawing.Size(16, 16);
            this.ilSmall.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // grbModeloDeVista
            // 
            this.grbModeloDeVista.BackColor = System.Drawing.Color.Transparent;
            this.grbModeloDeVista.Controls.Add(this.rdbTitulo);
            this.grbModeloDeVista.Controls.Add(this.rdbDetalle);
            this.grbModeloDeVista.Controls.Add(this.rdbLista);
            this.grbModeloDeVista.Controls.Add(this.rdbSmallIcon);
            this.grbModeloDeVista.Controls.Add(this.rdbLargeIcon);
            this.grbModeloDeVista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbModeloDeVista.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.grbModeloDeVista.Location = new System.Drawing.Point(972, 27);
            this.grbModeloDeVista.Name = "grbModeloDeVista";
            this.grbModeloDeVista.Size = new System.Drawing.Size(200, 538);
            this.grbModeloDeVista.TabIndex = 2;
            this.grbModeloDeVista.TabStop = false;
            this.grbModeloDeVista.Text = "Modelo de Vista";
            // 
            // rdbTitulo
            // 
            this.rdbTitulo.AutoSize = true;
            this.rdbTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbTitulo.Location = new System.Drawing.Point(32, 490);
            this.rdbTitulo.Name = "rdbTitulo";
            this.rdbTitulo.Size = new System.Drawing.Size(54, 19);
            this.rdbTitulo.TabIndex = 4;
            this.rdbTitulo.Text = "Titulo";
            this.rdbTitulo.UseVisualStyleBackColor = true;
            this.rdbTitulo.CheckedChanged += new System.EventHandler(this.rdbTitulo_CheckedChanged);
            // 
            // rdbDetalle
            // 
            this.rdbDetalle.AutoSize = true;
            this.rdbDetalle.Checked = true;
            this.rdbDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbDetalle.Location = new System.Drawing.Point(32, 366);
            this.rdbDetalle.Name = "rdbDetalle";
            this.rdbDetalle.Size = new System.Drawing.Size(60, 19);
            this.rdbDetalle.TabIndex = 3;
            this.rdbDetalle.TabStop = true;
            this.rdbDetalle.Text = "Detalle";
            this.rdbDetalle.UseVisualStyleBackColor = true;
            this.rdbDetalle.CheckedChanged += new System.EventHandler(this.rdbDetalle_CheckedChanged);
            // 
            // rdbLista
            // 
            this.rdbLista.AutoSize = true;
            this.rdbLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbLista.Location = new System.Drawing.Point(32, 250);
            this.rdbLista.Name = "rdbLista";
            this.rdbLista.Size = new System.Drawing.Size(48, 19);
            this.rdbLista.TabIndex = 2;
            this.rdbLista.Text = "Lista";
            this.rdbLista.UseVisualStyleBackColor = true;
            this.rdbLista.CheckedChanged += new System.EventHandler(this.rdbLista_CheckedChanged);
            // 
            // rdbSmallIcon
            // 
            this.rdbSmallIcon.AutoSize = true;
            this.rdbSmallIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbSmallIcon.Location = new System.Drawing.Point(32, 139);
            this.rdbSmallIcon.Name = "rdbSmallIcon";
            this.rdbSmallIcon.Size = new System.Drawing.Size(79, 19);
            this.rdbSmallIcon.TabIndex = 1;
            this.rdbSmallIcon.Text = "Small Icon";
            this.rdbSmallIcon.UseVisualStyleBackColor = true;
            this.rdbSmallIcon.CheckedChanged += new System.EventHandler(this.rdbSmallIcon_CheckedChanged);
            // 
            // rdbLargeIcon
            // 
            this.rdbLargeIcon.AutoSize = true;
            this.rdbLargeIcon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbLargeIcon.Location = new System.Drawing.Point(32, 32);
            this.rdbLargeIcon.Name = "rdbLargeIcon";
            this.rdbLargeIcon.Size = new System.Drawing.Size(79, 19);
            this.rdbLargeIcon.TabIndex = 0;
            this.rdbLargeIcon.Text = "Large Icon";
            this.rdbLargeIcon.UseVisualStyleBackColor = true;
            this.rdbLargeIcon.CheckedChanged += new System.EventHandler(this.rdbLargeIcon_CheckedChanged);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAtras.Location = new System.Drawing.Point(470, 588);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 23);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atras";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click_1);
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.grbModeloDeVista);
            this.Controls.Add(this.lvEditor);
            this.Controls.Add(this.lblDirectorioActual);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListView";
            this.Text = "View List";
            this.Load += new System.EventHandler(this.ListView_Load);
            this.grbModeloDeVista.ResumeLayout(false);
            this.grbModeloDeVista.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDirectorioActual;
        private System.Windows.Forms.ListView lvEditor;
        private System.Windows.Forms.GroupBox grbModeloDeVista;
        private System.Windows.Forms.RadioButton rdbTitulo;
        private System.Windows.Forms.RadioButton rdbDetalle;
        private System.Windows.Forms.RadioButton rdbLista;
        private System.Windows.Forms.RadioButton rdbSmallIcon;
        private System.Windows.Forms.RadioButton rdbLargeIcon;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ImageList ilLarge;
        private System.Windows.Forms.ImageList ilSmall;
    }
}


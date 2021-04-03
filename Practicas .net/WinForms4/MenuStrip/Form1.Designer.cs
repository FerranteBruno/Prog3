
namespace MenuStrip
{
    partial class frmMenuStrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuStrip));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripNew = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripPrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripShowHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContents = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripIndex = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.rtbText = new System.Windows.Forms.RichTextBox();
            this.toolStripFont = new System.Windows.Forms.ToolStrip();
            this.toolStripBold = new System.Windows.Forms.ToolStripButton();
            this.toolStripItalic = new System.Windows.Forms.ToolStripButton();
            this.toolStripUnderline = new System.Windows.Forms.ToolStripButton();
            this.toolStripAcciones = new System.Windows.Forms.ToolStrip();
            this.toolStripCortar = new System.Windows.Forms.ToolStripButton();
            this.toolStripCopiar = new System.Windows.Forms.ToolStripButton();
            this.toolStripPegar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1.SuspendLayout();
            this.toolStripFont.SuspendLayout();
            this.toolStripAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripFile,
            this.toolStripFormat,
            this.toolStripHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // toolStripFile
            // 
            this.toolStripFile.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNew,
            this.toolStripOpen,
            this.toolStripSeparator1,
            this.toolStripSave,
            this.toolStripSaveAs,
            this.toolStripSeparator2,
            this.toolStripPrint,
            this.toolStripPrintPreview,
            this.toolStripSeparator3,
            this.toolStripExit});
            this.toolStripFile.Image = ((System.Drawing.Image)(resources.GetObject("toolStripFile.Image")));
            this.toolStripFile.Name = "toolStripFile";
            this.toolStripFile.Size = new System.Drawing.Size(53, 20);
            this.toolStripFile.Text = "File";
            // 
            // toolStripNew
            // 
            this.toolStripNew.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripNew.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNew.Image")));
            this.toolStripNew.Name = "toolStripNew";
            this.toolStripNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.toolStripNew.Size = new System.Drawing.Size(156, 22);
            this.toolStripNew.Text = "&New";
            this.toolStripNew.Click += new System.EventHandler(this.toolStripNew_Click);
            // 
            // toolStripOpen
            // 
            this.toolStripOpen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripOpen.Image")));
            this.toolStripOpen.Name = "toolStripOpen";
            this.toolStripOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.toolStripOpen.Size = new System.Drawing.Size(156, 22);
            this.toolStripOpen.Text = "&Open";
            this.toolStripOpen.Click += new System.EventHandler(this.toolStripOpen_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // toolStripSave
            // 
            this.toolStripSave.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripSave.Image = ((System.Drawing.Image)(resources.GetObject("toolStripSave.Image")));
            this.toolStripSave.Name = "toolStripSave";
            this.toolStripSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripSave.Size = new System.Drawing.Size(156, 22);
            this.toolStripSave.Text = "&Save";
            this.toolStripSave.Click += new System.EventHandler(this.toolStripSave_Click);
            // 
            // toolStripSaveAs
            // 
            this.toolStripSaveAs.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripSaveAs.Name = "toolStripSaveAs";
            this.toolStripSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.toolStripSaveAs.Size = new System.Drawing.Size(156, 22);
            this.toolStripSaveAs.Text = "Save &As";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(153, 6);
            // 
            // toolStripPrint
            // 
            this.toolStripPrint.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripPrint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPrint.Image")));
            this.toolStripPrint.Name = "toolStripPrint";
            this.toolStripPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.toolStripPrint.Size = new System.Drawing.Size(156, 22);
            this.toolStripPrint.Text = "&Print";
            // 
            // toolStripPrintPreview
            // 
            this.toolStripPrintPreview.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripPrintPreview.Name = "toolStripPrintPreview";
            this.toolStripPrintPreview.Size = new System.Drawing.Size(156, 22);
            this.toolStripPrintPreview.Text = "Print Preview";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripSeparator3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(153, 6);
            // 
            // toolStripExit
            // 
            this.toolStripExit.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripExit.Image = ((System.Drawing.Image)(resources.GetObject("toolStripExit.Image")));
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.toolStripExit.Size = new System.Drawing.Size(156, 22);
            this.toolStripExit.Text = "&Exit";
            this.toolStripExit.Click += new System.EventHandler(this.toolStripExit_Click);
            // 
            // toolStripFormat
            // 
            this.toolStripFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripShowHelp});
            this.toolStripFormat.Name = "toolStripFormat";
            this.toolStripFormat.Size = new System.Drawing.Size(57, 20);
            this.toolStripFormat.Text = "Format";
            // 
            // toolStripShowHelp
            // 
            this.toolStripShowHelp.Checked = true;
            this.toolStripShowHelp.CheckOnClick = true;
            this.toolStripShowHelp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripShowHelp.Name = "toolStripShowHelp";
            this.toolStripShowHelp.Size = new System.Drawing.Size(131, 22);
            this.toolStripShowHelp.Text = "Show Help";
            this.toolStripShowHelp.CheckedChanged += new System.EventHandler(this.toolStripShowHelp_CheckedChanged);
            // 
            // toolStripHelp
            // 
            this.toolStripHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripContents,
            this.toolStripSearch,
            this.toolStripIndex,
            this.toolStripSeparator4,
            this.toolStripAbout});
            this.toolStripHelp.Image = ((System.Drawing.Image)(resources.GetObject("toolStripHelp.Image")));
            this.toolStripHelp.Name = "toolStripHelp";
            this.toolStripHelp.Size = new System.Drawing.Size(60, 20);
            this.toolStripHelp.Text = "Help";
            // 
            // toolStripContents
            // 
            this.toolStripContents.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripContents.Name = "toolStripContents";
            this.toolStripContents.Size = new System.Drawing.Size(122, 22);
            this.toolStripContents.Text = "Contents";
            // 
            // toolStripSearch
            // 
            this.toolStripSearch.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripSearch.Name = "toolStripSearch";
            this.toolStripSearch.Size = new System.Drawing.Size(122, 22);
            this.toolStripSearch.Text = "Search";
            // 
            // toolStripIndex
            // 
            this.toolStripIndex.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripIndex.Name = "toolStripIndex";
            this.toolStripIndex.Size = new System.Drawing.Size(122, 22);
            this.toolStripIndex.Text = "Index";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(119, 6);
            // 
            // toolStripAbout
            // 
            this.toolStripAbout.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripAbout.Name = "toolStripAbout";
            this.toolStripAbout.Size = new System.Drawing.Size(122, 22);
            this.toolStripAbout.Text = "About";
            // 
            // rtbText
            // 
            this.rtbText.BackColor = System.Drawing.SystemColors.Window;
            this.rtbText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbText.ForeColor = System.Drawing.Color.Black;
            this.rtbText.Location = new System.Drawing.Point(0, 77);
            this.rtbText.Name = "rtbText";
            this.rtbText.Size = new System.Drawing.Size(800, 348);
            this.rtbText.TabIndex = 1;
            this.rtbText.Text = "98465465df4g65sd4fg";
            this.rtbText.TextChanged += new System.EventHandler(this.rtbText_TextChanged);
            // 
            // toolStripFont
            // 
            this.toolStripFont.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripFont.BackgroundImage")));
            this.toolStripFont.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBold,
            this.toolStripItalic,
            this.toolStripUnderline});
            this.toolStripFont.Location = new System.Drawing.Point(0, 24);
            this.toolStripFont.Name = "toolStripFont";
            this.toolStripFont.Size = new System.Drawing.Size(800, 25);
            this.toolStripFont.TabIndex = 2;
            // 
            // toolStripBold
            // 
            this.toolStripBold.BackColor = System.Drawing.Color.White;
            this.toolStripBold.CheckOnClick = true;
            this.toolStripBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBold.ForeColor = System.Drawing.Color.White;
            this.toolStripBold.Image = ((System.Drawing.Image)(resources.GetObject("toolStripBold.Image")));
            this.toolStripBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBold.Name = "toolStripBold";
            this.toolStripBold.Size = new System.Drawing.Size(23, 22);
            this.toolStripBold.Text = "Bold";
            this.toolStripBold.CheckedChanged += new System.EventHandler(this.toolStripBold_CheckedChanged);
            // 
            // toolStripItalic
            // 
            this.toolStripItalic.BackColor = System.Drawing.Color.White;
            this.toolStripItalic.CheckOnClick = true;
            this.toolStripItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripItalic.ForeColor = System.Drawing.Color.White;
            this.toolStripItalic.Image = ((System.Drawing.Image)(resources.GetObject("toolStripItalic.Image")));
            this.toolStripItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripItalic.Name = "toolStripItalic";
            this.toolStripItalic.Size = new System.Drawing.Size(23, 22);
            this.toolStripItalic.Text = "Italic";
            this.toolStripItalic.CheckedChanged += new System.EventHandler(this.toolStripItalic_CheckedChanged);
            // 
            // toolStripUnderline
            // 
            this.toolStripUnderline.BackColor = System.Drawing.Color.White;
            this.toolStripUnderline.CheckOnClick = true;
            this.toolStripUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUnderline.ForeColor = System.Drawing.Color.White;
            this.toolStripUnderline.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUnderline.Image")));
            this.toolStripUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUnderline.Name = "toolStripUnderline";
            this.toolStripUnderline.Size = new System.Drawing.Size(23, 22);
            this.toolStripUnderline.Text = "Underline";
            this.toolStripUnderline.CheckedChanged += new System.EventHandler(this.toolStripUnderline_CheckedChanged);
            // 
            // toolStripAcciones
            // 
            this.toolStripAcciones.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStripAcciones.BackgroundImage")));
            this.toolStripAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCortar,
            this.toolStripCopiar,
            this.toolStripPegar,
            this.toolStripSeparator5,
            this.toolStripComboBox});
            this.toolStripAcciones.Location = new System.Drawing.Point(0, 49);
            this.toolStripAcciones.Name = "toolStripAcciones";
            this.toolStripAcciones.Size = new System.Drawing.Size(800, 25);
            this.toolStripAcciones.TabIndex = 3;
            this.toolStripAcciones.Text = "toolStripAcciones";
            // 
            // toolStripCortar
            // 
            this.toolStripCortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripCortar.ForeColor = System.Drawing.Color.White;
            this.toolStripCortar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCortar.Image")));
            this.toolStripCortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCortar.Name = "toolStripCortar";
            this.toolStripCortar.Size = new System.Drawing.Size(44, 22);
            this.toolStripCortar.Text = "Cortar";
            // 
            // toolStripCopiar
            // 
            this.toolStripCopiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripCopiar.ForeColor = System.Drawing.Color.White;
            this.toolStripCopiar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCopiar.Image")));
            this.toolStripCopiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCopiar.Name = "toolStripCopiar";
            this.toolStripCopiar.Size = new System.Drawing.Size(46, 22);
            this.toolStripCopiar.Text = "Copiar";
            // 
            // toolStripPegar
            // 
            this.toolStripPegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripPegar.ForeColor = System.Drawing.Color.White;
            this.toolStripPegar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripPegar.Image")));
            this.toolStripPegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripPegar.Name = "toolStripPegar";
            this.toolStripPegar.Size = new System.Drawing.Size(41, 22);
            this.toolStripPegar.Text = "Pegar";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripComboBox
            // 
            this.toolStripComboBox.Items.AddRange(new object[] {
            "Segoe UI"});
            this.toolStripComboBox.Name = "toolStripComboBox";
            this.toolStripComboBox.Size = new System.Drawing.Size(121, 25);
            this.toolStripComboBox.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_SelectedIndexChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmMenuStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStripAcciones);
            this.Controls.Add(this.toolStripFont);
            this.Controls.Add(this.rtbText);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMenuStrip";
            this.Text = "Menu Strip";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripFont.ResumeLayout(false);
            this.toolStripFont.PerformLayout();
            this.toolStripAcciones.ResumeLayout(false);
            this.toolStripAcciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripNew;
        private System.Windows.Forms.ToolStripMenuItem toolStripOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripSave;
        private System.Windows.Forms.ToolStripMenuItem toolStripSaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripPrint;
        private System.Windows.Forms.ToolStripMenuItem toolStripPrintPreview;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripContents;
        private System.Windows.Forms.ToolStripMenuItem toolStripSearch;
        private System.Windows.Forms.ToolStripMenuItem toolStripIndex;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripAbout;
        private System.Windows.Forms.ToolStripMenuItem toolStripFormat;
        private System.Windows.Forms.ToolStripMenuItem toolStripShowHelp;
        private System.Windows.Forms.RichTextBox rtbText;
        private System.Windows.Forms.ToolStrip toolStripFont;
        private System.Windows.Forms.ToolStripButton toolStripBold;
        private System.Windows.Forms.ToolStripButton toolStripItalic;
        private System.Windows.Forms.ToolStripButton toolStripUnderline;
        private System.Windows.Forms.ToolStrip toolStripAcciones;
        private System.Windows.Forms.ToolStripButton toolStripCortar;
        private System.Windows.Forms.ToolStripButton toolStripCopiar;
        private System.Windows.Forms.ToolStripButton toolStripPegar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
    }
}


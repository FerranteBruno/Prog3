
namespace ListBoxYChekedListBox
{
    partial class frmListBoxYCheckedListBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListBoxYCheckedListBox));
            this.lboxTextBox = new System.Windows.Forms.ListBox();
            this.btnMover = new System.Windows.Forms.Button();
            this.clbCheck = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // lboxTextBox
            // 
            this.lboxTextBox.FormattingEnabled = true;
            this.lboxTextBox.ItemHeight = 15;
            this.lboxTextBox.Location = new System.Drawing.Point(672, 12);
            this.lboxTextBox.Name = "lboxTextBox";
            this.lboxTextBox.Size = new System.Drawing.Size(500, 589);
            this.lboxTextBox.TabIndex = 1;
            // 
            // btnMover
            // 
            this.btnMover.BackColor = System.Drawing.Color.Transparent;
            this.btnMover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMover.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.btnMover.Location = new System.Drawing.Point(560, 230);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(75, 23);
            this.btnMover.TabIndex = 2;
            this.btnMover.Text = "Mover";
            this.btnMover.UseVisualStyleBackColor = false;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // clbCheck
            // 
            this.clbCheck.CheckOnClick = true;
            this.clbCheck.FormattingEnabled = true;
            this.clbCheck.Items.AddRange(new object[] {
            "Uno",
            "Dos",
            "Tres",
            "Cuatro",
            "Cinco",
            "Seis",
            "Siete",
            "Ocho",
            "Nueve"});
            this.clbCheck.Location = new System.Drawing.Point(12, 12);
            this.clbCheck.Name = "clbCheck";
            this.clbCheck.Size = new System.Drawing.Size(500, 580);
            this.clbCheck.TabIndex = 3;
            this.clbCheck.ThreeDCheckBoxes = true;
            this.clbCheck.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // frmListBoxYCheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1184, 636);
            this.Controls.Add(this.clbCheck);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.lboxTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListBoxYCheckedListBox";
            this.Text = "ListBox y ChekedListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lboxTextBox;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.CheckedListBox clbCheck;
    }
}


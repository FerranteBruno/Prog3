
namespace ControlLabelYLinkLabel
{
    partial class frmElForm
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
            this.lbElLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbElLabel
            // 
            this.lbElLabel.AutoSize = true;
            this.lbElLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbElLabel.Font = new System.Drawing.Font("Formula1 Display-Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbElLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.lbElLabel.Location = new System.Drawing.Point(81, 79);
            this.lbElLabel.Name = "lbElLabel";
            this.lbElLabel.Size = new System.Drawing.Size(102, 24);
            this.lbElLabel.TabIndex = 0;
            this.lbElLabel.Text = "Nombre";
            this.lbElLabel.MouseLeave += new System.EventHandler(this.lbElLabel_MouseLeave);
            this.lbElLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbElLabel_MouseMove);
            // 
            // frmElForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(464, 321);
            this.Controls.Add(this.lbElLabel);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Name = "frmElForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ControlLabelLinkLabel";
            this.Load += new System.EventHandler(this.frmElForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbElLabel;
    }
}


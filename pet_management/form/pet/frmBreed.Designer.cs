
namespace pet_management
{
    partial class frmBreed
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboBreed = new System.Windows.Forms.ComboBox();
            this.lbBreed = new DevExpress.XtraEditors.LabelControl();
            this.SuspendLayout();
            // 
            // cboBreed
            // 
            this.cboBreed.FormattingEnabled = true;
            this.cboBreed.Location = new System.Drawing.Point(392, 80);
            this.cboBreed.Name = "cboBreed";
            this.cboBreed.Size = new System.Drawing.Size(121, 24);
            this.cboBreed.TabIndex = 0;
            this.cboBreed.SelectedIndexChanged += new System.EventHandler(this.cboBreed_SelectedIndexChanged);
            // 
            // lbBreed
            // 
            this.lbBreed.Location = new System.Drawing.Point(357, 83);
            this.lbBreed.Name = "lbBreed";
            this.lbBreed.Size = new System.Drawing.Size(29, 18);
            this.lbBreed.TabIndex = 1;
            this.lbBreed.Text = "Loài";
            // 
            // frmBreed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbBreed);
            this.Controls.Add(this.cboBreed);
            this.Name = "frmBreed";
            this.Text = "frmBreed";
            this.Load += new System.EventHandler(this.frmBreed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBreed;
        private DevExpress.XtraEditors.LabelControl lbBreed;
    }
}
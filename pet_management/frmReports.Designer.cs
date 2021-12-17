
namespace pet_management
{
    partial class frmReports
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
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.ucPartUseReport1 = new pet_management.ucPartUseReport();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(512, 161);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(94, 29);
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Thực hiện";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // ucPartUseReport1
            // 
            this.ucPartUseReport1.Location = new System.Drawing.Point(12, 12);
            this.ucPartUseReport1.Name = "ucPartUseReport1";
            this.ucPartUseReport1.Size = new System.Drawing.Size(630, 143);
            this.ucPartUseReport1.TabIndex = 0;
            // 
            // frmReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 206);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.ucPartUseReport1);
            this.Name = "frmReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo";
            this.ResumeLayout(false);

        }

        #endregion

        private ucPartUseReport ucPartUseReport1;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}
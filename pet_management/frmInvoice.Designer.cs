
namespace pet_management
{
    partial class frmInvoice
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
            this.crvInvoice = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.rptInvoice = new DTO.rptMedical();
            this.SuspendLayout();
            // 
            // crvInvoice
            // 
            this.crvInvoice.ActiveViewIndex = -1;
            this.crvInvoice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInvoice.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvInvoice.Location = new System.Drawing.Point(0, 0);
            this.crvInvoice.Name = "crvInvoice";
            this.crvInvoice.Size = new System.Drawing.Size(1085, 697);
            this.crvInvoice.TabIndex = 0;
            this.crvInvoice.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // rptInvoice
            // 
            this.rptInvoice.FileName = "rassdk://D:\\pet-management\\pet_management\\DTO\\rptInvoice.rpt";
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 697);
            this.Controls.Add(this.crvInvoice);
            this.Name = "frmInvoice";
            this.Text = "Bản kê sử dụng dịch vụ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmInvoice_FormClosing);
            this.Load += new System.EventHandler(this.frmInvoice_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInvoice;
        private DTO.rptMedical rptInvoice;
    }
}
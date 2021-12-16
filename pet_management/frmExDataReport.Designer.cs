
namespace pet_management
{
    partial class frmExDataReport
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
            this.crvExData = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.rptExaminationReport1 = new DTO.rptExaminationReport();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // crvExData
            // 
            this.crvExData.ActiveViewIndex = -1;
            this.crvExData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvExData.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvExData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvExData.Location = new System.Drawing.Point(0, 74);
            this.crvExData.Name = "crvExData";
            this.crvExData.Size = new System.Drawing.Size(783, 372);
            this.crvExData.TabIndex = 3;
            this.crvExData.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.simpleButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 74);
            this.panel1.TabIndex = 4;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(74, 12);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 29);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "simpleButton1";
            // 
            // rptExaminationReport1
            // 
            this.rptExaminationReport1.FileName = "rassdk://D:\\pet-management\\pet_management\\DTO\\rptExaminationData.rpt";
            // 
            // frmExDataReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 446);
            this.Controls.Add(this.crvExData);
            this.Controls.Add(this.panel1);
            this.Name = "frmExDataReport";
            this.Text = "frmExDataReport";
            this.Load += new System.EventHandler(this.frmExDataReport_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvExData;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DTO.rptExaminationReport rptExaminationReport1;
    }
}
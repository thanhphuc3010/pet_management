
namespace pet_management
{
    partial class frmDTReport
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
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.btnQuit = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtYear = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtYear.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtYear.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(18, 104);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(69, 18);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "Hình thức:";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(93, 101);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(492, 26);
            this.cboType.TabIndex = 9;
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(491, 140);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(94, 29);
            this.btnQuit.TabIndex = 13;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(391, 140);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(94, 29);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Thực hiện";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(233, 62);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 18);
            this.labelControl2.TabIndex = 17;
            this.labelControl2.Text = "Năm:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 62);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(45, 18);
            this.labelControl1.TabIndex = 18;
            this.labelControl1.Text = "Tháng:";
            // 
            // dtYear
            // 
            this.dtYear.EditValue = null;
            this.dtYear.Location = new System.Drawing.Point(275, 59);
            this.dtYear.Name = "dtYear";
            this.dtYear.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtYear.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtYear.Properties.Mask.EditMask = "yyyy";
            this.dtYear.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtYear.Properties.VistaCalendarInitialViewStyle = DevExpress.XtraEditors.VistaCalendarInitialViewStyle.YearsGroupView;
            this.dtYear.Properties.VistaCalendarViewStyle = DevExpress.XtraEditors.VistaCalendarViewStyle.YearsGroupView;
            this.dtYear.Size = new System.Drawing.Size(117, 24);
            this.dtYear.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(12, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(588, 24);
            this.labelControl4.TabIndex = 19;
            this.labelControl4.Text = "BÁO CÁO DOANH THU DỊCH VỤ KHÁM CHỮA BỆNH THEO THÁNG\r\n";
            // 
            // cboMonth
            // 
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(93, 58);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(134, 26);
            this.cboMonth.TabIndex = 20;
            // 
            // frmDTReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 186);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtYear);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.cboType);
            this.Name = "frmDTReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo doanh thu theo tháng/năm";
            this.Load += new System.EventHandler(this.frmDTReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtYear.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtYear.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.ComboBox cboType;
        private DevExpress.XtraEditors.SimpleButton btnQuit;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtYear;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cboMonth;
    }
}
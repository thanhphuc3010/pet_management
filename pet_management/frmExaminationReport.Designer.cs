
namespace pet_management
{
    partial class frmExaminationReport
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dtToDate = new DevExpress.XtraEditors.DateEdit();
            this.dtFromDate = new DevExpress.XtraEditors.DateEdit();
            this.cboDoctor = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cboCustomer = new System.Windows.Forms.ComboBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnQuit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(344, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 18);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Đến ngày:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(31, 127);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 18);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Bác sĩ:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(31, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 18);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "Từ ngày:";
            // 
            // dtToDate
            // 
            this.dtToDate.EditValue = null;
            this.dtToDate.Location = new System.Drawing.Point(415, 50);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtToDate.Size = new System.Drawing.Size(183, 24);
            this.dtToDate.TabIndex = 6;
            // 
            // dtFromDate
            // 
            this.dtFromDate.EditValue = null;
            this.dtFromDate.Location = new System.Drawing.Point(118, 50);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFromDate.Size = new System.Drawing.Size(220, 24);
            this.dtFromDate.TabIndex = 5;
            // 
            // cboDoctor
            // 
            this.cboDoctor.FormattingEnabled = true;
            this.cboDoctor.Location = new System.Drawing.Point(118, 123);
            this.cboDoctor.Name = "cboDoctor";
            this.cboDoctor.Size = new System.Drawing.Size(480, 26);
            this.cboDoctor.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(129, 12);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(352, 24);
            this.labelControl4.TabIndex = 10;
            this.labelControl4.Text = "BÁO CÁO THÚ NUÔI SỬ DỤNG DỊCH VỤ";
            // 
            // cboCustomer
            // 
            this.cboCustomer.FormattingEnabled = true;
            this.cboCustomer.Location = new System.Drawing.Point(118, 86);
            this.cboCustomer.Name = "cboCustomer";
            this.cboCustomer.Size = new System.Drawing.Size(480, 26);
            this.cboCustomer.TabIndex = 4;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(31, 90);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(81, 18);
            this.labelControl5.TabIndex = 8;
            this.labelControl5.Text = "Khách hàng:";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(118, 162);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(480, 26);
            this.cboType.TabIndex = 4;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(31, 166);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(69, 18);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Hình thức:";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(404, 212);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(94, 29);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Thực hiện";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.Location = new System.Drawing.Point(504, 212);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(94, 29);
            this.btnQuit.TabIndex = 11;
            this.btnQuit.Text = "Thoát";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmExaminationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 253);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.cboCustomer);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.cboDoctor);
            this.Name = "frmExaminationReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo thú nuôi sử dụng dịch vụ";
            this.Load += new System.EventHandler(this.frmExaminationReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.DateEdit dtToDate;
        private DevExpress.XtraEditors.DateEdit dtFromDate;
        private System.Windows.Forms.ComboBox cboDoctor;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private System.Windows.Forms.ComboBox cboCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ComboBox cboType;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnQuit;
    }
}
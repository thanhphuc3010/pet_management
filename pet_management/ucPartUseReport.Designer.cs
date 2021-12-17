
namespace pet_management
{
    partial class ucPartUseReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboDoctor = new System.Windows.Forms.ComboBox();
            this.dtFromDate = new DevExpress.XtraEditors.DateEdit();
            this.dtToDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDoctor
            // 
            this.cboDoctor.FormattingEnabled = true;
            this.cboDoctor.Location = new System.Drawing.Point(88, 101);
            this.cboDoctor.Name = "cboDoctor";
            this.cboDoctor.Size = new System.Drawing.Size(505, 26);
            this.cboDoctor.TabIndex = 0;
            // 
            // dtFromDate
            // 
            this.dtFromDate.EditValue = null;
            this.dtFromDate.Location = new System.Drawing.Point(88, 57);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFromDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtFromDate.Size = new System.Drawing.Size(204, 24);
            this.dtFromDate.TabIndex = 1;
            // 
            // dtToDate
            // 
            this.dtToDate.EditValue = null;
            this.dtToDate.Location = new System.Drawing.Point(369, 57);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtToDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtToDate.Size = new System.Drawing.Size(224, 24);
            this.dtToDate.TabIndex = 2;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(26, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(56, 18);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Từ ngày:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(298, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(65, 18);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Đến ngày:";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(26, 105);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 18);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Bác sĩ:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(146, 16);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(363, 24);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "BÁO CÁO CHI TIẾT HÀNG HÓA SỬ DỤNG";
            // 
            // ucPartUseReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.cboDoctor);
            this.Name = "ucPartUseReport";
            this.Size = new System.Drawing.Size(619, 160);
            this.Load += new System.EventHandler(this.ucPartUseReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFromDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtToDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDoctor;
        private DevExpress.XtraEditors.DateEdit dtFromDate;
        private DevExpress.XtraEditors.DateEdit dtToDate;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}

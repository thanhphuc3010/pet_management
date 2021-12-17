using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace pet_management
{
    public partial class frmDTReport : DevExpress.XtraEditors.XtraForm
    {
        public frmDTReport()
        {
            InitializeComponent();
        }

        private void dtFromDate_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmDTReport_Load(object sender, EventArgs e)
        {
            LoadMonth();
            LoadType();

        }

        private void LoadMonth()
        {
            List<Month> months = new List<Month>();
            Month month = new Month();
            month.Description = "--Tháng--";
            month.Value = 0;
            months.Add(month);

            for (int i = 0; i < 12; i++)
            {
                Month m = new Month();
                m.Description = $"Tháng {i + 1}";
                m.Value = i + 1;
                months.Add(m);
            }
            cboMonth.DataSource = months;
            cboMonth.DisplayMember = "Description";
            cboMonth.ValueMember = "Value";
        }

        private void LoadType()
        {
            cboType.DataSource = ExaminationType.GetListType();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            int month = (int)cboMonth.SelectedValue;
            string type = cboType.SelectedItem.ToString();
            int year = dtYear.DateTime.Year;

            frmMain frm = (frmMain)Owner;
            Staff currStaff = frm.GetStaffLogined();
            currStaff.FullName = $"{currStaff.FirstName} {currStaff.LastName}";

            frmExDataReport f = new frmExDataReport(type, month, year, currStaff);
            f.ShowDialog();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
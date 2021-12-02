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
using DevExpress.XtraPrinting;
using DevExpress.Export;

namespace pet_management
{
    public partial class frmPart : DevExpress.XtraEditors.XtraForm
    {
        PartBUS partBUS = new PartBUS();
        public frmPart()
        {
            InitializeComponent();
        }
        #region Handle Event
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            MyHelper.HandleSearch(gridViewPart, txtSearch);
        }

        private void frmPart_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        #endregion

        #region Handle Logic
        public void LoadData()
        {
            List<Part> parts = partBUS.GetParts();
            partBindingSource.DataSource = parts;
            gridViewPart.BestFitColumnsEx();
        }
        #endregion

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPartInfor f = new frmPartInfor(this, null, isEditMode: false);
            f.ShowDialog();
        }

        private void rbtnDelete_Click(object sender, EventArgs e)
        {
            Part part = gridViewPart.GetFocusedRow() as Part;
            if (XtraMessageBox.Show($"Bạn có chắc chắn muốn xóa {part.Name} ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool isSuccess = partBUS.Delete(part.Id.ToString());
                if (isSuccess)
                {
                    LoadData();
                    XtraMessageBox.Show($"Xóa hàng hóa: {part.Name} thành công", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void rtbnEdit_Click(object sender, EventArgs e)
        {
            Part part = gridViewPart.GetFocusedRow() as Part;
            frmPartInfor f = new frmPartInfor(this, part, isEditMode: true);
            f.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            ExportExcel("");
        }

        private bool ExportExcel(string fileName)
        {
            try
            {
                if(gridViewPart.FocusedRowHandle < 0)
                {

                } else
                {
                    var dialog = new SaveFileDialog();
                    dialog.Title = "Export file excel";
                    dialog.FileName = fileName;
                    dialog.Filter = @"Microsoft Excel|*.xlsx";

                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        gridViewPart.ColumnPanelRowHeight = 35;
                        gridViewPart.OptionsPrint.AutoWidth = AutoSize;
                        gridViewPart.OptionsPrint.ShowPrintExportProgress = true;
                        gridViewPart.OptionsPrint.AllowCancelPrintExport = true;
                        XlsxExportOptions options = new XlsxExportOptions();
                        options.TextExportMode = TextExportMode.Text;
                        options.ExportMode = XlsxExportMode.SingleFile;
                        options.SheetName = "Sheet1";

                        ExportSettings.DefaultExportType = ExportType.Default;
                        gridViewPart.ExportToXlsx(dialog.FileName , options);
                        XtraMessageBox.Show("Export Success", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
    }
}
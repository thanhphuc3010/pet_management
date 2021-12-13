using BUS;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet_management
{
    public partial class frmSelectService : DevExpress.XtraEditors.XtraForm
    {
        private ServiceBUS serviceBUS = new ServiceBUS();
        private ExaminationBUS examinationBUS = new ExaminationBUS();
        private long examinationId;
        private readonly frmExamination frmExamination;
        public frmSelectService(frmExamination frmExamination, long examinationId)
        {
            InitializeComponent();
            this.frmExamination = frmExamination;
            this.examinationId = examinationId;
        }

        private void frmSelectService_Load(object sender, EventArgs e)
        {
            serviceBindingSource.DataSource = serviceBUS.GetServices();
        }

        private void gridViewService_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string id = view.GetFocusedRowCellValue("Id").ToString();
                Service service = serviceBUS.GetServiceById(id);
                if (frmExamination != null)
                {
                    ExaminationService exService = new ExaminationService();
                    exService.ExaminationId = examinationId;
                    exService.ServiceId = service.Id;
                    exService.Tax = service.Tax;
                    exService.Price = service.Price;
                    exService.Discount = 0;
                    if (examinationBUS.SaveServiceDetail(exService))
                    {
                        frmExamination.RefreshExDetail();
                        this.Close();
                    }
                }
            }
        }
    }
}
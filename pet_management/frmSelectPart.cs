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
    public partial class frmSelectPart : DevExpress.XtraEditors.XtraForm
    {
        private PartBUS partBUS = new PartBUS();
        private ExaminationBUS examinationBUS = new ExaminationBUS();
        private long examinationId;
        private readonly frmExamination frmExamination;
        public frmSelectPart(frmExamination frmExamination, long examinationId)
        {
            InitializeComponent();
            this.frmExamination = frmExamination;
            this.examinationId = examinationId;
        }

        private void frmSelectPart_Load(object sender, EventArgs e)
        {
            partBindingSource.DataSource = partBUS.GetParts();
        }

        private void gridViewPart_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridView view = sender as GridView;
            GridHitInfo info = view.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                string id = view.GetFocusedRowCellValue("Id").ToString();
                Part part = partBUS.GetPartById(id);
                if (frmExamination != null)
                {
                    ExaminationPart exPart = new ExaminationPart();
                    exPart.ExaminationId = examinationId;
                    exPart.PartId = part.Id;
                    exPart.Quantity = 1;
                    exPart.Price = part.Price;
                    exPart.ServiceUsedId = null;
                    if (examinationBUS.SavePartDetail(exPart))
                    {
                        frmExamination.RefreshExDetail();
                        this.Close();
                    }
                }
            }
        }
    }
}
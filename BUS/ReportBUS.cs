using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class ReportBUS
    {
        private ExaminationDAO exDAO = new ExaminationDAO();
        private StaffDAO staffDAO = new StaffDAO();
        private PetDAO petBUS = new PetDAO();
        private ReceivePetDAO dao = new ReceivePetDAO();

        private ExaminationPartDAO exPartDao = new ExaminationPartDAO();
        private ExaminationServiceDAO exServiceDao = new ExaminationServiceDAO();
        private PartDAO partDAO = new PartDAO();
        private ServiceDAO serviceDAO = new ServiceDAO();

        private PetData GetPetData(string id)
        {
            PetData petData = dao.GetPetData(id);
            petData.CustomerName = $"{petData.FirstName} {petData.LastName}";
            return petData;
        }
        public List<ExaminationInfor> GetListExaminationInfor(DateTime fromDate, DateTime toDate)
        {
            List<ExaminationInfor> examinationInfor = exDAO.GetExaminationInfors(fromDate, toDate);
            return examinationInfor;
        }

        public List<ExaminationData> GetExaminationDatas(int month, int year, string type)
        {
            List<ExaminationData> examinationDatas = exDAO.GetExaminationDatas(month, year, type);
            return examinationDatas;
        }
        public List<ExaminationPartReport> GetExaminationPartReports()
        {
            List<ExaminationPartReport> data = exDAO.GetExPartDataReport();
            return data;
        }
    }
}

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
        public List<ExaminationInfor> GetListExaminationInfor()
        {
            List<ExaminationInfor> examinationInfor = exDAO.GetExaminationInfors();
            //List<Examination> examinations = exDAO.GetExaminations();
            //foreach (Examination examination in examinations)
            //{
            //    ExaminationInfor exInfor = new ExaminationInfor();
            //    exInfor.MapperData(examination);
            //    PetData petData = GetPetData(examination.PetId.ToString());
            //    Staff receptionlist = StaffDAO.GetStaffById(examination.ReceptionistId.ToString());
            //    Staff doctor = StaffDAO.GetStaffById(examination.DoctorId.ToString());

            //    exInfor.Breed = petData.Breed;
            //    exInfor.Species = petData.Species;
            //    exInfor.PetName = petData.PetName;
            //    exInfor.CustomerName = petData.CustomerName;
            //    exInfor.ReceptionistName = $"{receptionlist.FirstName} {receptionlist.LastName}";
            //    exInfor.DoctorName = $"{doctor.FirstName} {doctor.LastName}";
            //    examinationInfor.Add(exInfor);
            //}
            return examinationInfor;
        }

        public List<ExaminationData> GetExaminationDatas()
        {
            List<ExaminationData> examinationDatas = exDAO.GetExaminationDatas();
            return examinationDatas;
        }
    }
}

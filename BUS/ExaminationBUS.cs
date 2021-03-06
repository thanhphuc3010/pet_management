using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class ExaminationBUS
    {
        private ExaminationDAO dao = new ExaminationDAO();
        private ExaminationPartDAO exPartDao = new ExaminationPartDAO();
        private ExaminationServiceDAO exServiceDao = new ExaminationServiceDAO();
        private PartDAO partDAO = new PartDAO();
        private ServiceDAO serviceDAO = new ServiceDAO();

        public bool Save(Examination examination)
        {
            int result = dao.Save(examination);
            return (result == 1);
        }

        public bool DeleteExamination(Examination examination) => dao.DeleteExamination(examination);

        public bool DeletePartDetail(ExaminationPart exPart)
        {
            return exPartDao.Delete(exPart);
        }

        public bool SavePartDetail(ExaminationPart exPart)
        {
            int result = exPartDao.Save(exPart);
            return (result == 1);
        }

        public List<Examination> GetExaminations()
        {
            return dao.GetExaminations();
        }

        public List<Examination> GetExaminationByPetId(string petId)
        {
            return dao.GetExaminationById(petId);
        }

        public List<Examination> GetExaminationsToday()
        {
            return dao.GetExaminationsToday();
        }

        public List<ELItem> GetDetail(long exId)
        {
            List<ELItem> details = new List<ELItem>();
            List<ExaminationPart> partDetails = exPartDao.GetExaminationPartsDetail(exId);
            foreach (ExaminationPart exPart in partDetails)
            {
                Part p = partDAO.GetPartById(exPart.PartId.ToString());
                var item = exPart.ToELItem();
                item.ItemName = p.Name;
                item.ItemNumber = p.PartNumber;
                item.UnitId = p.UnitId;
                item.UnitName = UnitBUS.GetUnitById(item.UnitId.ToString()).Name.ToString();

                var discountRate = (item.DiscountRate == null) ? 0 : (decimal)item.DiscountRate;
                var taxRate = (item.TaxRate == null) ? 0 : (decimal)item.TaxRate;
                var sum = item.Quantity * item.Price;
                item.Discount = sum * (discountRate / 100);
                item.Tax = sum * (taxRate / 100);
                item.Total = sum - item.Discount + item.Tax;
                details.Add(item);
            }

            List<ExaminationService> serviceDetails = exServiceDao.GetExaminationServicesDetail(exId);
            foreach (ExaminationService exService in serviceDetails)
            {
                Service s = serviceDAO.GetServiceById(exService.ServiceId.ToString());
                var item = exService.ToELItem();
                item.ItemName = s.Name;
                item.ItemNumber = s.Id.ToString();
                item.UnitId = s.UnitId;
                item.UnitName = UnitBUS.GetUnitById(item.UnitId.ToString()).Name.ToString();

                var discountRate = (item.DiscountRate == null) ? 0 : (decimal)item.DiscountRate;
                var taxRate = (item.TaxRate == null) ? 0 : (decimal)item.TaxRate;
                var sum = item.Quantity * item.Price;
                item.Discount = sum * (discountRate / 100);
                item.Tax = sum * (taxRate / 100);
                item.Total = sum - item.Discount + item.Tax;

                details.Add(item);
            }

            return details;
        }

        public bool UpdatePartDetail(ExaminationPart exPart)
        {
            return exServiceDao.Update(exPart);
        }

        public bool SaveServiceDetail(ExaminationService exService)
        {
            int result = exServiceDao.Save(exService);
            return (result == 1);
        }

        public bool DeleteServiceDetail(ExaminationService exService)
        {
            return exServiceDao.Delete(exService);
        }

        public bool DoneExamination(Examination examination)
        {
            return dao.DoneExamination(examination);
        }

        //public List<ExaminationInfor> GetExaminationInfors()
        //{
        //    return dao.GetExaminationInfors();
        //}
    }
}

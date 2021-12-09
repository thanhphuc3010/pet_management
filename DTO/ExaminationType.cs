using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ExaminationType
    {
        public static string EXAMINATION = "Khám-chữa bệnh";
        public static string HEALTH_CARE = "Chăm sóc sức khỏe";
        public static string VACCINATION = "Tiêm phòng";
        public static string NUTRITION = "Tư vấn dinh dưỡng";

        public static List<String> GetListType()
        {
            List<String> result = new List<String>();
            result.Add(EXAMINATION);
            result.Add(HEALTH_CARE);
            result.Add(VACCINATION);
            result.Add(NUTRITION);
            return result;
        }
    }
}

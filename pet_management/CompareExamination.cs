
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_management
{
    public class CompareExamination : IComparer<Examination>
    {
        public int Compare(Examination x, Examination y)
        {
            if (object.ReferenceEquals(x, y))
            {
                return 0;
            }

            if (x == null)
            {
                return -1;
            }

            if (y == null)
            {
                return 1;
            }

            if (x.Status == "Đã khám xong")
            {
                return 0;
            }
            else return 1;
        }
    }
}

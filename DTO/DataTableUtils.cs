using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public static class DataTableUtils
    {
        public static object GetValueInCell(this DataRow row, string field)
        {
            var result = (row[field] != DBNull.Value) ? row[field] : null;
            return result;
        }
    }
}

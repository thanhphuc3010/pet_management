using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pet_management
{
    public static class TextBoxUtils
    {
        public static void FocusEnd(this TextEdit tb)
        {
            tb.Focus();
            tb.SelectionStart = tb.Text.Length;
            tb.SelectionLength = 0;
        }

        public static string GetTextTrim(this TextEdit tb)
        {
            return tb.Text.ToString().Trim();
        }

        public static decimal ToDecimal(this TextEdit tb)
        {
            return Convert.ToDecimal(tb.Text.ToString());
        }
        public static int ToInt(this TextEdit tb)
        {
            return Convert.ToInt32(tb.Text.ToString());
        }

        public static void ApplyFormatToView(this TextEdit tb)
        {
            tb.Properties.Mask.UseMaskAsDisplayFormat = true;
        }

        public static void FormatCurrency(this TextEdit tb)
        {
            CultureInfo info = new CultureInfo("vi-VN");
            string symbol = info.NumberFormat.CurrencySymbol;
            info.NumberFormat.CurrencySymbol = symbol;
            info.NumberFormat.CurrencyGroupSeparator = ",";
            tb.Properties.Mask.Culture = info;
        }
    }
}

using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
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
    }
}

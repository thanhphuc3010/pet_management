using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pet_management
{
    public static class GridViewUtils
    {
        public static void BestFitColumnsEx(this GridView view)
        {
            if (!view.OptionsCustomization.AllowColumnResizing)
            {
                view.OptionsCustomization.AllowColumnResizing = true;
                view.BestFitColumns();
                view.OptionsCustomization.AllowColumnResizing = false;
            }
            else
            {
                view.BestFitColumns();
            }
        }
    }
}

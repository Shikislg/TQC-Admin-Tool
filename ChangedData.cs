using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Dashboard
{
    class ChangedData
    {
        public Boolean dataHasChanged;
        public void SetBoolean(Boolean val)
        {
            dataHasChanged = val;
            if (val == true)
            {
                    GlobalDependencies.dashboardInstance.SaveButton.Visible = true;
                    GlobalDependencies.dashboardInstance.ResetButton.Visible = true;
            }
        }

    }
}

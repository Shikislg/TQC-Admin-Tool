using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dashboard
{
    public static class Rules
    {
        public static void SetMinPoints(int minPoints)
        {
            Properties.Settings.Default.minimumPoints = minPoints;
            Properties.Settings.Default.Save();
        }
    }
}

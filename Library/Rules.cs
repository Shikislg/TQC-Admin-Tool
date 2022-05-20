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
        public static int GetMinPoints()
        {
            return Properties.Settings.Default.minimumPoints;
        }
       
        public static void SetPointHandlingMode(int val)
        {
            Properties.Settings.Default.pointHandlingMode = val;
        }
        public static int GetPointHandlingMode()
        {
            return Properties.Settings.Default.pointHandlingMode;
        }
        
        public static void SetPullDataOnOpen(int val)
        {
            if (val == 1)
            {
                Properties.Settings.Default.PullDataOnOpen = true;
            }
            else
            {
                Properties.Settings.Default.PullDataOnOpen = false;
            }
        }
        public static int GetPullDataOnOpen()
        {
            if (Properties.Settings.Default.PullDataOnOpen == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public static void SetCheckDateFrequency(int val)
        {
            Properties.Settings.Default.CheckingPeriod = val;
        }
        public static int GetCheckDateFrequency()
        {
            return Properties.Settings.Default.CheckingPeriod;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dashboard
{
    public partial class S_Layout : Form
    {
        readonly bool functionAccess = false;
        public S_Layout()
        {
            InitializeComponent();
            SchemeSelector.SelectedIndex = Properties.Settings.Default.selectedScheme;
            functionAccess = true;
        }

        #region SchemeSelector
        private void ColorOne_Click(object sender, EventArgs e)
        {
            ColorSelector(AccentOneDialog, Properties.Settings.Default.AccentOne, AccentOneLbl);
        }

        private void ColorTwo_Click(object sender, EventArgs e)
        {
            ColorSelector(AccentTwo, Properties.Settings.Default.AccentTwo, AccentTwoLbl);
        }

        private void ColorThree_Click(object sender, EventArgs e)
        {
            ColorSelector(AccentThree, Properties.Settings.Default.AccentThree, AccentThreeLbl);
        }

        private void ColorFour_Click(object sender, EventArgs e)
        {
            ColorSelector(AccentFour, Properties.Settings.Default.AccentFour, AccentFourLbl);
        }

        private void ColorFive_Click(object sender, EventArgs e)
        {
            ColorSelector(AccentFive, Properties.Settings.Default.AccentFive, AccentFiveLbl);
        }

        private void ColorSix_Click(object sender, EventArgs e)
        {
            ColorSelector(AccentSix, Properties.Settings.Default.AccentSix, AccentSixLbl);
        }

        private void ColorSeven_Click(object sender, EventArgs e)
        {
            ColorSelector(AccentSeven, Properties.Settings.Default.AccentSeven, AccentSevenLbl);
        }

        private void AccentEightLbl_Click(object sender, EventArgs e)
        {
            ColorSelector(AccentEight, Properties.Settings.Default.AccentEight, AccentEightLbl);
        }

        private void SchemeSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!functionAccess)
            {
                return;
            }
            Properties.Settings.Default.selectedScheme = SchemeSelector.SelectedIndex;
            switch (SchemeSelector.SelectedIndex)
            {
                case -1: MessageBox.Show("No Scheme Selected", "Error"); break;
                case 0: ApplyScheme(0); break;
                case 1: ApplyScheme(1); break;
            }
            if (MessageBox.Show("You will need to reload the application for the changes to take effect. Do you want to restart the Application?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { Application.Restart(); }
        }
        #endregion
        #region UtilityMethods

        private void ColorSelector(ColorDialog dialog, Color toBeChanged, Panel pnl)
        {
            dialog.Color = Properties.Settings.Default.AccentOne;
            dialog.FullOpen = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                toBeChanged = dialog.Color;
                if (MessageBox.Show("You will need to reload the application for the changes to take effect. Do you want to restart the Application?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { Application.Restart(); }
            }
            pnl.BackColor = toBeChanged;
        }
        private void ApplyScheme(int schemeIndex)
        {
            try
            {
                for (int i = 1; i < 9; i++)
                {
                    switch (i)
                    {
                        case 1: Properties.Settings.Default.AccentOne = GlobalDependencies.defaultSchemes[schemeIndex, i - 1]; break;
                        case 2: Properties.Settings.Default.AccentTwo = GlobalDependencies.defaultSchemes[schemeIndex, i - 1]; break;
                        case 3: Properties.Settings.Default.AccentThree = GlobalDependencies.defaultSchemes[schemeIndex, i - 1]; break;
                        case 4: Properties.Settings.Default.AccentFour = GlobalDependencies.defaultSchemes[schemeIndex, i - 1]; break;
                        case 5: Properties.Settings.Default.AccentFive = GlobalDependencies.defaultSchemes[schemeIndex, i - 1]; break;
                        case 6: Properties.Settings.Default.AccentSix = GlobalDependencies.defaultSchemes[schemeIndex, i - 1]; break;
                        case 7: Properties.Settings.Default.AccentSeven = GlobalDependencies.defaultSchemes[schemeIndex, i - 1]; break;
                        case 8: Properties.Settings.Default.AccentEight = GlobalDependencies.defaultSchemes[schemeIndex, i - 1]; break;
                    }
                    Properties.Settings.Default.Save();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }
        }
        #endregion
    }
}

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
    public partial class SettingsForm : Form
    {
        bool functionAccess = false;
        public SettingsForm()
        {
            InitializeComponent();
            SchemeSelector.SelectedIndex = Properties.Settings.Default.selectedScheme;
            functionAccess = true;
            PointModeBox.SelectedIndex = Properties.Settings.Default.pointHandlingMode;
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Properties.Settings.Default.minimumPoints = int.Parse(MinPointsTf.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input", "Error");
            }
        }

        private void PointModeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (PointModeBox.SelectedIndex)
            {
                case 0:Properties.Settings.Default.pointHandlingMode = 0;break;
                case 1: Properties.Settings.Default.pointHandlingMode = 1; break;
            }
            Properties.Settings.Default.Save();
        }

        private void ColorOne_Click(object sender, EventArgs e)
        {
            AccentOneDialog.Color = Properties.Settings.Default.AccentOne;
            AccentOneDialog.FullOpen = true;
            if (AccentOneDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.AccentOne = AccentOneDialog.Color;
                Properties.Settings.Default.Save();
                if(MessageBox.Show("You will need to reload the application for the changes to take effect. Do you want to restart the Application?","Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes){ Application.Restart(); }
            }
            AccentOneLbl.BackColor = Properties.Settings.Default.AccentOne;
        }

        private void ColorTwo_Click(object sender, EventArgs e)
        {
            AccentTwo.Color = Properties.Settings.Default.AccentTwo;
            AccentTwo.FullOpen = true;
            if (AccentTwo.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.AccentTwo = AccentTwo.Color;
                Properties.Settings.Default.Save();
                if (MessageBox.Show("You will need to reload the application for the changes to take effect. Do you want to restart the Application?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {Application.Restart();}
            }
            AccentTwoLbl.BackColor = Properties.Settings.Default.AccentTwo;
        }


        private void ColorThree_Click(object sender, EventArgs e)
        {
            AccentThree.Color = Properties.Settings.Default.AccentThree;
            AccentThree.FullOpen = true;
            if (AccentThree.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.AccentThree = AccentThree.Color;
                Properties.Settings.Default.Save();
                if(MessageBox.Show("You will need to reload the application for the changes to take effect. Do you want to restart the Application?","Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes){ Application.Restart(); }
            }
            AccentThreeLbl.BackColor = Properties.Settings.Default.AccentThree;
        }

        private void ColorFour_Click(object sender, EventArgs e)
        {
            AccentFour.Color = Properties.Settings.Default.AccentFour;
            AccentFour.FullOpen = true;
            if (AccentFour.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.AccentFour = AccentFour.Color;
                Properties.Settings.Default.Save();
                if(MessageBox.Show("You will need to reload the application for the changes to take effect. Do you want to restart the Application?","Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes){ Application.Restart(); }
            }
            AccentFourLbl.BackColor = Properties.Settings.Default.AccentFour;   
        }

        private void ColorFive_Click(object sender, EventArgs e)
        {
            AccentFive.Color = Properties.Settings.Default.AccentFive;
            AccentFive.FullOpen = true;
            if (AccentFive.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.AccentFive = AccentFive.Color;
                Properties.Settings.Default.Save();
                if(MessageBox.Show("You will need to reload the application for the changes to take effect. Do you want to restart the Application?","Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes){ Application.Restart(); }
            }
            AccentFiveLbl.BackColor = Properties.Settings.Default.AccentFive;
        }

        private void ColorSix_Click(object sender, EventArgs e)
        {
            AccentSix.Color = Properties.Settings.Default.AccentSix;
            AccentSix.FullOpen = true;
            if (AccentSix.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.AccentSix = AccentSix.Color;
                Properties.Settings.Default.Save();
                if(MessageBox.Show("You will need to reload the application for the changes to take effect. Do you want to restart the Application?","Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes){ Application.Restart(); }
            }
            AccentSixLbl.BackColor = Properties.Settings.Default.AccentSix; 
        }

        private void ColorSeven_Click(object sender, EventArgs e)
        {
            AccentSeven.Color = Properties.Settings.Default.AccentSeven;
            AccentSeven.FullOpen = true;
            if (AccentSeven.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.AccentSeven = AccentSeven.Color;
                Properties.Settings.Default.Save();
                if(MessageBox.Show("You will need to reload the application for the changes to take effect. Do you want to restart the Application?","Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes){ Application.Restart(); }
            }
            AccentSevenLbl.BackColor = Properties.Settings.Default.AccentSeven;
        }

        private void AccentEightLbl_Click(object sender, EventArgs e)
        {
            AccentEight.Color = Properties.Settings.Default.AccentEight;
            AccentEight.FullOpen = true;
            if (AccentEight.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.AccentEight = AccentEight.Color;
                Properties.Settings.Default.Save();
                if(MessageBox.Show("You will need to reload the application for the changes to take effect. Do you want to restart the Application?","Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes){ Application.Restart(); }
            }
            AccentEightLbl.BackColor = Properties.Settings.Default.AccentEight;
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
                case -1:MessageBox.Show("No Scheme Selected","Error");break;
                case 0:ApplyScheme(0); break;
                case 1:ApplyScheme(1); break;
            }
            if (MessageBox.Show("You will need to reload the application for the changes to take effect. Do you want to restart the Application?", "Restart", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) { Application.Restart(); }
        }
        private void ApplyScheme(int schemeIndex)
        {
            try
            {
                for (int i = 1; i < 9; i++)
                {
                    switch (i)
                    {
                        case 1: Properties.Settings.Default.AccentOne = GlobalDependencies.defaultSchemes[schemeIndex, i-1]; break;
                        case 2: Properties.Settings.Default.AccentTwo = GlobalDependencies.defaultSchemes[schemeIndex, i-1]; break;
                        case 3: Properties.Settings.Default.AccentThree = GlobalDependencies.defaultSchemes[schemeIndex, i-1]; break;
                        case 4: Properties.Settings.Default.AccentFour = GlobalDependencies.defaultSchemes[schemeIndex, i-1]; break;
                        case 5: Properties.Settings.Default.AccentFive = GlobalDependencies.defaultSchemes[schemeIndex, i-1]; break;
                        case 6: Properties.Settings.Default.AccentSix = GlobalDependencies.defaultSchemes[schemeIndex, i - 1]; break;
                        case 7: Properties.Settings.Default.AccentSeven = GlobalDependencies.defaultSchemes[schemeIndex, i - 1]; break;
                        case 8: Properties.Settings.Default.AccentEight = GlobalDependencies.defaultSchemes[schemeIndex, i - 1]; break;
                    }
                    Properties.Settings.Default.Save();
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return;
            }
        }
    }
}

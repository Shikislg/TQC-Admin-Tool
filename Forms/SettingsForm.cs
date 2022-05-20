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

        //Forms
        readonly S_Points sPointsForm = new S_Points();
        public readonly S_Layout sLayout = new S_Layout();
        readonly S_Startup sStartup = new S_Startup();
        public SettingsForm()
        {
            InitializeComponent();
            LoadForm(sPointsForm);
        }
        #region Events        
        private void ReloadSourceButton_Click(object sender, EventArgs e)
        {
            ReloadTextFieldSources();
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {;
                if (int.TryParse(sPointsForm.MinPointsTf.Text, out int a))
                {
                    Rules.SetMinPoints(a);
                }
                if (int.TryParse(sPointsForm.CheckDateFrequencyBox.Text, out int b))
                {
                    Rules.SetCheckDateFrequency(b);
                }
                Rules.SetPointHandlingMode(sPointsForm.PointModeBox.SelectedIndex);
                Rules.SetPullDataOnOpen(sStartup.PullDataOnStartup.SelectedIndex);

                Properties.Settings.Default.Save();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Input", "Error");
            }
        }
        
        private void ActivityCheckTrigger_Click(object sender, EventArgs e)
        {
            LoadForm(sPointsForm);
        }
        private void LayoutTrigger_Click(object sender, EventArgs e)
        {
            LoadForm(sLayout);
        }
        private void StartupTrigger_Click(object sender, EventArgs e)
        {
            LoadForm(sStartup);
        }
        #endregion
        #region Utility Methods
        public void LoadForm(object Form)
        {
            if (!Form.GetType().IsInstanceOfType(new LoginForm().GetType()))
            {
                GlobalDependencies.currentForm = Form as Form;
            }
            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);
            }
            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(form);
            this.MainPanel.Tag = form;
            form.Show();
        }
        private void ReloadTextFieldSources()
        {
            GlobalDependencies.memberTags.Clear();
            GlobalDependencies.dashboardInstance.progressBar.Visible = true;
            double i = 0;
            foreach(Member member in GlobalDependencies.members)
            {
                double progress = (i / (double)GlobalDependencies.members.Count) * 100;
                GlobalDependencies.dashboardInstance.progressBar.Value = (int)progress;
                GlobalDependencies.memberTags.Add(member.DiscordTag.Trim());
                i++;
            }
            GlobalDependencies.dashboardInstance.progressBar.Value = 0;
            GlobalDependencies.dashboardInstance.progressBar.Visible = false;
            GlobalDependencies.eventManagerInstance.participants.AddAltTf.AutoCompleteCustomSource = GlobalDependencies.memberTags;
            GlobalDependencies.eventManagerInstance.participants.AddAltTf.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            GlobalDependencies.eventManagerInstance.participants.AddAttendeeTf.AutoCompleteCustomSource = GlobalDependencies.memberTags;
            GlobalDependencies.eventManagerInstance.participants.AddAttendeeTf.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            GlobalDependencies.eventManagerInstance.participants.AddNoShowTf.AutoCompleteCustomSource = GlobalDependencies.memberTags;
            GlobalDependencies.eventManagerInstance.participants.AddNoShowTf.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            GlobalDependencies.eventManagerInstance.participants.HostTf.AutoCompleteCustomSource = GlobalDependencies.memberTags;
            GlobalDependencies.eventManagerInstance.participants.HostTf.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            GlobalDependencies.eventManagerInstance.SearchTf.AutoCompleteCustomSource = GlobalDependencies.eventManagerInstance.eventTypes;
            GlobalDependencies.eventManagerInstance.SearchTf.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            GlobalDependencies.editMembersInstance.discordTagTf.AutoCompleteCustomSource = GlobalDependencies.memberTags;
            GlobalDependencies.editMembersInstance.discordTagTf.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            GlobalDependencies.mStatsInstance.NameSearchTf.AutoCompleteCustomSource = GlobalDependencies.memberTags;
            GlobalDependencies.mStatsInstance.NameSearchTf.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            GlobalDependencies.mStatsInstance.ClanSearchTf.AutoCompleteCustomSource = GlobalDependencies.clanTags;
            GlobalDependencies.mStatsInstance.ClanSearchTf.AutoCompleteMode = AutoCompleteMode.SuggestAppend;

        }
        #endregion
    }
}

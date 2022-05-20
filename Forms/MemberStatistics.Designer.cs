
namespace Dashboard
{
    partial class MemberStatistics
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button SearchButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberStatistics));
            this.label2 = new System.Windows.Forms.Label();
            this.memberStats = new System.Windows.Forms.Label();
            this.ClanSearchTf = new System.Windows.Forms.TextBox();
            this.MStats = new System.Windows.Forms.Panel();
            this.CheckDateFilter = new System.Windows.Forms.CheckBox();
            this.NameSearchTf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QuestionButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.CheckedAllMembersButton = new System.Windows.Forms.ToolStripButton();
            this.CheckedSelectedMemberButton = new System.Windows.Forms.ToolStripButton();
            this.ResultBox = new System.Windows.Forms.ListBox();
            this.PointFilter = new System.Windows.Forms.CheckBox();
            this.ListBoxRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.userProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListBoxMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.userCheckedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedAllUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            SearchButton = new System.Windows.Forms.Button();
            this.MStats.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.ListBoxRightClick.SuspendLayout();
            this.ListBoxMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            SearchButton.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            SearchButton.CausesValidation = false;
            SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            SearchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SearchButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SearchButton.ForeColor = System.Drawing.Color.White;
            SearchButton.Location = new System.Drawing.Point(12, 134);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new System.Drawing.Size(138, 52);
            SearchButton.TabIndex = 6;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = false;
            SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.label2.Location = new System.Drawing.Point(17, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clan";
            // 
            // memberStats
            // 
            this.memberStats.AutoSize = true;
            this.memberStats.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberStats.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.memberStats.Location = new System.Drawing.Point(4, 0);
            this.memberStats.Name = "memberStats";
            this.memberStats.Size = new System.Drawing.Size(333, 50);
            this.memberStats.TabIndex = 2;
            this.memberStats.Text = "Member Statistics";
            // 
            // ClanSearchTf
            // 
            this.ClanSearchTf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ClanSearchTf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.ClanSearchTf.BackColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.ClanSearchTf.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClanSearchTf.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.ClanSearchTf.Location = new System.Drawing.Point(66, 44);
            this.ClanSearchTf.Name = "ClanSearchTf";
            this.ClanSearchTf.Size = new System.Drawing.Size(422, 33);
            this.ClanSearchTf.TabIndex = 5;
            // 
            // MStats
            // 
            this.MStats.BackColor = global::Dashboard.Properties.Settings.Default.AccentEight;
            this.MStats.Controls.Add(this.CheckDateFilter);
            this.MStats.Controls.Add(this.NameSearchTf);
            this.MStats.Controls.Add(this.label1);
            this.MStats.Controls.Add(this.QuestionButton);
            this.MStats.Controls.Add(this.comboBox1);
            this.MStats.Controls.Add(this.flowLayoutPanel1);
            this.MStats.Controls.Add(this.PointFilter);
            this.MStats.Controls.Add(this.ClanSearchTf);
            this.MStats.Controls.Add(this.memberStats);
            this.MStats.Controls.Add(this.label2);
            this.MStats.Controls.Add(SearchButton);
            this.MStats.Location = new System.Drawing.Point(0, 0);
            this.MStats.Name = "MStats";
            this.MStats.Size = new System.Drawing.Size(705, 574);
            this.MStats.TabIndex = 11;
            // 
            // CheckDateFilter
            // 
            this.CheckDateFilter.AutoSize = true;
            this.CheckDateFilter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckDateFilter.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.CheckDateFilter.Location = new System.Drawing.Point(518, 87);
            this.CheckDateFilter.Name = "CheckDateFilter";
            this.CheckDateFilter.Size = new System.Drawing.Size(175, 29);
            this.CheckDateFilter.TabIndex = 25;
            this.CheckDateFilter.Text = "CheckDate Filter";
            this.CheckDateFilter.UseVisualStyleBackColor = true;
            // 
            // NameSearchTf
            // 
            this.NameSearchTf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NameSearchTf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NameSearchTf.BackColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.NameSearchTf.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameSearchTf.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.NameSearchTf.Location = new System.Drawing.Point(66, 83);
            this.NameSearchTf.Name = "NameSearchTf";
            this.NameSearchTf.Size = new System.Drawing.Size(422, 33);
            this.NameSearchTf.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.label1.Location = new System.Drawing.Point(4, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name";
            // 
            // QuestionButton
            // 
            this.QuestionButton.BackColor = System.Drawing.Color.Black;
            this.QuestionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuestionButton.BackgroundImage")));
            this.QuestionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuestionButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.QuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestionButton.Location = new System.Drawing.Point(677, 3);
            this.QuestionButton.Name = "QuestionButton";
            this.QuestionButton.Size = new System.Drawing.Size(25, 25);
            this.QuestionButton.TabIndex = 22;
            this.QuestionButton.UseVisualStyleBackColor = false;
            this.QuestionButton.Click += new System.EventHandler(this.QuestionButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Points (High>Low)",
            "Points (Low>High)",
            "Check Date (New>Old)",
            "Check Date (Old>New)",
            "Join Date(New>Old)",
            "Join Date(Old>New)",
            "Member Type(Founder>Beginner)",
            "Member Type(Beginner>Founder)"});
            this.comboBox1.Location = new System.Drawing.Point(201, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(287, 29);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.toolStrip1);
            this.flowLayoutPanel1.Controls.Add(this.ResultBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 192);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(690, 362);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.toolStrip1.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CheckedAllMembersButton,
            this.CheckedSelectedMemberButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(283, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // CheckedAllMembersButton
            // 
            this.CheckedAllMembersButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CheckedAllMembersButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckedAllMembersButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.CheckedAllMembersButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CheckedAllMembersButton.Name = "CheckedAllMembersButton";
            this.CheckedAllMembersButton.Size = new System.Drawing.Size(132, 22);
            this.CheckedAllMembersButton.Text = "Checked All Members";
            this.CheckedAllMembersButton.Click += new System.EventHandler(this.CheckedAllMembersButton_Click);
            // 
            // CheckedSelectedMemberButton
            // 
            this.CheckedSelectedMemberButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.CheckedSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckedSelectedMemberButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.CheckedSelectedMemberButton.Image = ((System.Drawing.Image)(resources.GetObject("CheckedSelectedMemberButton.Image")));
            this.CheckedSelectedMemberButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CheckedSelectedMemberButton.Name = "CheckedSelectedMemberButton";
            this.CheckedSelectedMemberButton.Size = new System.Drawing.Size(148, 22);
            this.CheckedSelectedMemberButton.Text = "Check Selected Member";
            this.CheckedSelectedMemberButton.Click += new System.EventHandler(this.CheckedSelectedMemberButton_Click);
            // 
            // ResultBox
            // 
            this.ResultBox.BackColor = global::Dashboard.Properties.Settings.Default.AccentEight;
            this.ResultBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ResultBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultBox.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.ResultBox.FormattingEnabled = true;
            this.ResultBox.ItemHeight = 19;
            this.ResultBox.Location = new System.Drawing.Point(3, 28);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(678, 304);
            this.ResultBox.TabIndex = 21;
            this.ResultBox.SelectedIndexChanged += new System.EventHandler(this.ResultBox_SelectedIndexChanged);
            this.ResultBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ResultBox_MouseDown);
            // 
            // PointFilter
            // 
            this.PointFilter.AutoSize = true;
            this.PointFilter.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointFilter.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.PointFilter.Location = new System.Drawing.Point(518, 46);
            this.PointFilter.Name = "PointFilter";
            this.PointFilter.Size = new System.Drawing.Size(128, 29);
            this.PointFilter.TabIndex = 19;
            this.PointFilter.Text = "Point Filter";
            this.PointFilter.UseVisualStyleBackColor = true;
            // 
            // ListBoxRightClick
            // 
            this.ListBoxRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userProfileToolStripMenuItem});
            this.ListBoxRightClick.Name = "ListBoxRightClick";
            this.ListBoxRightClick.Size = new System.Drawing.Size(181, 48);
            // 
            // userProfileToolStripMenuItem
            // 
            this.userProfileToolStripMenuItem.Name = "userProfileToolStripMenuItem";
            this.userProfileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.userProfileToolStripMenuItem.Text = "User Profile";
            this.userProfileToolStripMenuItem.Click += new System.EventHandler(this.userProfileToolStripMenuItem_Click);
            // 
            // ListBoxMenuStrip
            // 
            this.ListBoxMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userCheckedToolStripMenuItem,
            this.checkedAllUsersToolStripMenuItem});
            this.ListBoxMenuStrip.Name = "ListBoxMenuStrip";
            this.ListBoxMenuStrip.Size = new System.Drawing.Size(169, 48);
            // 
            // userCheckedToolStripMenuItem
            // 
            this.userCheckedToolStripMenuItem.Name = "userCheckedToolStripMenuItem";
            this.userCheckedToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.userCheckedToolStripMenuItem.Text = "User Checked";
            // 
            // checkedAllUsersToolStripMenuItem
            // 
            this.checkedAllUsersToolStripMenuItem.Name = "checkedAllUsersToolStripMenuItem";
            this.checkedAllUsersToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.checkedAllUsersToolStripMenuItem.Text = "Checked All Users";
            // 
            // MemberStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 553);
            this.Controls.Add(this.MStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberStatistics";
            this.MStats.ResumeLayout(false);
            this.MStats.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ListBoxRightClick.ResumeLayout(false);
            this.ListBoxMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label memberStats;
        private System.Windows.Forms.Panel MStats;
        private System.Windows.Forms.CheckBox PointFilter;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ListBox ResultBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ContextMenuStrip ListBoxMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem userCheckedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedAllUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton CheckedAllMembersButton;
        private System.Windows.Forms.ToolStripButton CheckedSelectedMemberButton;
        private System.Windows.Forms.Button QuestionButton;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox ClanSearchTf;
        public System.Windows.Forms.TextBox NameSearchTf;
        private System.Windows.Forms.CheckBox CheckDateFilter;
        private System.Windows.Forms.ContextMenuStrip ListBoxRightClick;
        private System.Windows.Forms.ToolStripMenuItem userProfileToolStripMenuItem;
    }
}
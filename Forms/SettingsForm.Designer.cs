
namespace Dashboard
{
    partial class SettingsForm
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
            System.Windows.Forms.Button SaveButton;
            this.memberStats = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.MinPointsTf = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DiscordTagCheck = new System.Windows.Forms.CheckBox();
            this.PointsCheck = new System.Windows.Forms.CheckBox();
            this.EventPCheck = new System.Windows.Forms.CheckBox();
            this.EventACheck = new System.Windows.Forms.CheckBox();
            this.EventMCheck = new System.Windows.Forms.CheckBox();
            this.JoinDateCheck = new System.Windows.Forms.CheckBox();
            this.LastCheckCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PointModeBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SchemePanel = new System.Windows.Forms.Panel();
            this.AccentEightLbl = new System.Windows.Forms.Panel();
            this.AccentFourLbl = new System.Windows.Forms.Panel();
            this.AccentSevenLbl = new System.Windows.Forms.Panel();
            this.AccentThreeLbl = new System.Windows.Forms.Panel();
            this.AccentSixLbl = new System.Windows.Forms.Panel();
            this.AccentFiveLbl = new System.Windows.Forms.Panel();
            this.AccentTwoLbl = new System.Windows.Forms.Panel();
            this.AccentOneLbl = new System.Windows.Forms.Panel();
            this.SchemeSelector = new System.Windows.Forms.ComboBox();
            this.AccentOneDialog = new System.Windows.Forms.ColorDialog();
            this.AccentTwo = new System.Windows.Forms.ColorDialog();
            this.AccentThree = new System.Windows.Forms.ColorDialog();
            this.AccentFour = new System.Windows.Forms.ColorDialog();
            this.AccentFive = new System.Windows.Forms.ColorDialog();
            this.AccentSix = new System.Windows.Forms.ColorDialog();
            this.AccentSeven = new System.Windows.Forms.ColorDialog();
            this.AccentEight = new System.Windows.Forms.ColorDialog();
            SaveButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SchemePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            SaveButton.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            SaveButton.CausesValidation = false;
            SaveButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            SaveButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            SaveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            SaveButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            SaveButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            SaveButton.Location = new System.Drawing.Point(525, 475);
            SaveButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new System.Drawing.Size(161, 52);
            SaveButton.TabIndex = 7;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // memberStats
            // 
            this.memberStats.AutoSize = true;
            this.memberStats.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberStats.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.memberStats.Location = new System.Drawing.Point(4, 0);
            this.memberStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberStats.Name = "memberStats";
            this.memberStats.Size = new System.Drawing.Size(163, 50);
            this.memberStats.TabIndex = 3;
            this.memberStats.Text = "Settings";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.MinPointsTf);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.DiscordTagCheck);
            this.flowLayoutPanel1.Controls.Add(this.PointsCheck);
            this.flowLayoutPanel1.Controls.Add(this.EventPCheck);
            this.flowLayoutPanel1.Controls.Add(this.EventACheck);
            this.flowLayoutPanel1.Controls.Add(this.EventMCheck);
            this.flowLayoutPanel1.Controls.Add(this.JoinDateCheck);
            this.flowLayoutPanel1.Controls.Add(this.LastCheckCheck);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.PointModeBox);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.SchemePanel);
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 61);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(678, 484);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(754, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Minimum Required Points";
            // 
            // MinPointsTf
            // 
            this.MinPointsTf.BackColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.MinPointsTf.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinPointsTf.Location = new System.Drawing.Point(4, 26);
            this.MinPointsTf.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinPointsTf.Mask = "00000";
            this.MinPointsTf.Name = "MinPointsTf";
            this.MinPointsTf.Size = new System.Drawing.Size(247, 33);
            this.MinPointsTf.TabIndex = 1;
            this.MinPointsTf.Text = "00000";
            this.MinPointsTf.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(754, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Member Statistics Layout";
            // 
            // DiscordTagCheck
            // 
            this.DiscordTagCheck.AutoSize = true;
            this.DiscordTagCheck.Checked = true;
            this.DiscordTagCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.DiscordTagCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscordTagCheck.Location = new System.Drawing.Point(4, 88);
            this.DiscordTagCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DiscordTagCheck.Name = "DiscordTagCheck";
            this.DiscordTagCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DiscordTagCheck.Size = new System.Drawing.Size(119, 24);
            this.DiscordTagCheck.TabIndex = 3;
            this.DiscordTagCheck.Text = "DiscordTag";
            this.DiscordTagCheck.UseVisualStyleBackColor = true;
            // 
            // PointsCheck
            // 
            this.PointsCheck.AutoSize = true;
            this.PointsCheck.Checked = true;
            this.PointsCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PointsCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsCheck.Location = new System.Drawing.Point(131, 88);
            this.PointsCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PointsCheck.Name = "PointsCheck";
            this.PointsCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PointsCheck.Size = new System.Drawing.Size(78, 24);
            this.PointsCheck.TabIndex = 4;
            this.PointsCheck.Text = "Points";
            this.PointsCheck.UseVisualStyleBackColor = true;
            // 
            // EventPCheck
            // 
            this.EventPCheck.AutoSize = true;
            this.EventPCheck.Checked = true;
            this.EventPCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EventPCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventPCheck.Location = new System.Drawing.Point(217, 88);
            this.EventPCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EventPCheck.Name = "EventPCheck";
            this.EventPCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EventPCheck.Size = new System.Drawing.Size(146, 24);
            this.EventPCheck.TabIndex = 5;
            this.EventPCheck.Text = "Events: Joined";
            this.EventPCheck.UseVisualStyleBackColor = true;
            // 
            // EventACheck
            // 
            this.EventACheck.AutoSize = true;
            this.EventACheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventACheck.Location = new System.Drawing.Point(371, 88);
            this.EventACheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EventACheck.Name = "EventACheck";
            this.EventACheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EventACheck.Size = new System.Drawing.Size(70, 24);
            this.EventACheck.TabIndex = 6;
            this.EventACheck.Text = "Alted";
            this.EventACheck.UseVisualStyleBackColor = true;
            // 
            // EventMCheck
            // 
            this.EventMCheck.AutoSize = true;
            this.EventMCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventMCheck.Location = new System.Drawing.Point(449, 88);
            this.EventMCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.EventMCheck.Name = "EventMCheck";
            this.EventMCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.EventMCheck.Size = new System.Drawing.Size(84, 24);
            this.EventMCheck.TabIndex = 7;
            this.EventMCheck.Text = "Missed";
            this.EventMCheck.UseVisualStyleBackColor = true;
            // 
            // JoinDateCheck
            // 
            this.JoinDateCheck.AutoSize = true;
            this.JoinDateCheck.Checked = true;
            this.JoinDateCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.JoinDateCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JoinDateCheck.Location = new System.Drawing.Point(541, 88);
            this.JoinDateCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.JoinDateCheck.Name = "JoinDateCheck";
            this.JoinDateCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.JoinDateCheck.Size = new System.Drawing.Size(100, 24);
            this.JoinDateCheck.TabIndex = 8;
            this.JoinDateCheck.Text = "JoinDate";
            this.JoinDateCheck.UseVisualStyleBackColor = true;
            // 
            // LastCheckCheck
            // 
            this.LastCheckCheck.AutoSize = true;
            this.LastCheckCheck.Checked = true;
            this.LastCheckCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LastCheckCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastCheckCheck.Location = new System.Drawing.Point(4, 118);
            this.LastCheckCheck.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.LastCheckCheck.Name = "LastCheckCheck";
            this.LastCheckCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LastCheckCheck.Size = new System.Drawing.Size(118, 24);
            this.LastCheckCheck.TabIndex = 9;
            this.LastCheckCheck.Text = "Last Check";
            this.LastCheckCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(754, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Point handling mode";
            // 
            // PointModeBox
            // 
            this.PointModeBox.BackColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.PointModeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PointModeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PointModeBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointModeBox.ForeColor = System.Drawing.Color.Black;
            this.PointModeBox.FormattingEnabled = true;
            this.PointModeBox.Items.AddRange(new object[] {
            "Default",
            "Majestic"});
            this.PointModeBox.Location = new System.Drawing.Point(4, 171);
            this.PointModeBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PointModeBox.Name = "PointModeBox";
            this.PointModeBox.Size = new System.Drawing.Size(205, 29);
            this.PointModeBox.TabIndex = 22;
            this.PointModeBox.SelectedIndexChanged += new System.EventHandler(this.PointModeBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(754, 23);
            this.label4.TabIndex = 23;
            this.label4.Text = "Color schemes";
            // 
            // SchemePanel
            // 
            this.SchemePanel.Controls.Add(this.AccentEightLbl);
            this.SchemePanel.Controls.Add(this.AccentFourLbl);
            this.SchemePanel.Controls.Add(this.AccentSevenLbl);
            this.SchemePanel.Controls.Add(this.AccentThreeLbl);
            this.SchemePanel.Controls.Add(this.AccentSixLbl);
            this.SchemePanel.Controls.Add(this.AccentFiveLbl);
            this.SchemePanel.Controls.Add(this.AccentTwoLbl);
            this.SchemePanel.Controls.Add(this.AccentOneLbl);
            this.SchemePanel.Controls.Add(this.SchemeSelector);
            this.SchemePanel.Location = new System.Drawing.Point(3, 229);
            this.SchemePanel.Name = "SchemePanel";
            this.SchemePanel.Size = new System.Drawing.Size(670, 108);
            this.SchemePanel.TabIndex = 24;
            // 
            // AccentEightLbl
            // 
            this.AccentEightLbl.BackColor = global::Dashboard.Properties.Settings.Default.AccentEight;
            this.AccentEightLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccentEightLbl.Location = new System.Drawing.Point(223, 0);
            this.AccentEightLbl.Name = "AccentEightLbl";
            this.AccentEightLbl.Size = new System.Drawing.Size(25, 25);
            this.AccentEightLbl.TabIndex = 7;
            this.AccentEightLbl.Click += new System.EventHandler(this.AccentEightLbl_Click);
            // 
            // AccentFourLbl
            // 
            this.AccentFourLbl.BackColor = global::Dashboard.Properties.Settings.Default.AccentFour;
            this.AccentFourLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccentFourLbl.Location = new System.Drawing.Point(99, 0);
            this.AccentFourLbl.Name = "AccentFourLbl";
            this.AccentFourLbl.Size = new System.Drawing.Size(25, 25);
            this.AccentFourLbl.TabIndex = 3;
            this.AccentFourLbl.Click += new System.EventHandler(this.ColorFour_Click);
            // 
            // AccentSevenLbl
            // 
            this.AccentSevenLbl.BackColor = global::Dashboard.Properties.Settings.Default.AccentSeven;
            this.AccentSevenLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccentSevenLbl.Location = new System.Drawing.Point(192, 0);
            this.AccentSevenLbl.Name = "AccentSevenLbl";
            this.AccentSevenLbl.Size = new System.Drawing.Size(25, 25);
            this.AccentSevenLbl.TabIndex = 6;
            this.AccentSevenLbl.Click += new System.EventHandler(this.ColorSeven_Click);
            // 
            // AccentThreeLbl
            // 
            this.AccentThreeLbl.BackColor = global::Dashboard.Properties.Settings.Default.AccentThree;
            this.AccentThreeLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccentThreeLbl.Location = new System.Drawing.Point(68, 0);
            this.AccentThreeLbl.Name = "AccentThreeLbl";
            this.AccentThreeLbl.Size = new System.Drawing.Size(25, 25);
            this.AccentThreeLbl.TabIndex = 2;
            this.AccentThreeLbl.Click += new System.EventHandler(this.ColorThree_Click);
            // 
            // AccentSixLbl
            // 
            this.AccentSixLbl.BackColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.AccentSixLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccentSixLbl.Location = new System.Drawing.Point(161, 0);
            this.AccentSixLbl.Name = "AccentSixLbl";
            this.AccentSixLbl.Size = new System.Drawing.Size(25, 25);
            this.AccentSixLbl.TabIndex = 5;
            this.AccentSixLbl.Click += new System.EventHandler(this.ColorSix_Click);
            // 
            // AccentFiveLbl
            // 
            this.AccentFiveLbl.BackColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.AccentFiveLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccentFiveLbl.Location = new System.Drawing.Point(130, 0);
            this.AccentFiveLbl.Name = "AccentFiveLbl";
            this.AccentFiveLbl.Size = new System.Drawing.Size(25, 25);
            this.AccentFiveLbl.TabIndex = 4;
            this.AccentFiveLbl.Click += new System.EventHandler(this.ColorFive_Click);
            // 
            // AccentTwoLbl
            // 
            this.AccentTwoLbl.BackColor = global::Dashboard.Properties.Settings.Default.AccentTwo;
            this.AccentTwoLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccentTwoLbl.Location = new System.Drawing.Point(37, 0);
            this.AccentTwoLbl.Name = "AccentTwoLbl";
            this.AccentTwoLbl.Size = new System.Drawing.Size(25, 25);
            this.AccentTwoLbl.TabIndex = 1;
            this.AccentTwoLbl.Click += new System.EventHandler(this.ColorTwo_Click);
            // 
            // AccentOneLbl
            // 
            this.AccentOneLbl.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            this.AccentOneLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AccentOneLbl.Location = new System.Drawing.Point(6, 0);
            this.AccentOneLbl.Name = "AccentOneLbl";
            this.AccentOneLbl.Size = new System.Drawing.Size(25, 25);
            this.AccentOneLbl.TabIndex = 0;
            this.AccentOneLbl.Click += new System.EventHandler(this.ColorOne_Click);
            // 
            // SchemeSelector
            // 
            this.SchemeSelector.BackColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.SchemeSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SchemeSelector.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SchemeSelector.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchemeSelector.ForeColor = System.Drawing.Color.Black;
            this.SchemeSelector.FormattingEnabled = true;
            this.SchemeSelector.Items.AddRange(new object[] {
            "Default",
            "Unsaturated Dark mode"});
            this.SchemeSelector.Location = new System.Drawing.Point(4, 31);
            this.SchemeSelector.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SchemeSelector.Name = "SchemeSelector";
            this.SchemeSelector.Size = new System.Drawing.Size(205, 29);
            this.SchemeSelector.TabIndex = 25;
            this.SchemeSelector.SelectedIndexChanged += new System.EventHandler(this.SchemeSelector_SelectedIndexChanged);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Dashboard.Properties.Settings.Default.AccentEight;
            this.ClientSize = new System.Drawing.Size(704, 557);
            this.Controls.Add(SaveButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.memberStats);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.SchemePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memberStats;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox MinPointsTf;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.CheckBox DiscordTagCheck;
        public System.Windows.Forms.CheckBox PointsCheck;
        public System.Windows.Forms.CheckBox EventPCheck;
        public System.Windows.Forms.CheckBox EventACheck;
        public System.Windows.Forms.CheckBox EventMCheck;
        public System.Windows.Forms.CheckBox JoinDateCheck;
        public System.Windows.Forms.CheckBox LastCheckCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColorDialog AccentOneDialog;
        private System.Windows.Forms.ColorDialog AccentTwo;
        private System.Windows.Forms.ColorDialog AccentThree;
        private System.Windows.Forms.ColorDialog AccentFour;
        private System.Windows.Forms.ColorDialog AccentFive;
        private System.Windows.Forms.ColorDialog AccentSix;
        private System.Windows.Forms.ColorDialog AccentSeven;
        private System.Windows.Forms.Panel SchemePanel;
        private System.Windows.Forms.Panel AccentEightLbl;
        private System.Windows.Forms.Panel AccentFourLbl;
        private System.Windows.Forms.Panel AccentSevenLbl;
        private System.Windows.Forms.Panel AccentThreeLbl;
        private System.Windows.Forms.Panel AccentSixLbl;
        private System.Windows.Forms.Panel AccentFiveLbl;
        private System.Windows.Forms.Panel AccentTwoLbl;
        private System.Windows.Forms.Panel AccentOneLbl;
        private System.Windows.Forms.ComboBox PointModeBox;
        private System.Windows.Forms.ColorDialog AccentEight;
        private System.Windows.Forms.ComboBox SchemeSelector;
    }
}
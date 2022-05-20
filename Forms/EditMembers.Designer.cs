
namespace Dashboard
{
    partial class EditMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMembers));
            this.AMemberPanel = new System.Windows.Forms.Panel();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.AddCheck = new System.Windows.Forms.CheckBox();
            this.AbsenceCheck = new System.Windows.Forms.CheckBox();
            this.NotesTf = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.PointsTf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TagLabel = new System.Windows.Forms.Label();
            this.DiscordTagLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.QuestionButton = new System.Windows.Forms.Button();
            this.RemoveMemberButton = new System.Windows.Forms.Button();
            this.AddMemberButton = new System.Windows.Forms.Button();
            this.discordTagTf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AMemberPanel.SuspendLayout();
            this.EditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AMemberPanel
            // 
            this.AMemberPanel.BackColor = global::Dashboard.Properties.Settings.Default.AccentEight;
            this.AMemberPanel.Controls.Add(this.EditPanel);
            this.AMemberPanel.Controls.Add(this.QuestionButton);
            this.AMemberPanel.Controls.Add(this.RemoveMemberButton);
            this.AMemberPanel.Controls.Add(this.AddMemberButton);
            this.AMemberPanel.Controls.Add(this.discordTagTf);
            this.AMemberPanel.Controls.Add(this.label6);
            this.AMemberPanel.Controls.Add(this.label5);
            this.AMemberPanel.Location = new System.Drawing.Point(0, 0);
            this.AMemberPanel.Name = "AMemberPanel";
            this.AMemberPanel.Size = new System.Drawing.Size(704, 557);
            this.AMemberPanel.TabIndex = 11;
            // 
            // EditPanel
            // 
            this.EditPanel.Controls.Add(this.AddCheck);
            this.EditPanel.Controls.Add(this.AbsenceCheck);
            this.EditPanel.Controls.Add(this.NotesTf);
            this.EditPanel.Controls.Add(this.label4);
            this.EditPanel.Controls.Add(this.dateTimePicker);
            this.EditPanel.Controls.Add(this.label3);
            this.EditPanel.Controls.Add(this.PointsTf);
            this.EditPanel.Controls.Add(this.label2);
            this.EditPanel.Controls.Add(this.TagLabel);
            this.EditPanel.Controls.Add(this.DiscordTagLabel);
            this.EditPanel.Controls.Add(this.SaveButton);
            this.EditPanel.Location = new System.Drawing.Point(12, 153);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(679, 390);
            this.EditPanel.TabIndex = 25;
            this.EditPanel.Visible = false;
            // 
            // AddCheck
            // 
            this.AddCheck.AutoSize = true;
            this.AddCheck.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCheck.Location = new System.Drawing.Point(321, 27);
            this.AddCheck.Name = "AddCheck";
            this.AddCheck.Size = new System.Drawing.Size(100, 21);
            this.AddCheck.TabIndex = 34;
            this.AddCheck.Text = "Add Points";
            this.AddCheck.UseVisualStyleBackColor = true;
            // 
            // AbsenceCheck
            // 
            this.AbsenceCheck.AutoSize = true;
            this.AbsenceCheck.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AbsenceCheck.Location = new System.Drawing.Point(364, 141);
            this.AbsenceCheck.Name = "AbsenceCheck";
            this.AbsenceCheck.Size = new System.Drawing.Size(109, 21);
            this.AbsenceCheck.TabIndex = 33;
            this.AbsenceCheck.Text = "Set Absence";
            this.AbsenceCheck.UseVisualStyleBackColor = true;
            // 
            // NotesTf
            // 
            this.NotesTf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.NotesTf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.NotesTf.BackColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.NotesTf.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesTf.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.NotesTf.Location = new System.Drawing.Point(121, 61);
            this.NotesTf.Multiline = true;
            this.NotesTf.Name = "NotesTf";
            this.NotesTf.Size = new System.Drawing.Size(194, 72);
            this.NotesTf.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(46, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Notes";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker.Location = new System.Drawing.Point(121, 139);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(237, 25);
            this.dateTimePicker.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(29, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "Absence";
            // 
            // PointsTf
            // 
            this.PointsTf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.PointsTf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.PointsTf.BackColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.PointsTf.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PointsTf.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.PointsTf.Location = new System.Drawing.Point(121, 22);
            this.PointsTf.Name = "PointsTf";
            this.PointsTf.Size = new System.Drawing.Size(194, 33);
            this.PointsTf.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(46, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Points";
            // 
            // TagLabel
            // 
            this.TagLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.TagLabel.Location = new System.Drawing.Point(3, -4);
            this.TagLabel.Name = "TagLabel";
            this.TagLabel.Size = new System.Drawing.Size(298, 23);
            this.TagLabel.TabIndex = 25;
            this.TagLabel.Text = "Discord Tag";
            // 
            // DiscordTagLabel
            // 
            this.DiscordTagLabel.AutoSize = true;
            this.DiscordTagLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.DiscordTagLabel.Location = new System.Drawing.Point(3, 0);
            this.DiscordTagLabel.Name = "DiscordTagLabel";
            this.DiscordTagLabel.Size = new System.Drawing.Size(0, 25);
            this.DiscordTagLabel.TabIndex = 0;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 13.25F, System.Drawing.FontStyle.Bold);
            this.SaveButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.SaveButton.Location = new System.Drawing.Point(8, 170);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(138, 52);
            this.SaveButton.TabIndex = 24;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // QuestionButton
            // 
            this.QuestionButton.BackColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.QuestionButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuestionButton.BackgroundImage")));
            this.QuestionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.QuestionButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.QuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestionButton.Location = new System.Drawing.Point(676, 3);
            this.QuestionButton.Name = "QuestionButton";
            this.QuestionButton.Size = new System.Drawing.Size(25, 25);
            this.QuestionButton.TabIndex = 23;
            this.QuestionButton.UseVisualStyleBackColor = false;
            // 
            // RemoveMemberButton
            // 
            this.RemoveMemberButton.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            this.RemoveMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveMemberButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveMemberButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.RemoveMemberButton.Location = new System.Drawing.Point(171, 95);
            this.RemoveMemberButton.Name = "RemoveMemberButton";
            this.RemoveMemberButton.Size = new System.Drawing.Size(142, 52);
            this.RemoveMemberButton.TabIndex = 13;
            this.RemoveMemberButton.Text = "Remove Member";
            this.RemoveMemberButton.UseVisualStyleBackColor = false;
            this.RemoveMemberButton.Click += new System.EventHandler(this.RemoveMemberButton_Click);
            // 
            // AddMemberButton
            // 
            this.AddMemberButton.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            this.AddMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddMemberButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddMemberButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.AddMemberButton.Location = new System.Drawing.Point(12, 95);
            this.AddMemberButton.Name = "AddMemberButton";
            this.AddMemberButton.Size = new System.Drawing.Size(138, 52);
            this.AddMemberButton.TabIndex = 12;
            this.AddMemberButton.Text = "Find Member";
            this.AddMemberButton.UseVisualStyleBackColor = false;
            this.AddMemberButton.Click += new System.EventHandler(this.EditMemberButton_Click);
            // 
            // discordTagTf
            // 
            this.discordTagTf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.discordTagTf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.discordTagTf.BackColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.discordTagTf.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.discordTagTf.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.discordTagTf.Location = new System.Drawing.Point(150, 47);
            this.discordTagTf.Name = "discordTagTf";
            this.discordTagTf.Size = new System.Drawing.Size(490, 33);
            this.discordTagTf.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.label6.Location = new System.Drawing.Point(7, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "Discord Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(409, 50);
            this.label5.TabIndex = 0;
            this.label5.Text = "Edit/RemoveMembers";
            // 
            // EditMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 555);
            this.Controls.Add(this.AMemberPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditMembers";
            this.Text = "Edit/Remove Members";
            this.AMemberPanel.ResumeLayout(false);
            this.AMemberPanel.PerformLayout();
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AMemberPanel;
        private System.Windows.Forms.Button RemoveMemberButton;
        private System.Windows.Forms.Button AddMemberButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button QuestionButton;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label DiscordTagLabel;
        private System.Windows.Forms.Label TagLabel;
        private System.Windows.Forms.TextBox NotesTf;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PointsTf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox AbsenceCheck;
        private System.Windows.Forms.CheckBox AddCheck;
        public System.Windows.Forms.TextBox discordTagTf;
    }
}
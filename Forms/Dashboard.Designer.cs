
using System;

namespace Dashboard
{
    partial class Dashboard
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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.DashboardPanel = new System.Windows.Forms.Panel();
            this.ResetButton = new System.Windows.Forms.Button();
            this.savePanel = new System.Windows.Forms.Panel();
            this.NavPanel = new System.Windows.Forms.Panel();
            this.SettingsButton = new System.Windows.Forms.Button();
            this.AMemberButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.EManagerButton = new System.Windows.Forms.Button();
            this.MStatsButton = new System.Windows.Forms.Button();
            this.UserDisplayPanel = new System.Windows.Forms.Panel();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.LoginButton = new System.Windows.Forms.Button();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MemberDisplayLabel = new System.Windows.Forms.Label();
            this.OrangeBar = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ReloadButton = new System.Windows.Forms.Button();
            this.MaxWinButton = new System.Windows.Forms.Button();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DashboardPanel.SuspendLayout();
            this.UserDisplayPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DashboardPanel
            // 
            this.DashboardPanel.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            this.DashboardPanel.Controls.Add(this.ResetButton);
            this.DashboardPanel.Controls.Add(this.savePanel);
            this.DashboardPanel.Controls.Add(this.NavPanel);
            this.DashboardPanel.Controls.Add(this.SettingsButton);
            this.DashboardPanel.Controls.Add(this.AMemberButton);
            this.DashboardPanel.Controls.Add(this.SaveButton);
            this.DashboardPanel.Controls.Add(this.EManagerButton);
            this.DashboardPanel.Controls.Add(this.MStatsButton);
            this.DashboardPanel.Controls.Add(this.UserDisplayPanel);
            this.DashboardPanel.Location = new System.Drawing.Point(0, 12);
            this.DashboardPanel.Name = "DashboardPanel";
            this.DashboardPanel.Size = new System.Drawing.Size(186, 565);
            this.DashboardPanel.TabIndex = 0;
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentTwo;
            this.ResetButton.Location = new System.Drawing.Point(1, 459);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(186, 50);
            this.ResetButton.TabIndex = 9;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Visible = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // savePanel
            // 
            this.savePanel.BackColor = System.Drawing.Color.Transparent;
            this.savePanel.Location = new System.Drawing.Point(192, 0);
            this.savePanel.Name = "savePanel";
            this.savePanel.Size = new System.Drawing.Size(758, 577);
            this.savePanel.TabIndex = 8;
            // 
            // NavPanel
            // 
            this.NavPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(147)))), ((int)(((byte)(150)))));
            this.NavPanel.Location = new System.Drawing.Point(0, 193);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Size = new System.Drawing.Size(3, 100);
            this.NavPanel.TabIndex = 6;
            // 
            // SettingsButton
            // 
            this.SettingsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.SettingsButton.FlatAppearance.BorderSize = 0;
            this.SettingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentTwo;
            this.SettingsButton.Location = new System.Drawing.Point(0, 322);
            this.SettingsButton.Name = "SettingsButton";
            this.SettingsButton.Size = new System.Drawing.Size(186, 50);
            this.SettingsButton.TabIndex = 5;
            this.SettingsButton.Text = "Settings";
            this.SettingsButton.UseVisualStyleBackColor = true;
            this.SettingsButton.Click += new System.EventHandler(this.SettingsButton_Click);
            this.SettingsButton.Leave += new System.EventHandler(this.SettingsButton_Leave);
            // 
            // AMemberButton
            // 
            this.AMemberButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.AMemberButton.FlatAppearance.BorderSize = 0;
            this.AMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AMemberButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AMemberButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentTwo;
            this.AMemberButton.Location = new System.Drawing.Point(0, 272);
            this.AMemberButton.Name = "AMemberButton";
            this.AMemberButton.Size = new System.Drawing.Size(186, 50);
            this.AMemberButton.TabIndex = 4;
            this.AMemberButton.Text = "Add/Remove Members";
            this.AMemberButton.UseVisualStyleBackColor = true;
            this.AMemberButton.Click += new System.EventHandler(this.AMemberButton_Click);
            this.AMemberButton.Leave += new System.EventHandler(this.AMemberButton_Leave);
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveButton.FlatAppearance.BorderSize = 0;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentTwo;
            this.SaveButton.Location = new System.Drawing.Point(0, 515);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(186, 50);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Visible = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EManagerButton
            // 
            this.EManagerButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.EManagerButton.FlatAppearance.BorderSize = 0;
            this.EManagerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EManagerButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EManagerButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentTwo;
            this.EManagerButton.Location = new System.Drawing.Point(0, 222);
            this.EManagerButton.Name = "EManagerButton";
            this.EManagerButton.Size = new System.Drawing.Size(186, 50);
            this.EManagerButton.TabIndex = 2;
            this.EManagerButton.Text = "Event Manager";
            this.EManagerButton.UseVisualStyleBackColor = true;
            this.EManagerButton.Click += new System.EventHandler(this.EManagerButton_Click);
            this.EManagerButton.Leave += new System.EventHandler(this.EManagerButton_Leave);
            // 
            // MStatsButton
            // 
            this.MStatsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.MStatsButton.FlatAppearance.BorderSize = 0;
            this.MStatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MStatsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MStatsButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentTwo;
            this.MStatsButton.Location = new System.Drawing.Point(0, 172);
            this.MStatsButton.Name = "MStatsButton";
            this.MStatsButton.Size = new System.Drawing.Size(186, 50);
            this.MStatsButton.TabIndex = 1;
            this.MStatsButton.Text = "Member Statistics";
            this.MStatsButton.UseVisualStyleBackColor = true;
            this.MStatsButton.Click += new System.EventHandler(this.MStatsButton_Click);
            this.MStatsButton.Leave += new System.EventHandler(this.MStatsButton_Leave);
            // 
            // UserDisplayPanel
            // 
            this.UserDisplayPanel.Controls.Add(this.LogoutButton);
            this.UserDisplayPanel.Controls.Add(this.LoginButton);
            this.UserDisplayPanel.Controls.Add(this.UserNameLabel);
            this.UserDisplayPanel.Controls.Add(this.pictureBox1);
            this.UserDisplayPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.UserDisplayPanel.Location = new System.Drawing.Point(0, 0);
            this.UserDisplayPanel.Name = "UserDisplayPanel";
            this.UserDisplayPanel.Size = new System.Drawing.Size(186, 172);
            this.UserDisplayPanel.TabIndex = 0;
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            this.LogoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogoutButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentTwo;
            this.LogoutButton.Location = new System.Drawing.Point(108, 137);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(71, 32);
            this.LogoutButton.TabIndex = 11;
            this.LogoutButton.Text = "Log out";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Visible = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentTwo;
            this.LoginButton.Location = new System.Drawing.Point(55, 137);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(71, 32);
            this.LoginButton.TabIndex = 10;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UserNameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameLabel.ForeColor = global::Dashboard.Properties.Settings.Default.AccentTwo;
            this.UserNameLabel.Location = new System.Drawing.Point(-4, 111);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(186, 23);
            this.UserNameLabel.TabIndex = 1;
            this.UserNameLabel.Text = "not logged in";
            this.UserNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(47, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 98);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // MemberDisplayLabel
            // 
            this.MemberDisplayLabel.AutoSize = true;
            this.MemberDisplayLabel.BackColor = global::Dashboard.Properties.Settings.Default.AccentSeven;
            this.MemberDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MemberDisplayLabel.Location = new System.Drawing.Point(197, 144);
            this.MemberDisplayLabel.Name = "MemberDisplayLabel";
            this.MemberDisplayLabel.Size = new System.Drawing.Size(0, 24);
            this.MemberDisplayLabel.TabIndex = 7;
            // 
            // OrangeBar
            // 
            this.OrangeBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(155)))), ((int)(((byte)(0)))));
            this.OrangeBar.Location = new System.Drawing.Point(185, 17);
            this.OrangeBar.Name = "OrangeBar";
            this.OrangeBar.Size = new System.Drawing.Size(11, 563);
            this.OrangeBar.TabIndex = 9;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox4.BackgroundImage")));
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.Location = new System.Drawing.Point(55, 98);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox5.Location = new System.Drawing.Point(55, 35);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(40, 40);
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.label9.Location = new System.Drawing.Point(165, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 26);
            this.label9.TabIndex = 0;
            this.label9.Text = "Login";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = global::Dashboard.Properties.Settings.Default.AccentTwo;
            this.MainPanel.Location = new System.Drawing.Point(195, 20);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(704, 557);
            this.MainPanel.TabIndex = 10;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            this.HeaderPanel.Controls.Add(this.label1);
            this.HeaderPanel.Controls.Add(this.ReloadButton);
            this.HeaderPanel.Controls.Add(this.MaxWinButton);
            this.HeaderPanel.Controls.Add(this.MinimizeButton);
            this.HeaderPanel.Controls.Add(this.ExitButton);
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(902, 20);
            this.HeaderPanel.TabIndex = 2;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.label1.Location = new System.Drawing.Point(30, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "TQC Admin Tool";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReloadButton
            // 
            this.ReloadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReloadButton.BackgroundImage")));
            this.ReloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ReloadButton.FlatAppearance.BorderSize = 0;
            this.ReloadButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReloadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReloadButton.ForeColor = System.Drawing.SystemColors.Window;
            this.ReloadButton.Location = new System.Drawing.Point(0, 0);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(30, 20);
            this.ReloadButton.TabIndex = 12;
            this.ReloadButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ReloadButton.UseVisualStyleBackColor = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            this.ReloadButton.MouseEnter += new System.EventHandler(this.ReloadButton_MouseEnter);
            this.ReloadButton.MouseLeave += new System.EventHandler(this.ReloadButton_MouseLeave);
            // 
            // MaxWinButton
            // 
            this.MaxWinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MaxWinButton.BackgroundImage")));
            this.MaxWinButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MaxWinButton.FlatAppearance.BorderSize = 0;
            this.MaxWinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MaxWinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxWinButton.ForeColor = System.Drawing.SystemColors.Window;
            this.MaxWinButton.Location = new System.Drawing.Point(842, 0);
            this.MaxWinButton.Name = "MaxWinButton";
            this.MaxWinButton.Size = new System.Drawing.Size(30, 20);
            this.MaxWinButton.TabIndex = 11;
            this.MaxWinButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MaxWinButton.UseVisualStyleBackColor = true;
            this.MaxWinButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MaxWinButton_MouseClick);
            this.MaxWinButton.MouseEnter += new System.EventHandler(this.MaxWinButton_MouseEnter);
            this.MaxWinButton.MouseLeave += new System.EventHandler(this.MaxWinButton_MouseLeave);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MinimizeButton.BackgroundImage")));
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.Window;
            this.MinimizeButton.Location = new System.Drawing.Point(816, 0);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(30, 20);
            this.MinimizeButton.TabIndex = 10;
            this.MinimizeButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.MinimizeButton_Click);
            this.MinimizeButton.MouseEnter += new System.EventHandler(this.MinimizeButton_MouseEnter);
            this.MinimizeButton.MouseLeave += new System.EventHandler(this.MinimizeButton_MouseLeave);
            // 
            // ExitButton
            // 
            this.ExitButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitButton.BackgroundImage")));
            this.ExitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ExitButton.FlatAppearance.BorderSize = 0;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.Window;
            this.ExitButton.Location = new System.Drawing.Point(869, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(30, 20);
            this.ExitButton.TabIndex = 9;
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            this.ClientSize = new System.Drawing.Size(901, 577);
            this.Controls.Add(this.HeaderPanel);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.OrangeBar);
            this.Controls.Add(this.MemberDisplayLabel);
            this.Controls.Add(this.DashboardPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "z";
            this.DashboardPanel.ResumeLayout(false);
            this.UserDisplayPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DashboardPanel;
        private System.Windows.Forms.Panel UserDisplayPanel;
        private System.Windows.Forms.Button MStatsButton;
        private System.Windows.Forms.Label MemberDisplayLabel;
        private System.Windows.Forms.Panel NavPanel;
        private System.Windows.Forms.Button SettingsButton;
        private System.Windows.Forms.Button AMemberButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button EManagerButton;
        private System.Windows.Forms.Panel OrangeBar;
        private System.Windows.Forms.Panel savePanel;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button MaxWinButton;
        private System.Windows.Forms.Button ReloadButton;
        public System.Windows.Forms.Button LogoutButton;
        public System.Windows.Forms.Button LoginButton;
        public System.Windows.Forms.Label label1;
    }
}


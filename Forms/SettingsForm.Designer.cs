
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
            System.Windows.Forms.Button ReloadSourceButton;
            System.Windows.Forms.Button ActivityCheckTrigger;
            System.Windows.Forms.Button LayoutTrigger;
            System.Windows.Forms.Button StartupTrigger;
            this.memberStats = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            SaveButton = new System.Windows.Forms.Button();
            ReloadSourceButton = new System.Windows.Forms.Button();
            ActivityCheckTrigger = new System.Windows.Forms.Button();
            LayoutTrigger = new System.Windows.Forms.Button();
            StartupTrigger = new System.Windows.Forms.Button();
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
            // ReloadSourceButton
            // 
            ReloadSourceButton.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            ReloadSourceButton.CausesValidation = false;
            ReloadSourceButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            ReloadSourceButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            ReloadSourceButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            ReloadSourceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ReloadSourceButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ReloadSourceButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            ReloadSourceButton.Location = new System.Drawing.Point(530, 6);
            ReloadSourceButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ReloadSourceButton.Name = "ReloadSourceButton";
            ReloadSourceButton.Size = new System.Drawing.Size(161, 52);
            ReloadSourceButton.TabIndex = 8;
            ReloadSourceButton.Text = "Reload Textfields";
            ReloadSourceButton.UseVisualStyleBackColor = false;
            ReloadSourceButton.Click += new System.EventHandler(this.ReloadSourceButton_Click);
            // 
            // ActivityCheckTrigger
            // 
            ActivityCheckTrigger.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            ActivityCheckTrigger.CausesValidation = false;
            ActivityCheckTrigger.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            ActivityCheckTrigger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            ActivityCheckTrigger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            ActivityCheckTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ActivityCheckTrigger.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ActivityCheckTrigger.ForeColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            ActivityCheckTrigger.Location = new System.Drawing.Point(13, 62);
            ActivityCheckTrigger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ActivityCheckTrigger.Name = "ActivityCheckTrigger";
            ActivityCheckTrigger.Size = new System.Drawing.Size(161, 52);
            ActivityCheckTrigger.TabIndex = 9;
            ActivityCheckTrigger.Text = "Activity Checking";
            ActivityCheckTrigger.UseVisualStyleBackColor = false;
            ActivityCheckTrigger.Click += new System.EventHandler(this.ActivityCheckTrigger_Click);
            // 
            // LayoutTrigger
            // 
            LayoutTrigger.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            LayoutTrigger.CausesValidation = false;
            LayoutTrigger.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            LayoutTrigger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            LayoutTrigger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            LayoutTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LayoutTrigger.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LayoutTrigger.ForeColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            LayoutTrigger.Location = new System.Drawing.Point(182, 62);
            LayoutTrigger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LayoutTrigger.Name = "LayoutTrigger";
            LayoutTrigger.Size = new System.Drawing.Size(161, 52);
            LayoutTrigger.TabIndex = 10;
            LayoutTrigger.Text = "Layout && Design";
            LayoutTrigger.UseVisualStyleBackColor = false;
            LayoutTrigger.Click += new System.EventHandler(this.LayoutTrigger_Click);
            // 
            // StartupTrigger
            // 
            StartupTrigger.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            StartupTrigger.CausesValidation = false;
            StartupTrigger.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            StartupTrigger.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            StartupTrigger.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            StartupTrigger.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            StartupTrigger.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            StartupTrigger.ForeColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            StartupTrigger.Location = new System.Drawing.Point(351, 62);
            StartupTrigger.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            StartupTrigger.Name = "StartupTrigger";
            StartupTrigger.Size = new System.Drawing.Size(161, 52);
            StartupTrigger.TabIndex = 11;
            StartupTrigger.Text = "Startup";
            StartupTrigger.UseVisualStyleBackColor = false;
            StartupTrigger.Click += new System.EventHandler(this.StartupTrigger_Click);
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
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(0, 120);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(673, 261);
            this.MainPanel.TabIndex = 12;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Dashboard.Properties.Settings.Default.AccentEight;
            this.ClientSize = new System.Drawing.Size(704, 557);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(StartupTrigger);
            this.Controls.Add(LayoutTrigger);
            this.Controls.Add(ActivityCheckTrigger);
            this.Controls.Add(ReloadSourceButton);
            this.Controls.Add(SaveButton);
            this.Controls.Add(this.memberStats);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SettingsForm";
            this.Text = "R";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memberStats;
        private System.Windows.Forms.Panel MainPanel;
    }
}
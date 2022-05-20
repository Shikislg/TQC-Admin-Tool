namespace Dashboard
{
    partial class MemberProfile
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
            this.memberStats = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // memberStats
            // 
            this.memberStats.AutoSize = true;
            this.memberStats.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberStats.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.memberStats.Location = new System.Drawing.Point(1, -2);
            this.memberStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberStats.Name = "memberStats";
            this.memberStats.Size = new System.Drawing.Size(295, 50);
            this.memberStats.TabIndex = 5;
            this.memberStats.Text = "Member Profile";
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Dashboard.Properties.Settings.Default.AccentEight;
            this.ClientSize = new System.Drawing.Size(704, 557);
            this.Controls.Add(this.memberStats);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Member";
            this.Text = "Member";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memberStats;
    }
}
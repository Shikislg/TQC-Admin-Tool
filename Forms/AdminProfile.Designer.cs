namespace Dashboard
{
    partial class AdminProfile
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.EventListBox = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // memberStats
            // 
            this.memberStats.AutoSize = true;
            this.memberStats.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memberStats.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.memberStats.Location = new System.Drawing.Point(0, -2);
            this.memberStats.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberStats.Name = "memberStats";
            this.memberStats.Size = new System.Drawing.Size(264, 50);
            this.memberStats.TabIndex = 4;
            this.memberStats.Text = "Admin Profile";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.EventListBox);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(9, 51);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(683, 494);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 46;
            this.label1.Text = "Created Events";
            // 
            // EventListBox
            // 
            this.EventListBox.BackColor = global::Dashboard.Properties.Settings.Default.AccentEight;
            this.EventListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventListBox.FormattingEnabled = true;
            this.EventListBox.ItemHeight = 19;
            this.EventListBox.Location = new System.Drawing.Point(3, 26);
            this.EventListBox.Name = "EventListBox";
            this.EventListBox.Size = new System.Drawing.Size(680, 456);
            this.EventListBox.TabIndex = 45;
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Dashboard.Properties.Settings.Default.AccentEight;
            this.ClientSize = new System.Drawing.Size(704, 557);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.memberStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminProfile";
            this.Text = "AdminProfile";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label memberStats;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox EventListBox;
    }
}
namespace Dashboard
{
    partial class S_Startup
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
            this.label5 = new System.Windows.Forms.Label();
            this.PullDataOnStartup = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(754, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Pull Data On Startup";
            // 
            // PullDataOnStartup
            // 
            this.PullDataOnStartup.BackColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.PullDataOnStartup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PullDataOnStartup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PullDataOnStartup.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PullDataOnStartup.ForeColor = System.Drawing.Color.Black;
            this.PullDataOnStartup.FormattingEnabled = true;
            this.PullDataOnStartup.Items.AddRange(new object[] {
            "No ",
            "Yes"});
            this.PullDataOnStartup.Location = new System.Drawing.Point(13, 35);
            this.PullDataOnStartup.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PullDataOnStartup.Name = "PullDataOnStartup";
            this.PullDataOnStartup.Size = new System.Drawing.Size(205, 29);
            this.PullDataOnStartup.TabIndex = 33;
            // 
            // S_Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Dashboard.Properties.Settings.Default.AccentTwo;
            this.ClientSize = new System.Drawing.Size(673, 349);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PullDataOnStartup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "S_Startup";
            this.Text = "S_Startup";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox PullDataOnStartup;
    }
}
namespace Dashboard
{
    partial class S_Points
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
            this.label1 = new System.Windows.Forms.Label();
            this.MinPointsTf = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PointModeBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckDateFrequencyBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 23);
            this.label1.TabIndex = 27;
            this.label1.Text = "Minimum Required Points";
            // 
            // MinPointsTf
            // 
            this.MinPointsTf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.MinPointsTf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinPointsTf.Location = new System.Drawing.Point(12, 35);
            this.MinPointsTf.Name = "MinPointsTf";
            this.MinPointsTf.Size = new System.Drawing.Size(206, 29);
            this.MinPointsTf.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 67);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(754, 23);
            this.label3.TabIndex = 29;
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
            this.PointModeBox.Location = new System.Drawing.Point(13, 93);
            this.PointModeBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PointModeBox.Name = "PointModeBox";
            this.PointModeBox.Size = new System.Drawing.Size(205, 29);
            this.PointModeBox.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(286, 23);
            this.label6.TabIndex = 34;
            this.label6.Text = "Checking Frequency (in days)";
            // 
            // CheckDateFrequencyBox
            // 
            this.CheckDateFrequencyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CheckDateFrequencyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckDateFrequencyBox.Location = new System.Drawing.Point(12, 151);
            this.CheckDateFrequencyBox.Name = "CheckDateFrequencyBox";
            this.CheckDateFrequencyBox.Size = new System.Drawing.Size(206, 29);
            this.CheckDateFrequencyBox.TabIndex = 35;
            // 
            // S_Points
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Dashboard.Properties.Settings.Default.AccentTwo;
            this.ClientSize = new System.Drawing.Size(673, 349);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CheckDateFrequencyBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PointModeBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MinPointsTf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "S_Points";
            this.Text = "S_Points";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox MinPointsTf;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox PointModeBox;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox CheckDateFrequencyBox;
    }
}
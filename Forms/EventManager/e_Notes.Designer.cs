namespace Dashboard
{
    partial class e_Notes
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
            this.NotesTf = new System.Windows.Forms.TextBox();
            this.CreateEventButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NotesTf
            // 
            this.NotesTf.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesTf.Location = new System.Drawing.Point(12, 12);
            this.NotesTf.Multiline = true;
            this.NotesTf.Name = "NotesTf";
            this.NotesTf.Size = new System.Drawing.Size(597, 284);
            this.NotesTf.TabIndex = 0;
            this.NotesTf.Text = "Notes";
            // 
            // CreateEventButton
            // 
            this.CreateEventButton.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            this.CreateEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateEventButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateEventButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.CreateEventButton.Location = new System.Drawing.Point(569, 302);
            this.CreateEventButton.Name = "CreateEventButton";
            this.CreateEventButton.Size = new System.Drawing.Size(117, 42);
            this.CreateEventButton.TabIndex = 66;
            this.CreateEventButton.Text = "Create Event";
            this.CreateEventButton.UseVisualStyleBackColor = false;
            this.CreateEventButton.Click += new System.EventHandler(this.CreateEventButton_Click);
            // 
            // e_Notes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::Dashboard.Properties.Settings.Default.AccentTwo;
            this.ClientSize = new System.Drawing.Size(698, 358);
            this.Controls.Add(this.CreateEventButton);
            this.Controls.Add(this.NotesTf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "e_Notes";
            this.Text = "e_Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox NotesTf;
        public System.Windows.Forms.Button CreateEventButton;
    }
}
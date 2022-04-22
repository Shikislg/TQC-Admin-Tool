
namespace Dashboard
{
    partial class EventManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventManager));
            this.EManager = new System.Windows.Forms.Panel();
            this.EventAltedButton = new System.Windows.Forms.Button();
            this.QuestionButton = new System.Windows.Forms.Button();
            this.responseLabel = new System.Windows.Forms.Label();
            this.EventMissedButton = new System.Windows.Forms.Button();
            this.EventParticipatedButton = new System.Windows.Forms.Button();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.ENameInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EManager.SuspendLayout();
            this.SuspendLayout();
            // 
            // EManager
            // 
            this.EManager.BackColor = global::Dashboard.Properties.Settings.Default.AccentEight;
            this.EManager.Controls.Add(this.EventAltedButton);
            this.EManager.Controls.Add(this.QuestionButton);
            this.EManager.Controls.Add(this.responseLabel);
            this.EManager.Controls.Add(this.EventMissedButton);
            this.EManager.Controls.Add(this.EventParticipatedButton);
            this.EManager.Controls.Add(this.confirmLabel);
            this.EManager.Controls.Add(this.ENameInput);
            this.EManager.Controls.Add(this.label3);
            this.EManager.Controls.Add(this.label4);
            this.EManager.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.EManager.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EManager.Location = new System.Drawing.Point(0, 0);
            this.EManager.Name = "EManager";
            this.EManager.Size = new System.Drawing.Size(704, 575);
            this.EManager.TabIndex = 8;
            // 
            // EventAltedButton
            // 
            this.EventAltedButton.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            this.EventAltedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventAltedButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventAltedButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.EventAltedButton.Location = new System.Drawing.Point(154, 81);
            this.EventAltedButton.Name = "EventAltedButton";
            this.EventAltedButton.Size = new System.Drawing.Size(138, 52);
            this.EventAltedButton.TabIndex = 24;
            this.EventAltedButton.Text = "Alted";
            this.EventAltedButton.UseVisualStyleBackColor = false;
            this.EventAltedButton.Click += new System.EventHandler(this.EventAltedButton_Click);
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
            this.QuestionButton.Click += new System.EventHandler(this.QuestionButton_Click);
            // 
            // responseLabel
            // 
            this.responseLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.responseLabel.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.responseLabel.Location = new System.Drawing.Point(7, 158);
            this.responseLabel.Name = "responseLabel";
            this.responseLabel.Size = new System.Drawing.Size(648, 165);
            this.responseLabel.TabIndex = 11;
            this.responseLabel.Text = "|";
            // 
            // EventMissedButton
            // 
            this.EventMissedButton.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            this.EventMissedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventMissedButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventMissedButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.EventMissedButton.Location = new System.Drawing.Point(298, 81);
            this.EventMissedButton.Name = "EventMissedButton";
            this.EventMissedButton.Size = new System.Drawing.Size(138, 52);
            this.EventMissedButton.TabIndex = 10;
            this.EventMissedButton.Text = "No Show";
            this.EventMissedButton.UseVisualStyleBackColor = false;
            this.EventMissedButton.Click += new System.EventHandler(this.EventMissedButton_Click);
            // 
            // EventParticipatedButton
            // 
            this.EventParticipatedButton.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            this.EventParticipatedButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EventParticipatedButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventParticipatedButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.EventParticipatedButton.Location = new System.Drawing.Point(10, 81);
            this.EventParticipatedButton.Name = "EventParticipatedButton";
            this.EventParticipatedButton.Size = new System.Drawing.Size(138, 52);
            this.EventParticipatedButton.TabIndex = 9;
            this.EventParticipatedButton.Text = "Participated";
            this.EventParticipatedButton.UseVisualStyleBackColor = false;
            this.EventParticipatedButton.Click += new System.EventHandler(this.EventParticipatedButton_Click);
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(147)))), ((int)(((byte)(150)))));
            this.confirmLabel.Location = new System.Drawing.Point(15, 181);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(0, 25);
            this.confirmLabel.TabIndex = 8;
            // 
            // ENameInput
            // 
            this.ENameInput.BackColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.ENameInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ENameInput.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.ENameInput.Location = new System.Drawing.Point(150, 42);
            this.ENameInput.Name = "ENameInput";
            this.ENameInput.Size = new System.Drawing.Size(438, 33);
            this.ENameInput.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.label3.Location = new System.Drawing.Point(7, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Discord Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.label4.Location = new System.Drawing.Point(1, -5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 50);
            this.label4.TabIndex = 3;
            this.label4.Text = "Event Manager";
            // 
            // EventManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(703, 550);
            this.Controls.Add(this.EManager);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventManager";
            this.Text = "EventManager";
            this.EManager.ResumeLayout(false);
            this.EManager.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EManager;
        private System.Windows.Forms.Button EventMissedButton;
        private System.Windows.Forms.Button EventParticipatedButton;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.TextBox ENameInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label responseLabel;
        private System.Windows.Forms.Button QuestionButton;
        private System.Windows.Forms.Button EventAltedButton;
    }
}
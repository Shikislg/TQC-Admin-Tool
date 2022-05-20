
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DeleteEventButton = new System.Windows.Forms.Button();
            this.EditEventButton = new System.Windows.Forms.Button();
            this.EventListBox = new System.Windows.Forms.ListBox();
            this.SearchEventButton = new System.Windows.Forms.Button();
            this.SearchTf = new System.Windows.Forms.TextBox();
            this.QuestionButton = new System.Windows.Forms.Button();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.EManager.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // EManager
            // 
            this.EManager.BackColor = global::Dashboard.Properties.Settings.Default.AccentEight;
            this.EManager.Controls.Add(this.MainPanel);
            this.EManager.Controls.Add(this.panel1);
            this.EManager.Controls.Add(this.QuestionButton);
            this.EManager.Controls.Add(this.confirmLabel);
            this.EManager.Controls.Add(this.label4);
            this.EManager.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSix;
            this.EManager.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EManager.Location = new System.Drawing.Point(0, 0);
            this.EManager.Name = "EManager";
            this.EManager.Size = new System.Drawing.Size(704, 575);
            this.EManager.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DeleteEventButton);
            this.panel1.Controls.Add(this.EditEventButton);
            this.panel1.Controls.Add(this.EventListBox);
            this.panel1.Controls.Add(this.SearchEventButton);
            this.panel1.Controls.Add(this.SearchTf);
            this.panel1.Location = new System.Drawing.Point(3, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(698, 490);
            this.panel1.TabIndex = 24;
            // 
            // DeleteEventButton
            // 
            this.DeleteEventButton.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            this.DeleteEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteEventButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEventButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.DeleteEventButton.Location = new System.Drawing.Point(510, 448);
            this.DeleteEventButton.Name = "DeleteEventButton";
            this.DeleteEventButton.Size = new System.Drawing.Size(117, 42);
            this.DeleteEventButton.TabIndex = 46;
            this.DeleteEventButton.Text = "Delete Event";
            this.DeleteEventButton.UseVisualStyleBackColor = false;
            this.DeleteEventButton.Click += new System.EventHandler(this.DeleteEventButton_Click);
            // 
            // EditEventButton
            // 
            this.EditEventButton.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            this.EditEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditEventButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditEventButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.EditEventButton.Location = new System.Drawing.Point(510, 400);
            this.EditEventButton.Name = "EditEventButton";
            this.EditEventButton.Size = new System.Drawing.Size(117, 42);
            this.EditEventButton.TabIndex = 45;
            this.EditEventButton.Text = "Edit Event";
            this.EditEventButton.UseVisualStyleBackColor = false;
            this.EditEventButton.Click += new System.EventHandler(this.EditEventButton_Click);
            // 
            // EventListBox
            // 
            this.EventListBox.BackColor = global::Dashboard.Properties.Settings.Default.AccentTwo;
            this.EventListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EventListBox.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EventListBox.FormattingEnabled = true;
            this.EventListBox.ItemHeight = 19;
            this.EventListBox.Location = new System.Drawing.Point(3, 403);
            this.EventListBox.Name = "EventListBox";
            this.EventListBox.Size = new System.Drawing.Size(501, 76);
            this.EventListBox.TabIndex = 44;
            this.EventListBox.SelectedIndexChanged += new System.EventHandler(this.EventListBox_SelectedIndexChanged);
            // 
            // SearchEventButton
            // 
            this.SearchEventButton.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            this.SearchEventButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchEventButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchEventButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.SearchEventButton.Location = new System.Drawing.Point(248, 355);
            this.SearchEventButton.Name = "SearchEventButton";
            this.SearchEventButton.Size = new System.Drawing.Size(117, 42);
            this.SearchEventButton.TabIndex = 43;
            this.SearchEventButton.Text = "Search Event";
            this.SearchEventButton.UseVisualStyleBackColor = false;
            this.SearchEventButton.Click += new System.EventHandler(this.SearchEventButton_Click);
            // 
            // SearchTf
            // 
            this.SearchTf.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.SearchTf.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.SearchTf.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchTf.Location = new System.Drawing.Point(3, 362);
            this.SearchTf.Name = "SearchTf";
            this.SearchTf.Size = new System.Drawing.Size(239, 29);
            this.SearchTf.TabIndex = 42;
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
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(3, 45);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(698, 358);
            this.MainPanel.TabIndex = 47;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel EManager;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button QuestionButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox EventListBox;
        private System.Windows.Forms.Button SearchEventButton;
        private System.Windows.Forms.Button EditEventButton;
        private System.Windows.Forms.Button DeleteEventButton;
        public System.Windows.Forms.TextBox SearchTf;
        private System.Windows.Forms.Panel MainPanel;
    }
}
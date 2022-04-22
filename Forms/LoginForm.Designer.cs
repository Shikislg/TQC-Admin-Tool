
namespace Dashboard
{
    partial class LoginForm
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
            System.Windows.Forms.Button LoginButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.RememberMe = new System.Windows.Forms.CheckBox();
            this.ExotLoginButton = new System.Windows.Forms.Button();
            this.PasswordTf = new System.Windows.Forms.TextBox();
            this.UserNameTf = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LoginLabel = new System.Windows.Forms.Label();
            LoginButton = new System.Windows.Forms.Button();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            LoginButton.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            LoginButton.CausesValidation = false;
            LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            LoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            LoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            LoginButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            LoginButton.ForeColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            LoginButton.Location = new System.Drawing.Point(203, 207);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new System.Drawing.Size(93, 44);
            LoginButton.TabIndex = 7;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = global::Dashboard.Properties.Settings.Default.AccentOne;
            this.LoginPanel.Controls.Add(this.RememberMe);
            this.LoginPanel.Controls.Add(this.ExotLoginButton);
            this.LoginPanel.Controls.Add(LoginButton);
            this.LoginPanel.Controls.Add(this.PasswordTf);
            this.LoginPanel.Controls.Add(this.UserNameTf);
            this.LoginPanel.Controls.Add(this.pictureBox3);
            this.LoginPanel.Controls.Add(this.pictureBox2);
            this.LoginPanel.Controls.Add(this.LoginLabel);
            this.LoginPanel.Location = new System.Drawing.Point(0, 0);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(500, 263);
            this.LoginPanel.TabIndex = 1;
            // 
            // RememberMe
            // 
            this.RememberMe.AutoSize = true;
            this.RememberMe.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RememberMe.ForeColor = global::Dashboard.Properties.Settings.Default.AccentSeven;
            this.RememberMe.Location = new System.Drawing.Point(114, 170);
            this.RememberMe.Name = "RememberMe";
            this.RememberMe.Size = new System.Drawing.Size(116, 21);
            this.RememberMe.TabIndex = 9;
            this.RememberMe.Text = "Remember me";
            this.RememberMe.UseVisualStyleBackColor = true;
            // 
            // ExotLoginButton
            // 
            this.ExotLoginButton.FlatAppearance.BorderSize = 0;
            this.ExotLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExotLoginButton.ForeColor = System.Drawing.SystemColors.Window;
            this.ExotLoginButton.Location = new System.Drawing.Point(477, 3);
            this.ExotLoginButton.Name = "ExotLoginButton";
            this.ExotLoginButton.Size = new System.Drawing.Size(20, 20);
            this.ExotLoginButton.TabIndex = 8;
            this.ExotLoginButton.Text = "X";
            this.ExotLoginButton.UseVisualStyleBackColor = true;
            this.ExotLoginButton.Click += new System.EventHandler(this.ExitLoginButton_Click);
            // 
            // PasswordTf
            // 
            this.PasswordTf.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTf.Location = new System.Drawing.Point(114, 115);
            this.PasswordTf.Name = "PasswordTf";
            this.PasswordTf.PasswordChar = '*';
            this.PasswordTf.Size = new System.Drawing.Size(261, 27);
            this.PasswordTf.TabIndex = 4;
            // 
            // UserNameTf
            // 
            this.UserNameTf.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNameTf.Location = new System.Drawing.Point(114, 53);
            this.UserNameTf.Name = "UserNameTf";
            this.UserNameTf.Size = new System.Drawing.Size(261, 27);
            this.UserNameTf.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(44, 105);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(44, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // LoginLabel
            // 
            this.LoginLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginLabel.ForeColor = global::Dashboard.Properties.Settings.Default.AccentFive;
            this.LoginLabel.Location = new System.Drawing.Point(213, 0);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(89, 37);
            this.LoginLabel.TabIndex = 0;
            this.LoginLabel.Text = "Login";
            this.LoginLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 263);
            this.Controls.Add(this.LoginPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.TextBox PasswordTf;
        private System.Windows.Forms.TextBox UserNameTf;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label LoginLabel;
        private System.Windows.Forms.Button ExotLoginButton;
        private System.Windows.Forms.CheckBox RememberMe;
    }
}
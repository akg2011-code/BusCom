namespace testProj
{
    partial class Login
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
            this.userTextbox = new MetroFramework.Controls.MetroTextBox();
            this.passwordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // userTextbox
            // 
            // 
            // 
            // 
            this.userTextbox.CustomButton.Image = null;
            this.userTextbox.CustomButton.Location = new System.Drawing.Point(221, 1);
            this.userTextbox.CustomButton.Name = "";
            this.userTextbox.CustomButton.Size = new System.Drawing.Size(41, 41);
            this.userTextbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userTextbox.CustomButton.TabIndex = 1;
            this.userTextbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userTextbox.CustomButton.UseSelectable = true;
            this.userTextbox.CustomButton.Visible = false;
            this.userTextbox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.userTextbox.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.userTextbox.Lines = new string[0];
            this.userTextbox.Location = new System.Drawing.Point(61, 171);
            this.userTextbox.MaxLength = 32767;
            this.userTextbox.Multiline = true;
            this.userTextbox.Name = "userTextbox";
            this.userTextbox.PasswordChar = '\0';
            this.userTextbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userTextbox.SelectedText = "";
            this.userTextbox.SelectionLength = 0;
            this.userTextbox.SelectionStart = 0;
            this.userTextbox.ShortcutsEnabled = true;
            this.userTextbox.Size = new System.Drawing.Size(263, 43);
            this.userTextbox.TabIndex = 0;
            this.userTextbox.UseSelectable = true;
            this.userTextbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userTextbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // passwordTextBox
            // 
            // 
            // 
            // 
            this.passwordTextBox.CustomButton.Image = null;
            this.passwordTextBox.CustomButton.Location = new System.Drawing.Point(223, 2);
            this.passwordTextBox.CustomButton.Name = "";
            this.passwordTextBox.CustomButton.Size = new System.Drawing.Size(37, 37);
            this.passwordTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordTextBox.CustomButton.TabIndex = 1;
            this.passwordTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordTextBox.CustomButton.UseSelectable = true;
            this.passwordTextBox.CustomButton.Visible = false;
            this.passwordTextBox.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.passwordTextBox.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.passwordTextBox.Lines = new string[0];
            this.passwordTextBox.Location = new System.Drawing.Point(61, 268);
            this.passwordTextBox.MaxLength = 32767;
            this.passwordTextBox.Multiline = true;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordTextBox.SelectedText = "";
            this.passwordTextBox.SelectionLength = 0;
            this.passwordTextBox.SelectionStart = 0;
            this.passwordTextBox.ShortcutsEnabled = true;
            this.passwordTextBox.Size = new System.Drawing.Size(263, 42);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.UseSelectable = true;
            this.passwordTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(61, 384);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(263, 46);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "Login";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 511);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.userTextbox);
            this.Name = "Login";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Login";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox userTextbox;
        private MetroFramework.Controls.MetroTextBox passwordTextBox;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}
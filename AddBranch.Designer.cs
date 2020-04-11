namespace testProj
{
    partial class AddBranch
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
            this.txtBranchName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // txtBranchName
            // 
            // 
            // 
            // 
            this.txtBranchName.CustomButton.Image = null;
            this.txtBranchName.CustomButton.Location = new System.Drawing.Point(159, 1);
            this.txtBranchName.CustomButton.Name = "";
            this.txtBranchName.CustomButton.Size = new System.Drawing.Size(33, 33);
            this.txtBranchName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBranchName.CustomButton.TabIndex = 1;
            this.txtBranchName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBranchName.CustomButton.UseSelectable = true;
            this.txtBranchName.CustomButton.Visible = false;
            this.txtBranchName.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txtBranchName.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtBranchName.Lines = new string[0];
            this.txtBranchName.Location = new System.Drawing.Point(132, 182);
            this.txtBranchName.MaxLength = 32767;
            this.txtBranchName.Multiline = true;
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.PasswordChar = '\0';
            this.txtBranchName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBranchName.SelectedText = "";
            this.txtBranchName.SelectionLength = 0;
            this.txtBranchName.SelectionStart = 0;
            this.txtBranchName.ShortcutsEnabled = true;
            this.txtBranchName.Size = new System.Drawing.Size(193, 35);
            this.txtBranchName.TabIndex = 0;
            this.txtBranchName.UseSelectable = true;
            this.txtBranchName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBranchName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(1, 182);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(125, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Branch Name :";
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(94, 314);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(181, 60);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "ADD";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // AddBranch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 431);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtBranchName);
            this.MaximizeBox = false;
            this.Name = "AddBranch";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Add Branch";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddBranch_FormClosed);
            this.Load += new System.EventHandler(this.AddBranch_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtBranchName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}
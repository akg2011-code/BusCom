namespace testProj
{
    partial class AddBus
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
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtBusTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(24, 138);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(84, 25);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Bus Title :";
            // 
            // txtBusTitle
            // 
            // 
            // 
            // 
            this.txtBusTitle.CustomButton.Image = null;
            this.txtBusTitle.CustomButton.Location = new System.Drawing.Point(137, 1);
            this.txtBusTitle.CustomButton.Name = "";
            this.txtBusTitle.CustomButton.Size = new System.Drawing.Size(31, 31);
            this.txtBusTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBusTitle.CustomButton.TabIndex = 1;
            this.txtBusTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBusTitle.CustomButton.UseSelectable = true;
            this.txtBusTitle.CustomButton.Visible = false;
            this.txtBusTitle.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtBusTitle.Lines = new string[0];
            this.txtBusTitle.Location = new System.Drawing.Point(114, 138);
            this.txtBusTitle.MaxLength = 32767;
            this.txtBusTitle.Multiline = true;
            this.txtBusTitle.Name = "txtBusTitle";
            this.txtBusTitle.PasswordChar = '\0';
            this.txtBusTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBusTitle.SelectedText = "";
            this.txtBusTitle.SelectionLength = 0;
            this.txtBusTitle.SelectionStart = 0;
            this.txtBusTitle.ShortcutsEnabled = true;
            this.txtBusTitle.Size = new System.Drawing.Size(169, 33);
            this.txtBusTitle.TabIndex = 1;
            this.txtBusTitle.UseSelectable = true;
            this.txtBusTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBusTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(100, 331);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(152, 61);
            this.metroButton1.TabIndex = 2;
            this.metroButton1.Text = "ADD";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // AddBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 445);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.txtBusTitle);
            this.Controls.Add(this.metroLabel1);
            this.MaximizeBox = false;
            this.Name = "AddBus";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "AddBus";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddBus_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtBusTitle;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}
namespace testProj
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.TripBtn = new MetroFramework.Controls.MetroButton();
            this.branchBtn = new MetroFramework.Controls.MetroButton();
            this.InfoBtn = new MetroFramework.Controls.MetroButton();
            this.BusBtn = new MetroFramework.Controls.MetroButton();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(35, 95);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(305, 106);
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "Reservation";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // TripBtn
            // 
            this.TripBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.TripBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.TripBtn.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.TripBtn.ForeColor = System.Drawing.Color.White;
            this.TripBtn.Location = new System.Drawing.Point(208, 217);
            this.TripBtn.Name = "TripBtn";
            this.TripBtn.Size = new System.Drawing.Size(133, 94);
            this.TripBtn.TabIndex = 2;
            this.TripBtn.Text = "Users";
            this.TripBtn.UseCustomBackColor = true;
            this.TripBtn.UseCustomForeColor = true;
            this.TripBtn.UseSelectable = true;
            this.TripBtn.Click += new System.EventHandler(this.TripBtn_Click);
            // 
            // branchBtn
            // 
            this.branchBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.branchBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.branchBtn.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.branchBtn.ForeColor = System.Drawing.Color.White;
            this.branchBtn.Location = new System.Drawing.Point(35, 217);
            this.branchBtn.Name = "branchBtn";
            this.branchBtn.Size = new System.Drawing.Size(133, 94);
            this.branchBtn.TabIndex = 3;
            this.branchBtn.Text = "Branch";
            this.branchBtn.UseCustomBackColor = true;
            this.branchBtn.UseCustomForeColor = true;
            this.branchBtn.UseSelectable = true;
            this.branchBtn.Click += new System.EventHandler(this.branchBtn_Click);
            // 
            // InfoBtn
            // 
            this.InfoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.InfoBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.InfoBtn.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.InfoBtn.ForeColor = System.Drawing.Color.White;
            this.InfoBtn.Location = new System.Drawing.Point(207, 330);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(133, 94);
            this.InfoBtn.TabIndex = 4;
            this.InfoBtn.Text = "Information";
            this.InfoBtn.UseCustomBackColor = true;
            this.InfoBtn.UseCustomForeColor = true;
            this.InfoBtn.UseSelectable = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // BusBtn
            // 
            this.BusBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.BusBtn.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BusBtn.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.BusBtn.ForeColor = System.Drawing.Color.White;
            this.BusBtn.Location = new System.Drawing.Point(35, 330);
            this.BusBtn.Name = "BusBtn";
            this.BusBtn.Size = new System.Drawing.Size(133, 94);
            this.BusBtn.TabIndex = 5;
            this.BusBtn.Text = "Buses";
            this.BusBtn.UseCustomBackColor = true;
            this.BusBtn.UseCustomForeColor = true;
            this.BusBtn.UseSelectable = true;
            this.BusBtn.Click += new System.EventHandler(this.BusBtn_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLogout.BackgroundImage")));
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLogout.DisplayFocus = true;
            this.btnLogout.Location = new System.Drawing.Point(12, 19);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(42, 36);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 511);
            this.Controls.Add(this.BusBtn);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.branchBtn);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.TripBtn);
            this.Controls.Add(this.metroButton1);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "Dashboard";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton TripBtn;
        private MetroFramework.Controls.MetroButton branchBtn;
        private MetroFramework.Controls.MetroButton InfoBtn;
        private MetroFramework.Controls.MetroButton BusBtn;
        private MetroFramework.Controls.MetroButton btnLogout;
    }
}
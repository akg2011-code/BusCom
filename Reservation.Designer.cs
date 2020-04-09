namespace testProj
{
    partial class Reservation
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
            MetroFramework.Controls.MetroLabel metroLabel6;
            MetroFramework.Controls.MetroLabel metroLabel7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbFrom = new MetroFramework.Controls.MetroComboBox();
            this.cbTo = new MetroFramework.Controls.MetroComboBox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            metroLabel6 = new MetroFramework.Controls.MetroLabel();
            metroLabel7 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel6
            // 
            metroLabel6.AutoSize = true;
            metroLabel6.Location = new System.Drawing.Point(162, 129);
            metroLabel6.Name = "metroLabel6";
            metroLabel6.Size = new System.Drawing.Size(21, 19);
            metroLabel6.TabIndex = 7;
            metroLabel6.Text = "←";
            // 
            // metroLabel7
            // 
            metroLabel7.AutoSize = true;
            metroLabel7.Location = new System.Drawing.Point(162, 148);
            metroLabel7.Name = "metroLabel7";
            metroLabel7.Size = new System.Drawing.Size(21, 19);
            metroLabel7.TabIndex = 8;
            metroLabel7.Text = "→";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(40, 77);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(66, 19);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Distnation";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(40, 208);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(36, 19);
            this.metroLabel4.TabIndex = 3;
            this.metroLabel4.Text = "Date";
            // 
            // cbFrom
            // 
            this.cbFrom.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.cbFrom.FormattingEnabled = true;
            this.cbFrom.ItemHeight = 23;
            this.cbFrom.Location = new System.Drawing.Point(26, 129);
            this.cbFrom.Name = "cbFrom";
            this.cbFrom.PromptText = "From";
            this.cbFrom.Size = new System.Drawing.Size(109, 29);
            this.cbFrom.TabIndex = 5;
            this.cbFrom.Text = "From";
            this.cbFrom.UseSelectable = true;
            this.cbFrom.SelectedIndexChanged += new System.EventHandler(this.cbFrom_SelectedIndexChanged);
            // 
            // cbTo
            // 
            this.cbTo.FormattingEnabled = true;
            this.cbTo.ItemHeight = 23;
            this.cbTo.Location = new System.Drawing.Point(210, 129);
            this.cbTo.Name = "cbTo";
            this.cbTo.PromptText = "To";
            this.cbTo.Size = new System.Drawing.Size(109, 29);
            this.cbTo.TabIndex = 6;
            this.cbTo.Text = "To";
            this.cbTo.UseSelectable = true;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(26, 244);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(200, 29);
            this.metroDateTime1.TabIndex = 9;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(40, 316);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(38, 19);
            this.metroLabel2.TabIndex = 10;
            this.metroLabel2.Text = "Time";
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.ItemHeight = 23;
            this.metroComboBox3.Items.AddRange(new object[] {
            "6 AM",
            "1 PM",
            "7 PM"});
            this.metroComboBox3.Location = new System.Drawing.Point(26, 351);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.PromptText = "Time";
            this.metroComboBox3.Size = new System.Drawing.Size(64, 29);
            this.metroComboBox3.TabIndex = 11;
            this.metroComboBox3.Text = "Time";
            this.metroComboBox3.UseSelectable = true;
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.ForeColor = System.Drawing.Color.White;
            this.metroButton1.Location = new System.Drawing.Point(72, 411);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(199, 48);
            this.metroButton1.TabIndex = 12;
            this.metroButton1.Text = "Next";
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseCustomForeColor = true;
            this.metroButton1.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 77);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(11, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(11, 315);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 501);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroComboBox3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(metroLabel7);
            this.Controls.Add(metroLabel6);
            this.Controls.Add(this.cbTo);
            this.Controls.Add(this.cbFrom);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.Name = "Reservation";
            this.Text = "Reservation";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbFrom;
        private MetroFramework.Controls.MetroComboBox cbTo;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
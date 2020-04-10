namespace testProj
{
    partial class Ticket
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ticket));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtDate = new MetroFramework.Controls.MetroTextBox();
            this.txtTime = new MetroFramework.Controls.MetroTextBox();
            this.txtSource = new MetroFramework.Controls.MetroTextBox();
            this.txtDest = new MetroFramework.Controls.MetroTextBox();
            this.txtName = new MetroFramework.Controls.MetroTextBox();
            this.txtSeat = new MetroFramework.Controls.MetroTextBox();
            this.previousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(797, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(58, 89);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(62, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Date :";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            this.metroLabel1.UseCustomForeColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(56, 148);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(64, 25);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "Time :";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            this.metroLabel2.UseCustomForeColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(55, 205);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(65, 25);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "From :";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomBackColor = true;
            this.metroLabel3.UseCustomForeColor = true;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem,
            this.nextToolStripMenuItem,
            this.previousToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(181, 114);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.printToolStripMenuItem.Text = "Print";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // nextToolStripMenuItem
            // 
            this.nextToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("nextToolStripMenuItem.Image")));
            this.nextToolStripMenuItem.Name = "nextToolStripMenuItem";
            this.nextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nextToolStripMenuItem.Text = "Next";
            this.nextToolStripMenuItem.Click += new System.EventHandler(this.nextToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("closeToolStripMenuItem.Image")));
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(55, 258);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(62, 25);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "To     :";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.UseCustomForeColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(407, 89);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(83, 25);
            this.metroLabel6.TabIndex = 15;
            this.metroLabel6.Text = "CName :";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseCustomBackColor = true;
            this.metroLabel6.UseCustomForeColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel7.Location = new System.Drawing.Point(385, 147);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(105, 25);
            this.metroLabel7.TabIndex = 17;
            this.metroLabel7.Text = "Seat Num :";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.UseCustomBackColor = true;
            this.metroLabel7.UseCustomForeColor = true;
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.txtDate.CustomButton.Image = null;
            this.txtDate.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtDate.CustomButton.Name = "";
            this.txtDate.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDate.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDate.CustomButton.TabIndex = 1;
            this.txtDate.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDate.CustomButton.UseSelectable = true;
            this.txtDate.CustomButton.Visible = false;
            this.txtDate.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDate.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtDate.Lines = new string[0];
            this.txtDate.Location = new System.Drawing.Point(128, 90);
            this.txtDate.MaxLength = 32767;
            this.txtDate.Multiline = true;
            this.txtDate.Name = "txtDate";
            this.txtDate.PasswordChar = '\0';
            this.txtDate.ReadOnly = true;
            this.txtDate.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDate.SelectedText = "";
            this.txtDate.SelectionLength = 0;
            this.txtDate.SelectionStart = 0;
            this.txtDate.ShortcutsEnabled = true;
            this.txtDate.Size = new System.Drawing.Size(116, 26);
            this.txtDate.TabIndex = 19;
            this.txtDate.UseCustomBackColor = true;
            this.txtDate.UseCustomForeColor = true;
            this.txtDate.UseSelectable = true;
            this.txtDate.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDate.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtTime
            // 
            this.txtTime.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.txtTime.CustomButton.Image = null;
            this.txtTime.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtTime.CustomButton.Name = "";
            this.txtTime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTime.CustomButton.TabIndex = 1;
            this.txtTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTime.CustomButton.UseSelectable = true;
            this.txtTime.CustomButton.Visible = false;
            this.txtTime.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTime.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtTime.Lines = new string[0];
            this.txtTime.Location = new System.Drawing.Point(128, 147);
            this.txtTime.MaxLength = 32767;
            this.txtTime.Multiline = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.PasswordChar = '\0';
            this.txtTime.ReadOnly = true;
            this.txtTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTime.SelectedText = "";
            this.txtTime.SelectionLength = 0;
            this.txtTime.SelectionStart = 0;
            this.txtTime.ShortcutsEnabled = true;
            this.txtTime.Size = new System.Drawing.Size(116, 26);
            this.txtTime.TabIndex = 20;
            this.txtTime.UseCustomBackColor = true;
            this.txtTime.UseCustomForeColor = true;
            this.txtTime.UseSelectable = true;
            this.txtTime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSource
            // 
            this.txtSource.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.txtSource.CustomButton.Image = null;
            this.txtSource.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtSource.CustomButton.Name = "";
            this.txtSource.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSource.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSource.CustomButton.TabIndex = 1;
            this.txtSource.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSource.CustomButton.UseSelectable = true;
            this.txtSource.CustomButton.Visible = false;
            this.txtSource.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSource.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtSource.Lines = new string[0];
            this.txtSource.Location = new System.Drawing.Point(128, 205);
            this.txtSource.MaxLength = 32767;
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.PasswordChar = '\0';
            this.txtSource.ReadOnly = true;
            this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSource.SelectedText = "";
            this.txtSource.SelectionLength = 0;
            this.txtSource.SelectionStart = 0;
            this.txtSource.ShortcutsEnabled = true;
            this.txtSource.Size = new System.Drawing.Size(116, 26);
            this.txtSource.TabIndex = 21;
            this.txtSource.UseCustomBackColor = true;
            this.txtSource.UseCustomForeColor = true;
            this.txtSource.UseSelectable = true;
            this.txtSource.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSource.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtDest
            // 
            this.txtDest.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.txtDest.CustomButton.Image = null;
            this.txtDest.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtDest.CustomButton.Name = "";
            this.txtDest.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtDest.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDest.CustomButton.TabIndex = 1;
            this.txtDest.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDest.CustomButton.UseSelectable = true;
            this.txtDest.CustomButton.Visible = false;
            this.txtDest.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDest.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtDest.Lines = new string[0];
            this.txtDest.Location = new System.Drawing.Point(128, 258);
            this.txtDest.MaxLength = 32767;
            this.txtDest.Multiline = true;
            this.txtDest.Name = "txtDest";
            this.txtDest.PasswordChar = '\0';
            this.txtDest.ReadOnly = true;
            this.txtDest.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDest.SelectedText = "";
            this.txtDest.SelectionLength = 0;
            this.txtDest.SelectionStart = 0;
            this.txtDest.ShortcutsEnabled = true;
            this.txtDest.Size = new System.Drawing.Size(116, 26);
            this.txtDest.TabIndex = 22;
            this.txtDest.UseCustomBackColor = true;
            this.txtDest.UseCustomForeColor = true;
            this.txtDest.UseSelectable = true;
            this.txtDest.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDest.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.txtName.CustomButton.Image = null;
            this.txtName.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtName.CustomButton.Name = "";
            this.txtName.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtName.CustomButton.TabIndex = 1;
            this.txtName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtName.CustomButton.UseSelectable = true;
            this.txtName.CustomButton.Visible = false;
            this.txtName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtName.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtName.Lines = new string[0];
            this.txtName.Location = new System.Drawing.Point(511, 88);
            this.txtName.MaxLength = 32767;
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.ReadOnly = true;
            this.txtName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtName.SelectedText = "";
            this.txtName.SelectionLength = 0;
            this.txtName.SelectionStart = 0;
            this.txtName.ShortcutsEnabled = true;
            this.txtName.Size = new System.Drawing.Size(116, 26);
            this.txtName.TabIndex = 24;
            this.txtName.UseCustomBackColor = true;
            this.txtName.UseCustomForeColor = true;
            this.txtName.UseSelectable = true;
            this.txtName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSeat
            // 
            this.txtSeat.BackColor = System.Drawing.Color.WhiteSmoke;
            // 
            // 
            // 
            this.txtSeat.CustomButton.Image = null;
            this.txtSeat.CustomButton.Location = new System.Drawing.Point(92, 2);
            this.txtSeat.CustomButton.Name = "";
            this.txtSeat.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSeat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSeat.CustomButton.TabIndex = 1;
            this.txtSeat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSeat.CustomButton.UseSelectable = true;
            this.txtSeat.CustomButton.Visible = false;
            this.txtSeat.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSeat.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.txtSeat.Lines = new string[0];
            this.txtSeat.Location = new System.Drawing.Point(511, 146);
            this.txtSeat.MaxLength = 32767;
            this.txtSeat.Multiline = true;
            this.txtSeat.Name = "txtSeat";
            this.txtSeat.PasswordChar = '\0';
            this.txtSeat.ReadOnly = true;
            this.txtSeat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSeat.SelectedText = "";
            this.txtSeat.SelectionLength = 0;
            this.txtSeat.SelectionStart = 0;
            this.txtSeat.ShortcutsEnabled = true;
            this.txtSeat.Size = new System.Drawing.Size(116, 26);
            this.txtSeat.TabIndex = 25;
            this.txtSeat.UseCustomBackColor = true;
            this.txtSeat.UseCustomForeColor = true;
            this.txtSeat.UseSelectable = true;
            this.txtSeat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSeat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // previousToolStripMenuItem
            // 
            this.previousToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("previousToolStripMenuItem.Image")));
            this.previousToolStripMenuItem.Name = "previousToolStripMenuItem";
            this.previousToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.previousToolStripMenuItem.Text = "Previous";
            // 
            // Ticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(798, 424);
            this.Controls.Add(this.txtSeat);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDest);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Ticket";
            this.Text = "Ticket";
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Ticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private MetroFramework.Controls.MetroTextBox txtDate;
        private MetroFramework.Controls.MetroTextBox txtTime;
        private MetroFramework.Controls.MetroTextBox txtSource;
        private MetroFramework.Controls.MetroTextBox txtDest;
        private MetroFramework.Controls.MetroTextBox txtName;
        private MetroFramework.Controls.MetroTextBox txtSeat;
        private System.Windows.Forms.ToolStripMenuItem previousToolStripMenuItem;
    }
}
using DatabaseCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testProj.Models;

namespace testProj
{
    public partial class Ticket : Form
    {
        Trip trip;
        List<int> seats;
        LoginUser loggedUser;
        string customerName;
        public Ticket(LoginUser _loggedUser,Trip _trip,List<int> _seats,string _customerName)
        {
            InitializeComponent();
            trip = _trip;
            seats = _seats;
            loggedUser = _loggedUser;
            customerName = _customerName;

        }
        //for move body of form 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        
        

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        metroContextMenu1.Show(this, new Point(e.X, e.Y));//places the menu at the pointer position
                    }
                    break;
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel panel = new Panel();
            this.Controls.Add(panel);
            Graphics grp = panel.CreateGraphics();
            Size formSize = this.ClientSize;
            bitmap = new Bitmap(formSize.Width, formSize.Height, grp);
            grp = Graphics.FromImage(bitmap);
            Point panelLocation = PointToScreen(panel.Location);
            grp.CopyFromScreen(panelLocation.X, panelLocation.Y, 0, 0, formSize);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.PrintPreviewControl.Zoom = 1;
            printPreviewDialog1.ShowDialog();
        }
        Bitmap bitmap;
        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = pictureBox1.Size;
            bitmap = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(bitmap);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            //ToolTip toolTip1 = new ToolTip();
            //toolTip1.ShowAlways = true;
            //toolTip1.SetToolTip(metroContextMenu1, "Click me to execute.");
            txtDate.Text = trip.DepartureTime.Date.ToString("dddd, dd MMMM yyyy");
            txtSource.Text = trip.Source.BranchName;
            txtDest.Text = trip.Destination.BranchName;
            txtTime.Text = trip.DepartureTime.TimeOfDay.ToString("hh':'mm");
            txtName.Text = customerName;
            StringBuilder sb = new StringBuilder("");
            int i = 0;
            if (seats.Count>1)
            for (; i < seats.Count -1; i++)
            {
                sb.Append($"{seats.ElementAt(i)} , ");
            }
            sb.Append($"{seats.ElementAt(i)}");

            txtSeat.Text = sb.ToString();
        }

        private void nextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(loggedUser);
            this.Hide();
            dashboard.ShowDialog();
            this.Close();

        }
    }
}

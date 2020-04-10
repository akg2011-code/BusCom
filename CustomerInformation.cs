using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testProj
{
    public partial class CustomerInformation : MetroFramework.Forms.MetroForm
    {
        public CustomerInformation()
        {
            InitializeComponent();
        }

        private void CustomerInformation_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Reservation reservForm = new Reservation(txtName);
            reservForm.ShowDialog();
            reservForm.Close();
        }
    }
}

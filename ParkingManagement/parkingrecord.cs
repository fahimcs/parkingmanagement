using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingManagement
{
    public partial class frmparkingrecord : Form
    {
        public frmparkingrecord()
        {
            InitializeComponent();
        }

        private void btnBacklevel1_Click(object sender, EventArgs e)
        {
            frmmainmenu fm = new frmmainmenu();
            fm.Show();
            this.Hide();
        }

        private void frmparkingrecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class frmparkingcontrol : Form
    {
        public frmparkingcontrol()
        {
            InitializeComponent();
        }

        private void btnLevel1_Click(object sender, EventArgs e)
        {
            frmlevel1 fl = new frmlevel1();
            fl.Show();
            this.Hide();
        }

        private void btnBackMainMenu_Click(object sender, EventArgs e)
        {
            frmmainmenu fm = new frmmainmenu();
            fm.Show();
            this.Hide();
        }

        private void frmparkingcontrol_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

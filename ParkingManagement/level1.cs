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
    public partial class frmlevel1 : Form
    {
        public frmlevel1()
        {
            InitializeComponent();
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBacklevel1_Click(object sender, EventArgs e)
        {
            frmparkingcontrol fp = new frmparkingcontrol();
            fp.Show();
            this.Hide();
        }

        private void frmlevel1_Load(object sender, EventArgs e)
        {

        }

        private void frmlevel1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}

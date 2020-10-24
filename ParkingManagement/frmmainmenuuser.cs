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
    public partial class frmmainmenuuser : Form
    {
        public frmmainmenuuser()
        {
            InitializeComponent();
        }

        private void lblMainMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnParkingControl_Click(object sender, EventArgs e)
        {
            frmparkingcontrol fc = new frmparkingcontrol();
            fc.Show();
            this.Hide();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            frmparkingrecord fr = new frmparkingrecord();
            fr.Show();
            this.Hide();
        }
    }
}

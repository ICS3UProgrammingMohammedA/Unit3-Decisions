/*
 * Created by: Mohammed Alnajeh
 * Created on: 2018-11-02
 * Created for: ICS3U Programming
 * Daily Assignment – Day #19 - Chocolate Boxes
 * This program...
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChocolateBoxesMo
{
    public partial class frmChocolateBoxes : Form
    {
        public frmChocolateBoxes()
        {
            InitializeComponent();

            lblReward.Hide();
        }

        private void btnGetReward_Click(object sender, EventArgs e)
        {
            const int MAX_VALUE = 20, MIN_VALUE = 0, MED_VALUE = 10;
            int chocolatebox;

            chocolatebox = int.Parse(txtNumbers.Text);

            if (MAX_VALUE < chocolatebox)
                lblReward.Text = " You get a prize";
            else if (MED_VALUE < chocolatebox)
                lblReward.Text = " you get a small prize";
            else if (MIN_VALUE == chocolatebox)
                lblReward.Text = " sell a chocolate box next time";

            lblReward.Show();

        }
    }
}

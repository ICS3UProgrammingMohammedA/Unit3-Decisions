/*
 * Created by: Mohammed 
 * Created on: Day-Month-Year2018-10-11 ICS3U Programming
 * Daily Assignment – Day #17 - Name of Program
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

namespace RandomNumberMoA
{
    public partial class frmRandomNumber : Form
    {
        public frmRandomNumber()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            //declare the constant and variable
            const int MIN_NUM = 1;
            const int MAX_NUM = 10;
            int aRandomNumber;
            Random random = new Random();

             //get a random number
            aRandomNumber = random.Next(MIN_NUM, MAX_NUM+1);

            //assign the random number to the label
            lblRandomAnswer.Text = Convert.ToString(aRandomNumber);
        
        }
    }
}

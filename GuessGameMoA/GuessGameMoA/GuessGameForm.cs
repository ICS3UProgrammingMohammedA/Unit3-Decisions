/*
     * Created by: Mohammed Alnajeh
     * Created on: 2018-10-10
     * Created for: ICS3U Programming
     * Daily Assignment – Day #11 - Name of Program
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

namespace GuessGameMoA
{
    public partial class GuessGameForm : Form
    {
        public GuessGameForm()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            //declaring the constant and variables
            int GuessNumber;
            const int THENUMBER = 21;
            GuessNumber = int.Parse(txtGuessNumber.Text);
        }
    }
}

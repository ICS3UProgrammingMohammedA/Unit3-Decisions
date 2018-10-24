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
            const int MAX_STUDENTS = 25;
            const int THENUMBER = 21;

            GuessNumber = int.Parse(txtGuessNumber.Text);

            Console.Write("*** GuessNumber = " + GuessNumber);

            //if the number of students enterned is greater than the max capacity, Display " Too many Students"
            if (GuessNumber > MAX_STUDENTS)
            {
                lblCorrectGuess.Text = "Too Many Students";
            }

            else if (GuessNumber == THENUMBER)
            {
                lblCorrectGuess.Text = "Correct Guess";
            }

            else if (GuessNumber < MAX_STUDENTS)
            {
                lblCorrectGuess.Text = "Wrong Guess Plaese Try Again";
            }
            lblCorrectGuess.Show();
        }

        private void GuessGameForm_Load(object sender, EventArgs e)
        {
            //this is to hide the labels before the user guess
            lblCorrectGuess.Hide();  
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            lblCorrectGuess.Hide();
  
        }
    }
}

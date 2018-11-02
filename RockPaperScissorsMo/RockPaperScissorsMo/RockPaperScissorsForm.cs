/*
 * Created by: Mohammed Alnajeh
 * Created on: 2018-11-02
 * Created for: ICS3U Programming
 * Daily Assignment – Day #18 - Rock, Paper, Scissors
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

namespace RockPaperScissorsMo
{
    public partial class frmRockPaperScissors : Form
    {
        //declare global vaiables and constants
        const int MIN_VALUE = 1;
        const int MAX_VALUE = 3;
        Random randomNumberGenerater;

        public frmRockPaperScissors()
        {
            InitializeComponent();

            //create the random number generater object
            randomNumberGenerater = new Random();

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //declare local variables and constants
            int playerChoice, computerChoice;
            const int ROCK = 1;
            const int PAPER = 2;
            const int SCISSORS = 3;

            //get the user's selcetion, if there is no selection set it to 0
            if (radRock.Checked == true)
            {
                computerChoice = ROCK;
                lblScore.Text = "DRAW";
            }
            else if (radPaper.Checked == true)
            {
                computerChoice = PAPER;
                lblScore.Text = "Computer wins";
            }
            else if (radScissors.Checked == true)
            {
                computerChoice = SCISSORS;
                lblScore.Text = "Player wins";
            }
            else
            {
                computerChoice = 0;
            }

            //Randomly generate a number between 1 and 3, Representing ROCK, PAPER or SCISSORS
            computerChoice = randomNumberGenerater.Next(MIN_VALUE, MAX_VALUE + 1);

            //set the radio button for the computer's choice
            if (computerChoice == ROCK)
            {
                this.radRockComp.Checked = true;
                
            }
            else if (computerChoice == PAPER)
            {
                this.radPaperComp.Checked = true;
                
            }
            else if (computerChoice == SCISSORS) 
            {
                this.radScissorsComp.Checked = true;
                
            }

            lblScore.Show();

        }

        private void frmRockPaperScissors_Load(object sender, EventArgs e)
        {
            lblScore.Hide();
        }
    }

}







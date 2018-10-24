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
                playerChoice = ROCK;
            }
            else if (radPaper.Checked == true)
            {
                playerChoice = PAPER;
            }
            else if (radScissors.Checked == true)
            {
                playerChoice = SCISSORS;
            }
            else
            {
                playerChoice = 0;
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
            computerChoice = SCISSORS;

        }   



    }

}







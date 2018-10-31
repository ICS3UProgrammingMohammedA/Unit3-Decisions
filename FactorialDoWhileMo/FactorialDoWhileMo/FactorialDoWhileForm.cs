/*
 * Created by: Mohammed Alnajeh
 * Created on: 2018-10-31
 * Created for: ICS3U Programming
 * Daily Assignment – Day #20 - Factorial Do While
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

namespace FactorialDoWhileMo
{
    public partial class frmFactorialDoWhile : Form
    {
        public frmFactorialDoWhile()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local variables
            Double factorialAnswer;
            Double FactorialNumber;
            int factorialCounter;

            //clear the items from the listbox
            this.lstNumbers.Items.Clear();

            //initialize the final answer to 1
            factorialAnswer = 1;

            //get the number from the user 
            FactorialNumber = Convert.ToDouble(this.txtNumber.Text);

            //set the counter to 0 
            factorialCounter = 0;

            //multiply the counter by the next incremented number until it reaches the user's number 
            do
            {
                //increment the counter by 1
                factorialCounter = factorialCounter + 1;

                //list the counter number in the listbox for the user to see
                lstNumbers.Items.Add(factorialCounter);

                //multiplay the counter by the answer
                factorialAnswer = factorialAnswer * factorialCounter;

            } while (factorialCounter < FactorialNumber);

            //convert the factorialAnswer to a string and insert it into the label
            this.lblAnswer.Text = this.txtNumber.Text + "! = " + Convert.ToString(factorialAnswer);
        }
    }
}

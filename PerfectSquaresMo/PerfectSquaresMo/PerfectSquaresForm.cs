/*
 * Created by: Mohammed Alnajeh
 * Created on: 2018-11-27
 * Created for: ICS3U Programming
 * Daily Assignment – Day # - Name of Program
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

namespace PerfectSquaresMo
{
    public partial class frmPerfectSquares : Form
    {
        public frmPerfectSquares()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Declare local variables
            int endingValue;
            int Value;
            Double squareRootAsDouble;
            int squareRootAsInteger;

            //set the initials values
            Value = 1;

            //clear all items from the list box
            this.lstPerfectSquares.Items.Clear();

            //get the user's end value selection from the number up-down box
            endingValue = Convert.ToInt32(this.nudNumbers.Value);

            //continue stating any perfect squares between the min value and the user's selected end value
            while (Value <= endingValue)
            {
                //take the square root of the value
                squareRootAsDouble = Math.Sqrt(Value);

                //convert the double to an integer
                squareRootAsInteger = Convert.ToInt32(squareRootAsDouble);

                //the only way for both the decimal and the integer to be equal is if the value was a perfect square
                if ( squareRootAsInteger == squareRootAsDouble)
                {
                    this.lstPerfectSquares.Items.Add(Value + "is a perfect square");
                    //this.lstperfectSquares.SetSelected(numberOfPerfectSquares);
                    this.Refresh();
                }
                Value++;
            }

            
        }
    }
}

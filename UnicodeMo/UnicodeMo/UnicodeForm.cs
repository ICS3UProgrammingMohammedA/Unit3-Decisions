/*
 * Created by: Mohammed Alanjeh
 * Created on: 2018-11-05
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

namespace UnicodeMo
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local variables
            const int UNICODE_NUMBER = 90;
            int unicodeCounter;
            string  letters;


            lstNumbers.Items.Clear();

            for (unicodeCounter = 65; unicodeCounter <= UNICODE_NUMBER; unicodeCounter++) 
            {
                letters = char.ConvertFromUtf32(unicodeCounter);

                lstNumbers.Items.Add(letters + "->" + unicodeCounter);
            }
        }
    }
}

/*
 * Created by: Mohammed Alnajeh
 * Created on: 2018-11-30
 * Created for: ICS3U Programming
 * Daily Assignment – Day #28 - Numbers Nested Loops
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

namespace NestedLoopsMo
{
    public partial class frmNestedLoops : Form
    {
        public frmNestedLoops()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //declare local variables
            const int UNICODE_CAPS = 90, UNICODE_LOW = 122;
            int unicode_counter_caps, unicode_counter_low;
            string characterBig, charactersmall;

            //clear listbox
            this.lstAlphabets.Items.Clear();

            for (unicode_counter_caps = 65; unicode_counter_caps <= UNICODE_CAPS;  unicode_counter_caps++)
            {
                for (unicode_counter_low = 97; unicode_counter_low <= UNICODE_LOW; unicode_counter_low++)
                {
                   characterBig = char.ConvertFromUtf32(unicode_counter_caps);

                    charactersmall = char.ConvertFromUtf32(unicode_counter_low);

                    this.lstAlphabets.Items.Add(characterBig + " -> " + charactersmall);
                    
                }
            }
        }
    }
}

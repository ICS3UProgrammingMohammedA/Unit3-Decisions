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
            int CAPalphabets = 65;
            int Smallalphabets = 97;
            int Alphabetscounter=0;
            string alphabets;

            //clear listbox
            this.lstAlphabets.Items.Clear();

            for (Alphabetscounter = 65; Alphabetscounter <= CAPalphabets; Alphabetscounter++)
            {
                for (Alphabetscounter = 97; Alphabetscounter <= Smallalphabets; Alphabetscounter++)
                {
                   alphabets = char.ConvertFromUtf32(Alphabetscounter);

                    this.lstAlphabets.Items.Add(CAPalphabets + " -> " + Smallalphabets);
                    
                }
            }
        }
    }
}

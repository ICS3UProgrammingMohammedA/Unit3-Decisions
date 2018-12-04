using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlObjectsMo
{
    public partial class frmControlObject : Form
    {
        public frmControlObject()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            foreach (Control Control in this.Controls)
            {
                if (Control.GetType() == typeof(Label))
                {
                    Control.BackColor = Color.Red;
                    Control.BackColor = Color.Black;
                }
                
            }
        }

        private void lblBlack_Click(object sender, EventArgs e)
        {
            //if (Control.GetType() == typeof(Button))
            {
                //Control.BackColor = Color.Black;
                //Control.BackColor = Color.Black;
            }
        }
    }
}

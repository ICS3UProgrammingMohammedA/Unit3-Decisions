using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//add the following library to use the sleep timer
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WalkingManMoA
{
    public partial class frmWalkingMan : Form
    {
        public frmWalkingMan()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWalk_Click(object sender, EventArgs e)
        {
            const int MAX_FRAMES = 10;
            int pictureFrameCounter = 1;
        }
    }
}

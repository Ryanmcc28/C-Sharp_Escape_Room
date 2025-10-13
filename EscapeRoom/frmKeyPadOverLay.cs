using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EscapeRoom
{
    public partial class frmKeyPadOverLay : Form
    {
        public frmKeyPadOverLay()
        {
            InitializeComponent();
        }

        private void frmKeyPadOverLay_Load(object sender, EventArgs e)
        {

        }


        int code = 42513;

        int one;
        int two;
        int three;
        int four;
        int five;





        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

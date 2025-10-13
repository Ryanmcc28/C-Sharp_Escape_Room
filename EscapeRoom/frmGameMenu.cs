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
    public partial class frmGameMenu : Form
    {
        public frmGameMenu()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Knight knight = new Knight();
            Globals.Player = knight;

            this.Hide();
            new frmStorageRoom().Show();

        }
    }
}

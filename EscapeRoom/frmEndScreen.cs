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
    public partial class frmEndScreen : Form
    {
        public frmEndScreen()
        {
            InitializeComponent();
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnRetry_Click(object sender, EventArgs e)
        {
            if (Globals.Player.KnightLocation == "StorageRoom" || Globals.Player.KnightLocation == "StorageRoom2")
            {
                this.Hide();
                new frmStorageRoom().Show();
            }

            if (Globals.Player.KnightLocation == "KingsQuarters")
            {
                this.Hide();
                new frmKingsQuarters().Show();
            }

            if (Globals.Player.KnightLocation == "Basement")
            {
                this.Hide();
                new frmBasement().Show();
            }

            if (Globals.Player.KnightLocation == "Dungeon")
            {
                this.Hide();
                new frmDungeon().Show();
            }

            if (Globals.Player.KnightLocation == "Roof")
            {
                this.Hide();
                new frmRoof().Show();
            }

            if (Globals.Player.KnightLocation == "Roof2")
            {
                this.Hide();
                new frmRoof2().Show();
            }
        }
        private void frmEndScreen_Load(object sender, EventArgs e)
        {
            if (Globals.Player.KnightLocation == "Forest")
            {
                label1.Text = "YOU ESCAPED";
                label1.Left -= 35;
                btnRetry.Visible = false;
            }
        }
    }
}

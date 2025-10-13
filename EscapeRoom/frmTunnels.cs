using EscapeRoom.Properties;
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
    public partial class frmTunnels : Form
    {
        public frmTunnels()
        {
            InitializeComponent();
        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            pictureBox2.Left += 7;

            if (pictureBox2.Bounds.IntersectsWith(pctVent.Bounds))
            {
                pictureBox2.Left -= 7;
                if (Globals.Player.KnightLocation == "StorageRoom2")
                {
                    this.Hide();
                    new frmRoof2().Show();
                    tmrMain.Stop();
                }
                if (Globals.Player.KnightLocation == "StorageRoom" || Globals.Player.KnightLocation == "Dungeon")
                {
                    this.Hide();
                    new frmKingsQuarters().Show();
                    tmrMain.Stop();
                }
                if (Globals.Player.KnightLocation == "Basement")
                {
                    this.Hide();
                    new frmStorageRoom().Show();
                    tmrMain.Stop();
                }
            }
        }

        private void frmTunnels_Load(object sender, EventArgs e)
        {

        }
    }
}

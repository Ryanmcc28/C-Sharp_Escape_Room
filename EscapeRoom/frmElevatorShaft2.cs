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
    public partial class frmElevatorShaft2 : Form
    {
        public frmElevatorShaft2()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            pctElevator.Top += 4;
            pctKnight.Top += 4;

            if (pctElevator.Top >= 1080 && Globals.Player.KnightLocation == "Roof")
            {
                this.Hide();
                new frmKingsQuarters().Show();
                timer1.Enabled = false;
                return;
            }


            if (pctElevator.Top >= 1080 && Globals.Player.KnightLocation == "KingsQuarters")
            {
                this.Hide();
                new frmBasement().Show();
                timer1.Enabled = false;
                return;
            }
        }
        private void frmElevatorShaft2_Load(object sender, EventArgs e)
        {

            switch (Globals.Player.Upgraded)
            {
                case true:
                    pctKnight.Image = Resources.BIG_knight;
                    pctKnight.Height += 25;
                    pctKnight.Top -= 25;
                    break;
                case false:
                    pctKnight.Image = Resources.knight;
                    break;
            }
        }
    }
}

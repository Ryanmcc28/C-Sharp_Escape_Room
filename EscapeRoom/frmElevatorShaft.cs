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
    public partial class frmElevatorShaft : Form
    {
        public frmElevatorShaft()
        {
            InitializeComponent();
        }

        private void frmElevatorShaft_Load(object sender, EventArgs e)
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
        private void timer1_Tick(object sender, EventArgs e)
        {
            pctElevator.Top -= 4;
            pctKnight.Top -= 4;

            if (pctElevator.Top <= 0 && Globals.Player.KnightLocation == "KingsQuarters")
            {
                this.Hide();
                new frmRoof().Show();
                timer1.Enabled = false;
            }

            if (pctElevator.Top <= 0 && Globals.Player.KnightLocation == "Basement")
            {
                this.Hide();
                new frmKingsQuarters().Show();
                timer1.Enabled = false;
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}

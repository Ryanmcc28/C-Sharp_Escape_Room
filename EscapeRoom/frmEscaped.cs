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
    public partial class frmEscaped : Form
    {
        public frmEscaped()
        {
            InitializeComponent();
        }

        bool a = false;
        bool d = false;

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            if (a == true && pctKnight.Left > 0)
            {
                pctKnight.Left -= 7;
                Globals.direction = "left";


                pctForesta.Left += 4;
                pctForestb.Left += 4;


                if (pctKnight.Image != Resources.BIG_knight_Flipped || pctKnight.Image != Resources.knight_reversed)
                {
                    switch (Globals.Player.Upgraded)
                    {
                        case true:
                            pctKnight.Image = Resources.BIG_knight_Flipped;
                            break;
                        case false:
                            pctKnight.Image = Resources.knight_reversed;
                            break;
                    }
                }

            }
            if (d == true && pctKnight.Right < 1920)
            {
                Globals.direction = "right";
                pctKnight.Left += 7;
                pctForesta.Left -= 4;
                pctForestb.Left -= 4;

                if (pctKnight.Image != Resources.knight || pctKnight.Image != Resources.BIG_knight)
                {
                    switch (Globals.Player.Upgraded)
                    {
                        case true:
                            pctKnight.Image = Resources.BIG_knight;
                            break;
                        case false:
                            pctKnight.Image = Resources.knight;
                            break;
                    }
                }

            }

            if (pctKnight.Right >= 1920)
            {
                this.Hide();
                new frmEndScreen().Show();
                tmrMain.Enabled = false;
            }

        }
        private void frmEscaped_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.A)
            {
                a = true;
            }

            if (e.KeyCode == Keys.D)
            {
                d = true;
            }
        }
        private void frmEscaped_Load(object sender, EventArgs e)
        {
            Globals.Player.KnightLocation = "Forest";

        }
        private void frmEscaped_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                a = false;
            }
            if (e.KeyCode == Keys.D)
            {
                d = false;
            }
        }

        private void pctForesta_Click(object sender, EventArgs e)
        {

        }
    }
}

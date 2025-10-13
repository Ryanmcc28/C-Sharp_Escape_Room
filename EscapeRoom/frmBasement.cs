using EscapeRoom.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace EscapeRoom
{
    public partial class frmBasement : Form
    {
        public frmBasement()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        bool w = false;
        bool a = false;
        bool s = false;
        bool d = false;
        bool E = false;
        bool q = false;
        bool t = false;

        int count = 0;
        bool gravity;

        int time;

        bool inMotion = false;
        bool inMotionDown = false;
        bool stopWhenLevel = false;

        bool Suspended = false;


        private void tmrMain_Tick(object sender, EventArgs e)
        {

            gravity = true;

            if (Globals.Player.KeySlot1 == true)
            {
                pctKeyinv1.Image = Resources.FinalKey1;
            }
            if (Globals.Player.KeySlot2 == true)
            {
                pctKeyInv2.Image = Resources.FinalKey2;
            }
            if (Globals.Player.KeySlot3 == true)
            {
                pctKeyInv3.Image = Resources.FinalKey3;
            }
            if (Globals.Player.KeySlot4 == true)
            {
                pctKeyInv4.Image = Resources.FinalKey4;
            }
            if (pctKnight.Bounds.IntersectsWith(pctFloor.Bounds) || pctKnight.Bounds.IntersectsWith(pctElevator.Bounds))
            {
                gravity = false;
            }
            if (pctKnight.Bounds.IntersectsWith(pctGate.Bounds))
            {
                d = false;
            }
            if (a == true && pctKnight.Left > 0)
            {
                pctKnight.Left -= 4;
                Globals.direction = "left";

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
                pctKnight.Left += 4;
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
            if (t == true)
            {
                pctGuide.Visible = true;
            }
            if (t == false)
            {
                pctGuide.Visible = false;
            }

            switch (Globals.Player.InventorySlot1)
            {
                case "Axe":
                    pctInv1.Image = Resources.axe;
                    Globals.axeNum = 1;
                    break;
                case "Pole":
                    pctInv1.Image = Resources.Metal_pole;
                    Globals.poleNum = 1;
                    break;
                case "Ladder":
                    pctInv1.Image = Resources.Half_Ladder;
                    Globals.ladderNum = 1;
                    break;
                case "Key":
                    pctInv1.Image = Resources.Wooden_Chest_Key;
                    Globals.keyNum = 1;
                    break;
            }
            switch (Globals.Player.InventorySlot2)
            {
                case "Axe":
                    pctInv2.Image = Resources.axe;
                    Globals.axeNum = 2;
                    break;
                case "Pole":
                    pctInv2.Image = Resources.Metal_pole;
                    Globals.poleNum = 2;
                    break;
                case "Ladder":
                    pctInv2.Image = Resources.Half_Ladder;
                    Globals.ladderNum = 2;
                    break;
                case "Key":
                    pctInv2.Image = Resources.Wooden_Chest_Key;
                    Globals.keyNum = 2;
                    break;
            }
            switch (Globals.Player.InventorySlot3)
            {
                case "Axe":
                    pctInv3.Image = Resources.axe;
                    Globals.axeNum = 3;
                    break;
                case "Pole":
                    pctInv3.Image = Resources.Metal_pole;
                    Globals.poleNum = 3;
                    break;
                case "Ladder":
                    pctInv3.Image = Resources.Half_Ladder;
                    Globals.ladderNum = 3;
                    break;
                case "Key":
                    pctInv3.Image = Resources.Wooden_Chest_Key;
                    Globals.keyNum = 3;
                    break;
            }
            switch (Globals.Player.InventorySlot4)
            {
                case "Axe":
                    pctInv4.Image = Resources.axe;
                    Globals.axeNum = 4;
                    break;
                case "Pole":
                    pctInv4.Image = Resources.Metal_pole;
                    Globals.poleNum = 4;
                    break;
                case "Ladder":
                    pctInv4.Image = Resources.Half_Ladder;
                    Globals.ladderNum = 4;
                    break;
                case "Key":
                    pctInv4.Image = Resources.Wooden_Chest_Key;
                    Globals.keyNum = 4;
                    break;
            }
            switch (Globals.Player.InventorySlot5)
            {
                case "Axe":
                    pctInv5.Image = Resources.axe;
                    Globals.axeNum = 5;
                    break;
                case "Pole":
                    pctInv5.Image = Resources.Metal_pole;
                    Globals.poleNum = 5;
                    break;
                case "Ladder":
                    pctInv5.Image = Resources.Half_Ladder;
                    Globals.ladderNum = 5;
                    break;
                case "Key":
                    pctInv5.Image = Resources.Wooden_Chest_Key;
                    Globals.keyNum = 5;
                    break;
            }

            /////////////////////////////

            if (pctKnight.Bounds.IntersectsWith(pctVent.Bounds) && E == true)
            {
                switch (Globals.Player.Upgraded)
                {
                    case true:
                        tmrSpeach.Enabled = true;
                        lblSpeach.Text = "I CANNOT FIT";
                        break;
                    case false:
                        this.Hide();
                        new frmTunnels().Show();
                        tmrMain.Enabled = false;
                        break;
                }
            }
            if (pctKnight.Bounds.IntersectsWith(pctGate.Bounds)  && E == true)
            {
                txtboxCode.Visible = true;
                lblCode.Visible = true;
            }
            if (txtboxCode.Text.ToLower() == "hset")
            {
                txtboxCode.Visible = false;
                txtboxCode.Enabled = false;
                lblCode.Visible = false;
                pctGate.Top -= 3;
            }
            if (pctKnight.Bounds.IntersectsWith(pctFloor.Bounds) || pctKnight.Bounds.IntersectsWith(pctElevator.Bounds) || pctKnight.Bounds.IntersectsWith(pctFloor2.Bounds))
            {
                gravity = false;
            }
            if (pctKnight.Bounds.IntersectsWith(pctElevator.Bounds) && E == true)
            {
                inMotion = true;
            }
            if (inMotionDown == true)
            {
                inMotion = false;
                pctElevator.Top += 5;

                a = false;

                if (pctKnight.Bounds.IntersectsWith(pctElevator.Bounds))
                {
                    pctKnight.Top += 5;
                }

                if (pctElevator.Top >= pctFloor.Top && stopWhenLevel == true)
                {
                    inMotionDown = false;
                    stopWhenLevel = false;
                }
            }
            if (inMotion == true)
            {
                inMotionDown = false;

                pctElevator.Top -= 5;
                if (pctKnight.Bounds.IntersectsWith(pctElevator.Bounds))
                {
                    pctKnight.Top -= 5;
                }

                if (pctElevator.Top >= pctFloor.Top && stopWhenLevel == true)
                {
                    inMotionDown = false;
                    stopWhenLevel = false;
                }
            }
            if (pctKnight.Bounds.IntersectsWith(pctKey3.Bounds) && E == true)
            {
                Globals.Player.KeySlot3 = true;
                pctKey3.Visible = false;
                Globals.basementKeyTaken = true;
            }
            if (pctKnight.Top <= 0 && inMotion == true)
            {
                this.Hide();
                new frmElevatorShaft().Show();
                tmrMain.Enabled = false;
            }
            if (pctKnight.Bounds.IntersectsWith(pctKeyCollect.Bounds) && E == true && Globals.Player.Upgraded == false)
            {
                lblSpeach.Text = "IM NOT TALL ENOUGH TO REACH IT";
                tmrSpeach.Enabled = true;
            }
            if (pctKnight.Bounds.IntersectsWith(pctGate.Bounds) && E == true)
            {
                lblSpeach.Text = "I NEED TO INPUT A CODE";
                tmrSpeach.Enabled = true;
            }
            if (Globals.basementKeyTaken == true)
            {
                tmrSecret.Enabled = true;
            }

            if (pctKnight.Top >= 1100)
            {
                this.Hide();
                new frmDungeon().Show();
                tmrMain.Enabled = false;
            }
            E = false;

            /////////////////////////////

            if (gravity == true)
            {
                pctKnight.Top += 5;
            }

            if (pctInv1.Image == null)
            {
                Globals.nextInventorySlot = 1;
                E = false;
                return;
            }
            if (pctInv2.Image == null)
            {
                Globals.nextInventorySlot = 2;
                E = false;
                return;
            }
            if (pctInv3.Image == null)
            {
                Globals.nextInventorySlot = 3;
                E = false;
                return;
            }
            if (pctInv4.Image == null)
            {
                Globals.nextInventorySlot = 4;
                E = false;
                return;
            }
            if (pctInv5.Image == null)
            {
                Globals.nextInventorySlot = 5;
                E = false;
                return;
            }
        }

        private void frmBasement_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                w = true;
            }

            if (e.KeyCode == Keys.A)
            {
                a = true;
            }

            if (e.KeyCode == Keys.S)
            {
                s = true;
            }

            if (e.KeyCode == Keys.R && Globals.transformable)
            {
                switch (Globals.Player.Upgraded)
                {
                    case true:
                        Globals.Player.Upgraded = false;
                        pctKnight.Height -= 25;
                        pctKnight.Top += 25;
                        switch (Globals.direction)
                        {
                            case "left":
                                pctKnight.Image = Resources.knight_reversed;
                                break;
                            case "right":
                                pctKnight.Image = Resources.knight;
                                break;
                        }
                        break;
                    case false:
                        Globals.Player.Upgraded = true;
                        pctKnight.Height += 25;
                        pctKnight.Top -= 25;
                        switch (Globals.direction)
                        {
                            case "left":
                                pctKnight.Image = Resources.BIG_knight_Flipped;
                                break;
                            case "right":
                                pctKnight.Image = Resources.BIG_knight;
                                break;
                        }
                        break;
                }
            }
            if (e.KeyCode == Keys.D)
            {
                d = true;
            }

            if (e.KeyCode == Keys.E)
            {
                E = true;
            }

            if (e.KeyCode == Keys.Q)
            {
                q = true;
            }

            if (e.KeyCode == Keys.T)
            {
                t = true;
            }
            if (e.KeyCode == Keys.Escape)
            {
                new frmPauseMenu().Show();
            }

            if (e.KeyCode == Keys.Right)
            {
                ++Globals.SelectedItemInInventory;
            }

            if (e.KeyCode == Keys.Left)
            {
                --Globals.SelectedItemInInventory;
            }

            if (Globals.SelectedItemInInventory == 0 && Suspended == false)
            {
                Globals.SelectedItemInInventory = 5;
            }

            if (Globals.SelectedItemInInventory == 6 && Suspended == false)
            {
                Globals.SelectedItemInInventory = 1;
            }

            if (Globals.SelectedItemInInventory == 1 && Suspended == false)
            {
                pctInv1.BackColor = Color.White;
                pctInv2.BackColor = Color.Gray;
                pctInv3.BackColor = Color.Gray;
                pctInv4.BackColor = Color.Gray;
                pctInv5.BackColor = Color.Gray;
            }

            if (Globals.SelectedItemInInventory == 2 && Suspended == false)
            {
                pctInv1.BackColor = Color.Gray;
                pctInv2.BackColor = Color.White;
                pctInv3.BackColor = Color.Gray;
                pctInv4.BackColor = Color.Gray;
                pctInv5.BackColor = Color.Gray;
            }

            if (Globals.SelectedItemInInventory == 3 && Suspended == false)
            {
                pctInv1.BackColor = Color.Gray;
                pctInv2.BackColor = Color.Gray;
                pctInv3.BackColor = Color.White;
                pctInv4.BackColor = Color.Gray;
                pctInv5.BackColor = Color.Gray;
            }

            if (Globals.SelectedItemInInventory == 4 && Suspended == false)
            {
                pctInv1.BackColor = Color.Gray;
                pctInv2.BackColor = Color.Gray;
                pctInv3.BackColor = Color.Gray;
                pctInv4.BackColor = Color.White;
                pctInv5.BackColor = Color.Gray;
            }

            if (Globals.SelectedItemInInventory == 5 && Suspended == false)
            {
                pctInv1.BackColor = Color.Gray;
                pctInv2.BackColor = Color.Gray;
                pctInv3.BackColor = Color.Gray;
                pctInv4.BackColor = Color.Gray;
                pctInv5.BackColor = Color.White;
            }
        }
        private void frmBasement_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                w = false;
            }

            if (e.KeyCode == Keys.A)
            {
                a = false;
            }

            if (e.KeyCode == Keys.S)
            {
                s = false;
            }

            if (e.KeyCode == Keys.D)
            {
                d = false;
            }

            if (e.KeyCode == Keys.Q)
            {
                q = false;
            }

            if (e.KeyCode == Keys.T)
            {
                t = false;
            }
        }
        private void frmBasement_Load(object sender, EventArgs e)
        {
            stopWhenLevel = true;
            inMotionDown = true;
            Globals.Player.KnightLocation = "Basement";
            lblSpeach.Text = "I NEED THAT KEY";
            tmrSpeach.Enabled = true;
            if (Globals.Player.Upgraded == true)
            {
                pctKnight.Height += 25;
                pctKnight.Top -= 25;
            }
        }
        private void tmrSpeach_Tick(object sender, EventArgs e)
        {

            ++time;
            pctFace.Visible = true;
            pctWordBox.Visible = true;
            lblSpeach.Visible = true;
            switch (Globals.Player.Upgraded)
            {
                case true:
                    pctFace.Image = Resources.BIG_HEAD;
                    break;
                case false:
                    pctFace.Image = Resources.knight_East;
                    break;
            }

            if (time == 100)
            {
                pctFace.Visible = false;
                pctWordBox.Visible = false;
                lblSpeach.Visible = false;
                time = 0;

                tmrSpeach.Enabled = false;
            }
        }
        private void tmrSecret_Tick(object sender, EventArgs e)
        {
            pctFloor3.Top += 2;
            pctElevator.Top += 2;

            pctChain1.Top -= 4;
            pctChain2.Top -= 4;
            pctChain3.Top -= 4;
            pctChain4.Top -= 4;


            if (pctFloor.Top <= 1200)
            {
                tmrSecret.Enabled = false;
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pctChain4_Click(object sender, EventArgs e)
        {

        }
    }
}

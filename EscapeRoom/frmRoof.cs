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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace EscapeRoom
{
    public partial class frmRoof : Form
    {
        public frmRoof()
        {
            InitializeComponent();
        }


        bool w = false;
        bool a = false;
        bool s = false;
        bool d = false;
        bool q = false;
        bool E = false;
        bool t = false;
        bool stopWhenLevel = true;

        int count = 0;

        int time;

        bool chainSnapped = false;

        bool inMotionUp = true;
        bool inMotionDown = false;

        bool Suspended = false;

        int axeCounter = 0;


        bool gravity;
        private void frmRoof_Load(object sender, EventArgs e)
        {
            tmrAxe.Enabled = false;
            Globals.Player.KnightLocation = "Roof";

            inMotionUp = true;

            lblSpeach.Text = "I SHOULDNT JUMP OFF IF I DONT WANT TO GET CAUGHT";
            tmrSpeach.Enabled = true;

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

            if (pctKnight.Bounds.IntersectsWith(pctElevator.Bounds) && q == true)
            {
                inMotionDown = true;   
            }
            if (pctKnight.Bounds.IntersectsWith(pctFloor.Bounds) || pctKnight.Bounds.IntersectsWith(pctElevator.Bounds) || pctKnight.Bounds.IntersectsWith(pctFloor2.Bounds))
            {
                gravity = false;
            }
            if (pctKnight.Bounds.IntersectsWith(pctThrowAxe.Bounds) && E == true && Globals.SelectedItemInInventory == Globals.axeNum)
            {
                ++axeCounter;
                tmrAxe.Enabled = true;
                pctThrowAxe.Visible = true;
                switch (Globals.axeNum)
                {
                    case 1:
                        Globals.Player.InventorySlot1 = "";
                        pctInv1.Image = null;
                        Globals.axeNum = 0;
                        break;
                    case 2:
                        Globals.Player.InventorySlot2 = "";
                        pctInv2.Image = null;
                        Globals.axeNum = 0;
                        break;
                    case 3:
                        Globals.Player.InventorySlot3 = "";
                        pctInv3.Image = null;
                        Globals.axeNum = 0;
                        break;
                    case 4:
                        Globals.Player.InventorySlot4 = "";
                        pctInv4.Image = null;
                        Globals.axeNum = 0;
                        break;
                    case 5:
                        Globals.Player.InventorySlot5 = "";
                        pctInv5.Image = null;
                        Globals.axeNum = 0;
                        break;
                }

            }
            if (pctThrowAxe.Bounds.IntersectsWith(pctChain.Bounds))
            {
                chainSnapped = true;

            }
            if (pctKnight.Bounds.IntersectsWith(pctThrowAxe.Bounds) && count == 0)
            {
                lblSpeach.Text = "I NEED TO THROW SOMETHING AT IT";
                tmrSpeach.Enabled = true;
                ++count;
            }
            if (pctKnight.Bottom >= 1080 && Globals.Player.Upgraded == false)
            {
                if (Globals.Player.Upgraded == false)
                {
                    this.Hide();
                    new frmEndScreen().Show();
                    tmrMain.Enabled = false;
                }

                if (Globals.Player.Upgraded == true)
                {
                    this.Hide();
                    Globals.Player.KnightLocation = "Roof2";
                    new frmKingsQuarters().Show();
                    tmrMain.Enabled = false;
                }

               
            }
            if (chainSnapped == true)
            {
                pctChain.Top += 9;
                Globals.HasKeyFallen = true;
                pctKey2.Top += 9;
            }
            if (inMotionUp == true)
            {
                inMotionDown = false;
                gravity = false;

                pctElevator.Top -= 5;
                if (pctKnight.Bounds.IntersectsWith(pctElevator.Bounds))
                {
                    pctKnight.Top -= 5;
                }
                if (pctElevator.Top <= pctFloor.Top + 4 && stopWhenLevel == true)
                {
                    inMotionUp = false;
                    stopWhenLevel = false;
                }
            }
            if (inMotionDown == true)
            {
                pctElevator.Top += 5;
                gravity = false;
                inMotionUp = false;
                pctKnight.Top += 5;
               
                if (pctKnight.Top >= 950)
                {

                    this.Hide();

                    new frmElevatorShaft2().Show();
                    tmrMain.Enabled = false;
                }

            }
            if (gravity == true)
            {
                pctKnight.Top += 5;
            }

            E = false;
            q = false;

            ////////////////////////////////

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

            E = false;
            q = false;
        }

        private void frmRoof_KeyDown(object sender, KeyEventArgs e)
        {
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

        private void frmRoof_KeyUp(object sender, KeyEventArgs e)
        {

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
        }

        private void tmrAxe_Tick(object sender, EventArgs e)
        {

            

            if (axeCounter == 1)
            {
                pctThrowAxe.Left += 40;
                pctThrowAxe.Image = Resources.taxe1;
                ++axeCounter;
                return;
            }

            if (axeCounter == 2)
            {
                pctThrowAxe.Left += 40;
                pctThrowAxe.Image = Resources.taxe2;
               ++ axeCounter;
                return;
            }

            if (axeCounter == 3)
            {

                pctThrowAxe.Left += 40;
                pctThrowAxe.Image = Resources.taxe3;

                

               axeCounter = 1 ; 
                return;
            }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

            if (time == 160)
            {
                pctFace.Visible = false;
                pctWordBox.Visible = false;
                lblSpeach.Visible = false;
                time = 0;

                tmrSpeach.Enabled = false;
            }
        }

        private void pctKnight_Click(object sender, EventArgs e)
        {

        }
    }
}
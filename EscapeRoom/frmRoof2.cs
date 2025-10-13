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
    public partial class frmRoof2 : Form
    {
        public frmRoof2()
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

        int time;
        int FlameTime = 0;

        bool Suspended = false;

        bool gravity;

        bool wizardSpeak = false;

        private void frmRoof2_KeyDown(object sender, KeyEventArgs e)
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

                if (e.KeyCode == Keys.D)
                {
                    d = true;
                }

            if (e.KeyCode == Keys.T && wizardSpeak == true)
            {
                t = true;
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

                if (e.KeyCode == Keys.E)
                {
                    E = true;
                }
                if (e.KeyCode == Keys.Q)
                {
                    q = true;
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
        private void frmRoof2_KeyUp(object sender, KeyEventArgs e)
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

                if (e.KeyCode == Keys.T && wizardSpeak == true)
                {
                    t = false;
                }
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
            if (pctKnight.Bounds.IntersectsWith(pctFloor.Bounds))
            {
                gravity = false;
            }
            if (gravity == true)
            {
                pctKnight.Top += 5;
            }
            if (pctKnight.Bounds.IntersectsWith(pctWizard.Bounds) && wizardSpeak == false)
            {
                a = false;
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

            if (pctKnight.Left <= 690 && Globals.Player.Upgraded == false)
            {
                Globals.Player.Upgraded = true;
                Globals.transformable = true;
                pctKnight.Top -= 25;
                pctKnight.Height += 25;
            }
            if (pctKnight.Bounds.IntersectsWith(pctWizard.Bounds) && wizardSpeak == false)
            {
                a = false;
            }
            if (pctKnight.Bounds.IntersectsWith(pctWizard.Bounds) && E == true && wizardSpeak == false)
            {
                lblSpeach.Text = "IF YOU ENTER THE FLAMES YOU WILL SURVIVE FALLS BUT WILL BE UNABLE TO FIT INTO VENTS";
                pctFace.Image = Resources.wizardHead;
                pctWordBox.Width = 1500;
                wizardSpeak = true;
              
                tmrSpeak.Enabled = true;
            }

            if (pctKnight.Top >= 1100)
            {
                this.Hide();
                new frmKingsQuarters().Show();
                tmrMain.Enabled = false;
            }


            ///////////////////////////////


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
        }
        private void frmRoof2_Load(object sender, EventArgs e)
        {
            Globals.Player.KnightLocation = "Roof2";
            lblSpeach.Text = "WHO IS THAT???";
            tmrSpeak.Enabled = true;

        }
        private void tmrFlame_Tick(object sender, EventArgs e)
        {
            if (FlameTime == 0)
            {
                pctFlame.Image = Resources.Flame1;
                ++FlameTime;
                return;  
            }

            if (FlameTime == 1)
            {
                pctFlame.Image = Resources.Flame2;
                ++FlameTime;
                return;
            }

            if (FlameTime == 2)
            {
                pctFlame.Image = Resources.Flame3;
                ++FlameTime;
                return;
            }

            if (FlameTime == 3)
            {
                pctFlame.Image = Resources.Flame4;
                ++FlameTime;
                return;
            }

            if (FlameTime == 4)
            {
                pctFlame.Image = Resources.Flame5;
                ++FlameTime;
                return;
            }

            if (FlameTime == 5)
            {
                pctFlame.Image = Resources.Flame6;
                ++FlameTime;
                return;
            }

            if (FlameTime == 6)
            {
                pctFlame.Image = Resources.Flame7;
                ++FlameTime;
                return;
            }

            if (FlameTime == 7)
            {
                pctFlame.Image = Resources.Flame8;
                FlameTime = 0;
                return;
            }

         
        }
        private void tmrSpeak_Tick(object sender, EventArgs e)
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

            if (wizardSpeak == false)
            {
                pctFace.Image = Resources.wizardHead;
            }

            if (time == 150)
            {
                pctFace.Visible = false;
                pctWordBox.Visible = false;
                lblSpeach.Visible = false;
                time = 0;
                pctWordBox.Width = 766;
                tmrSpeak.Enabled = false;
            }
        }
    }
}

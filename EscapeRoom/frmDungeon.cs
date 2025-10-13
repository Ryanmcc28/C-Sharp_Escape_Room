using EscapeRoom.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace EscapeRoom
{
    public partial class frmDungeon : Form
    {
        public frmDungeon()
        {
            InitializeComponent();
        }
        bool w = false;
        bool a = false;
        bool s = false;
        bool d = false;
        bool E = false;
        bool space = false;

        bool gravity;

        bool Suspended = false;

        int time;

        int wait = 0;

        int speed1 = 5;
        int speed2 = 6;
        int speed3 = 7;
        int speed4 = 8;

        int miniScore = 0;

        bool miniGame = false;

        int miniCount = 1;



        private void frmDungeon_KeyDown(object sender, KeyEventArgs e)
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

            if (e.KeyCode == Keys.Space)
            {
                space = true;
            }
        }
        private void frmDungeon_KeyUp(object sender, KeyEventArgs e)
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
            if (e.KeyCode == Keys.Space)
            {
                space = false;
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

            //////////////////////////////////

            if (pctKnight.Bounds.IntersectsWith(pctEnemy.Bounds))
            {
                this.Hide();
                new frmEndScreen().Show();
                tmrMain.Enabled = false;
            }
            if (pctKnight.Bounds.IntersectsWith(pctKey4.Bounds) && E == true)
            {
                lblSpeach.Text = "I NEED TO BE STEALTHY";
                tmrSpeach.Enabled = true;

                miniGame = true;
            }
            if (miniGame == true)
            {

                w = false;
                s = false;
               
              
                pctPart1.Visible = true;
                pctPart2.Visible = true;
                pctPart3.Visible = true;
                pctPart4.Visible = true;
                pctGoalA.Visible = true;
                pctGoalB.Visible = true;
                pctGoalC.Visible = true;
                pctGoalD.Visible = true;
                pctBorder.Visible = true;




                if (miniCount == 1)
                {
                    pctPart1.Top += speed1;
                }
                if (miniCount == 2)
                {
                    pctPart2.Top -= speed2;
                }
                if (miniCount == 3)
                {
                    pctPart3.Top += speed3;
                }
                if (miniCount == 4)
                {
                    pctPart4.Top -= speed4;
                }


                if (pctPart1.Top <= pctBorder.Top)
                {
                    speed1 = -speed1;
                }
                if (pctPart1.Bottom >= pctBorder.Bottom)
                {
                    speed1 = -speed1;
                }

                if (pctPart2.Top <= pctBorder.Top)
                {
                    speed2 = -speed2;
                }
                if (pctPart2.Bottom >= pctBorder.Bottom)
                {
                    speed2 = -speed2;
                }

                if (pctPart3.Top <= pctBorder.Top)
                {
                    speed3 = -speed3;
                }
                if (pctPart3.Bottom >= pctBorder.Bottom)
                {
                    speed3 = -speed3;
                }

                if (pctPart4.Top <= pctBorder.Top)
                {
                    speed4 = -speed4;
                }
                if (pctPart4.Bottom >= pctBorder.Bottom)
                {
                    speed4 = -speed4;
                }

                if (space == true)
                {
                    switch (miniCount)
                    {
                        case 1: 
                            if (pctPart1.Top > pctGoalA.Top && pctPart1.Bottom < pctGoalA.Bottom)
                            {
                                ++miniScore;
                                pctPart1.BackColor = Color.Green;
                            }
                            miniCount = 2;
                            space = false;
                            break;
                        case 2:
                            if (pctPart2.Top > pctGoalB.Top && pctPart2.Bottom < pctGoalB.Bottom)
                            {
                                ++miniScore;
                                pctPart2.BackColor = Color.Green;
                            }
                            miniCount = 3;
                            space = false;
                            break;
                        case 3:
                            if (pctPart3.Top > pctGoalC.Top && pctPart3.Bottom < pctGoalC.Bottom)
                            {
                                ++miniScore;
                                pctPart3.BackColor = Color.Green;
                            }
                            miniCount = 4;
                            space = false;
                            break;
                        case 4:
                            if (pctPart4.Top > pctGoalD.Top && pctPart4.Bottom < pctGoalD.Bottom)
                            {
                                ++miniScore;
                                pctPart3.BackColor = Color.Green;
                            }
                            space = false;

                            pctBorder.Visible = false;
                            pctPart1.Visible = false;
                            pctPart2.Visible = false;
                            pctPart3.Visible = false;
                            pctPart4.Visible = false;
                            pctGoalA.Visible = false;
                            pctGoalB.Visible = false;
                            pctGoalC.Visible = false;
                            pctGoalD.Visible = false;

                            miniGame = false;
                            Globals.miniGameCompleted = true;

                            break;
                    }
                }
            }
            if (miniScore >= 3 && Globals.miniGameCompleted == true && pctKnight.Bounds.IntersectsWith(pctKey4.Bounds))
            {
                Globals.Player.KeySlot4 = true;
                pctKey4.Top = 0;
                pctKey4.Visible = false;
                lblSpeach.Text = "HE DIDNT NOTICE";
                tmrSpeach.Enabled = true;
            }
            if (miniScore < 3 && Globals.miniGameCompleted == true)
            {
                pctKey4.Top = 0;
                pctKey4.Visible = false;
                pctExclamation.Visible = true;
                pctEnemy.Image = Resources.pixel_knight;
                tmrEnemy.Enabled = true;
                lblSpeach.Text = "OH NO I ALERTED HIM";


                tmrSpeach.Enabled = true;
               
            }
            if (pctKnight.Bounds.IntersectsWith(pctVent.Bounds) && E == true )
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

            //////////////////////////////////

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
        private void tmrEnemy_Tick(object sender, EventArgs e)
        {
            ++wait;

            if (wait >= 100)
            {
                pctExclamation.Visible = false;
                pctExclamation.Top = 1080;
                pctEnemy.Left += 12;
            }

            if (pctKnight.Bounds.IntersectsWith(pctEnemy.Bounds))
            {
                this.Hide();
                new frmEndScreen().Show();
                tmrMain.Enabled = false;
                tmrEnemy.Enabled = false;
            }

        }
        private void frmDungeon_Load(object sender, EventArgs e)
        {
            lblSpeach.Text = "I NEED TO TAKE HIS KEY";
            tmrSpeach.Enabled = true;
            Globals.Player.KnightLocation = "Dungeon";
            if (Globals.Player.Upgraded == true)
            {
                pctKnight.Height += 25;
                pctKnight.Top -= 25;
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


            if (time == 100)
            {
                pctFace.Visible = false;
                pctWordBox.Visible = false;
                lblSpeach.Visible = false;
                time = 0;

                tmrSpeach.Enabled = false;
            }
        }

        private void pctEnemy_Click(object sender, EventArgs e)
        {

        }
    }
}

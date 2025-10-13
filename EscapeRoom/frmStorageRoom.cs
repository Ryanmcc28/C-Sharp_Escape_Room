using EscapeRoom.Properties;
using Microsoft.VisualBasic.Devices;
using System.DirectoryServices.ActiveDirectory;
using System.IO.Pipes;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace EscapeRoom
{
    public partial class frmStorageRoom : Form
    {
        public frmStorageRoom()
        {
            InitializeComponent();          
        }

        bool w = false;
        bool a = false;
        bool s = false;
        bool d = false;
        bool E = false;
        bool t = false;

        bool Suspended = false;
      
        int oneCounter = 0;

        bool AxeAnim = false;

        bool chestOpen = false;

        bool LadderPlaced = false;

        bool gravity;
        bool fanbroken = false;

        int time = 0;


        private void Form1_Load(object sender, EventArgs e)
        {     
            gravity = false;
            lblSpeach.Text = "I NEED TO ESCAPE";
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

            if (Globals.Player.KnightLocation == "Basement")
            {
                pctKnight.Left = 1571;
                pctKnight.Top = 216;

                if (Globals.roomCleared == true)
                {
                    pctAxe.Top = 0;
                    pctKey.Top = 0;
                    pctWbox1.Top = 0;
                    pctPole.Top = 0;
                    pctWoodenChestClosed.Image = Resources.Open_Wooden_Chest;
                    pctLadderSpot.Visible = true;
                    pctFace.Image = Resources.Broken_Fan_Crates;
                    fanbroken = true;
                    pctLadderSpot.Image = Resources.ladder;
                }

                if (Globals.Player.KeySlot1 == true)
                {
                    pctFinalKey1.Visible = true;
                }

                Globals.Player.KnightLocation = "StorageRoom2";
                return;
            }
            Globals.Player.KnightLocation = "StorageRoom";
          
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
                if (pctKnight.Bounds.IntersectsWith(pctFloor.Bounds)||
                (pctKnight.Bounds.IntersectsWith(pctLadderSpot.Bounds) && LadderPlaced == true)||
                pctKnight.Bounds.IntersectsWith(pctLadder2b.Bounds)||
                pctKnight.Bounds.IntersectsWith(pctPlatform2.Bounds))
                {
                    gravity = false;
                }

            if (pctKnight.Bounds.IntersectsWith(pctPlatform.Bounds) && pctKnight.Bottom <= pctPlatform.Top + 5)
            {
                gravity = false;
            }
            if (pctKnight.Bounds.IntersectsWith(pctWbox1.Bounds))
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


            if (pctKnight.Bounds.IntersectsWith(pctWbox1.Bounds) && E == true && Globals.SelectedItemInInventory != Globals.axeNum)
            {
                lblSpeach.Text = "I NEED TO BREAK IT TO GET OVER";
                tmrSpeach.Enabled = true;
            }
            if (pctKnight.Bounds.IntersectsWith(pctAxe.Bounds) && E == true)
            {
                pctAxe.Left = 2000;
                pctAxe.Visible = false;
                lblSpeach.Text = "GOT AN AXE";
                tmrSpeach.Enabled = true;

                switch (Globals.nextInventorySlot)
                {
                    case 1:
                        Globals.Player.InventorySlot1 = "Axe";
                        break;
                    case 2:
                        Globals.Player.InventorySlot2 = "Axe";
                        break;
                    case 3:
                        Globals.Player.InventorySlot3 = "Axe";
                        break;
                    case 4:
                        Globals.Player.InventorySlot4 = "Axe";
                        break;
                    case 5:
                        Globals.Player.InventorySlot5 = "Axe";
                        break;
                }
            }
            if (Globals.keyNum != Globals.SelectedItemInInventory && E == true && pctKnight.Bounds.IntersectsWith(pctWoodenChestClosed.Bounds))
            {
                lblSpeach.Text = "I NEED A KEY";
                tmrSpeach.Enabled = true;
            }
            if (pctKnight.Bounds.IntersectsWith(pctWbox1.Bounds) && E == true && Globals.SelectedItemInInventory == Globals.axeNum)
            {
                pctWbox1.Visible = false;
                pctWbox1.Left = 2000;
                pctWbox1.Top = 0;
            }
            if (pctKnight.Bounds.IntersectsWith(pctKey.Bounds) && E == true)
            {
                lblSpeach.Text = "OBTAINED KEY";
                tmrSpeach.Enabled = true;
                pctKey.Left = 2000;
                switch (Globals.nextInventorySlot)
                {
                    case 1:
                        Globals.Player.InventorySlot1 = "Key";
                        break;
                    case 2:
                        Globals.Player.InventorySlot2 = "Key";
                        break;
                    case 3:
                        Globals.Player.InventorySlot3 = "Key";
                        break;
                    case 4:
                        Globals.Player.InventorySlot4 = "Key";
                        break;
                    case 5:
                        Globals.Player.InventorySlot5 = "Key";
                        break;
                }
                pctKey.Top = 0;
            }
            if (Globals.keyNum == Globals.SelectedItemInInventory && pctKnight.Bounds.IntersectsWith(pctWoodenChestClosed.Bounds) && E == true)
            {
                switch (Globals.keyNum)
                {
                    case 1:
                        Globals.Player.InventorySlot1 = "";
                        pctInv1.Image = null;
                        Globals.keyNum = 0;
                        break;
                    case 2:
                        Globals.Player.InventorySlot2 = "";
                        pctInv2.Image = null;
                        Globals.keyNum = 0;
                        break;
                    case 3:
                        Globals.Player.InventorySlot3 = "";
                        pctInv3.Image = null;
                        Globals.keyNum = 0;
                        break;
                    case 4:
                        Globals.Player.InventorySlot4 = "";
                        pctInv4.Image = null;
                        Globals.keyNum = 0;
                        break;
                    case 5:
                        Globals.Player.InventorySlot5 = "";
                        pctInv5.Image = null;
                        Globals.keyNum = 0;
                        break;

                }
                pctWoodenChestClosed.Image = Resources.Open_Wooden_Chest;
                chestOpen = true;
            }
            if (pctKnight.Bounds.IntersectsWith(pctWoodenChestClosed.Bounds) && E == true && chestOpen == true)
            {
                lblSpeach.Text = "OBTAINED A LADDER";
                tmrSpeach.Enabled = true;
                chestOpen = false;
                switch (Globals.nextInventorySlot)
                {
                    case 1:
                        Globals.Player.InventorySlot1 = "Ladder";
                        break;
                    case 2:
                        Globals.Player.InventorySlot2 = "Ladder";
                        break;
                    case 3:
                        Globals.Player.InventorySlot3 = "Ladder";
                        break;
                    case 4:
                        Globals.Player.InventorySlot4 = "Ladder";
                        break;
                    case 5:
                        Globals.Player.InventorySlot5 = "Ladder";
                        break;
                }
            }
            if (E == true && pctKnight.Bounds.IntersectsWith(pctLadderSpot.Bounds) && Globals.SelectedItemInInventory == Globals.ladderNum)
            {
                pctLadderSpot.Image = Resources.ladder;
                LadderPlaced = true;
                switch (Globals.ladderNum)
                {
                    case 1:
                        Globals.Player.InventorySlot1 = "";
                        pctInv1.Image = null;
                        Globals.ladderNum = 0;
                        break;
                    case 2:
                        Globals.Player.InventorySlot2 = "";
                        pctInv2.Image = null;
                        Globals.ladderNum = 0;
                        break;
                    case 3:
                        Globals.Player.InventorySlot3 = "";
                        pctInv3.Image = null;
                        Globals.ladderNum = 0;
                        break;
                    case 4:
                        Globals.Player.InventorySlot4 = "";
                        pctInv4.Image = null;
                        Globals.ladderNum = 0;
                        break;
                    case 5:
                        Globals.Player.InventorySlot5 = "";
                        pctInv5.Image = null;
                        Globals.ladderNum = 0;
                        break;

                }

            }
            if (pctKnight.Bounds.IntersectsWith(pctLadderSpot.Bounds) && LadderPlaced == true && w == true)
            {
                pctKnight.Top -= 6;

            }
            if (pctKnight.Bounds.IntersectsWith(pctLadderSpot.Bounds) && LadderPlaced == true && s == true && pctKnight.Bottom <= pctFloor.Top)
            {
                pctKnight.Top += 6;
            }
            if (pctKnight.Bounds.IntersectsWith(pctLadder2b.Bounds) && w == true)
            {
                pctKnight.Top -= 6;
            }
            if (pctKnight.Bounds.IntersectsWith(pctLadder2b.Bounds) && s == true && pctKnight.Bottom <= pctFloor.Top)
            {
                pctKnight.Top += 6;
            }
            if (pctKnight.Bounds.IntersectsWith(pctPole.Bounds) && E == true)
            {
                lblSpeach.Text = "OBTAINED A ROD";
                tmrSpeach.Enabled = true;
                pctPole.Visible = false;
                pctPole.Left = 2000;

                switch (Globals.nextInventorySlot)
                {
                    case 1:
                        Globals.poleNum = 1;
                        Globals.Player.InventorySlot1 = "Pole";
                        break;
                    case 2:
                        Globals.poleNum = 2;
                        Globals.Player.InventorySlot2 = "Pole";
                        break;
                    case 3:
                        Globals.poleNum = 3;
                        Globals.Player.InventorySlot3 = "Pole";
                        break;
                    case 4:
                        Globals.poleNum = 4;
                        Globals.Player.InventorySlot4 = "Pole";
                        break;
                    case 5:
                        Globals.poleNum = 5;
                        Globals.Player.InventorySlot5 = "Pole";
                        break;
                }
            }
            if (pctKnight.Bounds.IntersectsWith(pctLadder2b.Bounds) && Globals.SelectedItemInInventory == Globals.ladderNum && E == true)
            {
                lblSpeach.Text = "I CANT PUT THAT HERE";
                tmrSpeach.Enabled = true;
            }
            if (pctKnight.Bounds.IntersectsWith(pctFan.Bounds) && E == true &&  Globals.SelectedItemInInventory == Globals.poleNum)
            {
                pctFan.Image = Resources.Broken_Fan_Crates;
                lblSpeach.Text = "I BROKE THE FAN";
                tmrSpeach.Enabled = true;
                fanbroken = true;
                switch (Globals.poleNum)
                {
                    case 1:
                        Globals.Player.InventorySlot1 = "";
                        pctInv1.Image = null;
                        Globals.poleNum = 0;
                        break;
                    case 2:
                        Globals.Player.InventorySlot2 = "";
                        pctInv2.Image = null;
                        Globals.poleNum = 0;
                        break;
                    case 3:
                        Globals.Player.InventorySlot3 = "";
                        pctInv3.Image = null;
                        Globals.poleNum = 0;
                        break;
                    case 4:
                        Globals.Player.InventorySlot4 = "";
                        pctInv4.Image = null;
                        Globals.poleNum = 0;
                        break;
                    case 5:
                        Globals.Player.InventorySlot5 = "";
                        pctInv5.Image = null;
                        Globals.poleNum = 0;
                        break;
                }
               
            }
            if (pctKnight.Bounds.IntersectsWith(pctFinalKey1.Bounds) && E == true)
            {
                pctFinalKey1.Top = 0;
                Globals.Player.KeySlot1 = true;
                lblSpeach.Text = "FIRST ESCAPE KEY OBTAINED";
                tmrSpeach.Enabled = true;
            }
            if (pctKnight.Bounds.IntersectsWith(pctFan.Bounds) && E == true && fanbroken == true)
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
                        Globals.roomCleared = true;
                        tmrMain.Enabled = false;
                        break;
                }
            }
            if (pctKnight.Bounds.IntersectsWith(pctVent.Bounds) && E == true)
            {
                Globals.Player.KnightLocation = "StorageRoom2";
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


            ///////////////////////////////
            

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

            E = false;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
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

            if (e.KeyCode == Keys.D )
            {
                    d = true;
                
            }

            if (e.KeyCode == Keys.E)
            {
                E = true;
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
        private void Form1_KeyUp(object sender, KeyEventArgs e) 
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

            if (e.KeyCode == Keys.T)
            {
                t = false   ;
            }

        }
        private void tmrAnimations_Tick(object sender, EventArgs e)
        {
            if (AxeAnim == true)
            {
                pctAxe.Top -= 8;
                pctFinalKey1.Top -= 8;
                AxeAnim = false;
                return;
            }
            if (AxeAnim == false)
            {
                pctAxe.Top += 8;
                pctFinalKey1.Top += 8;
                AxeAnim = true;
                return;
            }
        }
        private void tmrKeyPad_Tick(object sender, EventArgs e)
        {
            ++oneCounter;
            tmrMain.Enabled = false;
            Suspended = true;
            
            if (oneCounter == 1)
            {
                pctInv1.BackColor = Color.Black;
                pctInv2.BackColor = Color.Black;
                pctInv3.BackColor = Color.Black;
                pctInv4.BackColor = Color.Black;
                pctInv5.BackColor = Color.Black;
              
            }
            if (oneCounter == 2)
            {
                pctInv1.BackColor = Color.Black;
                pctInv2.BackColor = Color.Black;
                pctInv3.BackColor = Color.Black;
                pctInv4.BackColor = Color.White;
                pctInv5.BackColor = Color.Black;
            }
            if (oneCounter == 3)
            {
                pctInv1.BackColor = Color.Black;
                pctInv2.BackColor = Color.White;
                pctInv3.BackColor = Color.Black;
                pctInv4.BackColor = Color.Black;
                pctInv5.BackColor = Color.Black;
            }
            if (oneCounter == 4)
            {
                pctInv1.BackColor = Color.Black;
                pctInv2.BackColor = Color.Black;
                pctInv3.BackColor = Color.Black;
                pctInv4.BackColor = Color.Black;
                pctInv5.BackColor = Color.White;
            }
            if (oneCounter == 5)
            {
                pctInv1.BackColor = Color.White;
                pctInv2.BackColor = Color.Black;
                pctInv3.BackColor = Color.Black;
                pctInv4.BackColor = Color.Black;
                pctInv5.BackColor = Color.Black;
            }
            if (oneCounter == 6)
            {
                pctInv1.BackColor = Color.Black;
                pctInv2.BackColor = Color.Black;
                pctInv3.BackColor = Color.White;
                pctInv4.BackColor = Color.Black;
                pctInv5.BackColor = Color.Black;
            }

            if (oneCounter == 7)
            {
                pctInv1.BackColor = Color.Gray;
                pctInv2.BackColor = Color.Gray;
                pctInv3.BackColor = Color.Gray;
                pctInv4.BackColor = Color.Gray;
                pctInv5.BackColor = Color.Gray;
                oneCounter = 0;
                tmrMain.Enabled = true;
                Suspended = false;
                tmrKeyPad.Enabled = false;
            }
        }
        private void tmrSpeach_Tick(object sender, EventArgs e)
        {
            ++ time;

            switch (Globals.Player.Upgraded)
            {
                case true:
                    pctFace.Image = Resources.BIG_HEAD;
                    break;
                case false:
                    pctFace.Image = Resources.knight_East;
                    break;
            }

            pctFace.Visible = true;
            pctWordBox.Visible = true;
            lblSpeach.Visible = true;

            if (time == 75)
            {
                pctFace.Visible = false;
                pctWordBox.Visible = false;
                lblSpeach.Visible = false;
                time = 0;

                tmrSpeach.Enabled = false;
            }
        }
    }
}

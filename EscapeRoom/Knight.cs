using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    internal class Knight
    {
        private string inventorySlot1;
        private string inventorySlot2;
        private string inventorySlot3;
        private string inventorySlot4;
        private string inventorySlot5;

        private bool upgraded;

        private bool keySlot1;
        private bool keySlot2;
        private bool keySlot3;
        private bool keySlot4;

        private string knightLocation;

        public Knight()
        {
            inventorySlot1 = "";
            inventorySlot2 = "";
            inventorySlot3 = "";
            inventorySlot4 = "";
            inventorySlot5 = "";

            upgraded = false;

            keySlot1 = false;
            keySlot2 = false;
            keySlot3 = false;
            keySlot4 = false;

            knightLocation = "";

        }


        public string InventorySlot1
        {
            get { return inventorySlot1; }
            set { inventorySlot1 = value; }
        }
        public string InventorySlot2
        {
            get { return inventorySlot2; }
            set { inventorySlot2 = value; }
        }
        public string InventorySlot3
        {
            get { return inventorySlot3; }
            set { inventorySlot3 = value; }
        }
        public string InventorySlot4
        {
            get { return inventorySlot4; }
            set { inventorySlot4 = value; }
        }
        public string InventorySlot5
        {
            get { return inventorySlot5; }
            set { inventorySlot5 = value; }
        }

        public bool Upgraded
        {
            get { return upgraded;}
            set { upgraded = value;}
        }

        public bool KeySlot1
        {
            get { return keySlot1;}
            set { keySlot1 = value; }
        }
        public bool KeySlot2
        {
            get { return keySlot2; }
            set { keySlot2 = value; }
        }
        public bool KeySlot3
        {
            get { return keySlot3; }
            set { keySlot3 = value; }
        }
        public bool KeySlot4
        {
            get { return keySlot4; }
            set { keySlot4 = value; }
        }

        public string KnightLocation
        {
            get { return knightLocation;}
            set { knightLocation = value; }

        }

        public Knight(string InventorySlot1, string InventorySlot2, string InventorySlot3, string InventorySlot4, string InventorySlot5, bool Upgraded, bool KeySlot1, bool KeySlot2, bool KeySlot3, bool KeySlot4, string knightLocation)
        {
            inventorySlot1 = InventorySlot1;
            inventorySlot2 = InventorySlot2;
            inventorySlot3 = InventorySlot3;
            inventorySlot4 = InventorySlot4;
            inventorySlot5 = InventorySlot5;

            upgraded = Upgraded;

            keySlot1 = KeySlot1;
            keySlot2 = KeySlot2;
            keySlot3 = KeySlot3;
            keySlot4 = KeySlot4;

            KnightLocation = knightLocation;
        }

    }
}

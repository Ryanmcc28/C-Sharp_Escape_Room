using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscapeRoom
{
    internal class Globals
    {
        public static int axeNum = 0;
        public static int keyNum = 0;
        public static int ladderNum = 0;
        public static int poleNum = 0;

        public static bool roomCleared = false;

        public static bool DoesPlayerHaveFinalKey1 = false;
        public static bool DoesPlayerHaveFinalKey2 = false;
        public static bool DoesPlayerHaveFinalKey3 = false;
        public static bool DoesPlayerHaveFinalKey4 = false;

        public static bool DidKnightFall = false;
        public static bool DidKeyFall = false;

        public static bool upgrade = false;
        public static bool changeHeight = false;

        public static bool HasKeyFallen = false;
        public static  bool basementKeyTaken = false;

        public static bool miniGameCompleted = false;

        public static Knight Player;

        public static int SelectedItemInInventory = 1;
        public static int nextInventorySlot = 1;

        public static bool transformable = false;

        public static string direction = "right";
       

    }
}

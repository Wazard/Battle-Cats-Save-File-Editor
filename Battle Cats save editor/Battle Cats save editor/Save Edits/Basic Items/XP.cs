﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Cats_save_editor.SaveEdits
{
    public class XP
    {
        public static void xp(string path)
        {
            int XP = GetXP(path);
            XP = Editor.AskSentances(XP, "XP", false, 99999999);
            SetXP(path, XP);
            Editor.AskSentances(XP, "XP", true);
        }
        public static int GetXPPos()
        {
            int startPos = 76;

            // If using jp, xp is stored 1 offset less
            if (Editor.gameVer == "jp")
            {
                startPos = 75;
            }
            return startPos;
        }
        public static int GetXP(string path)
        {
            return Editor.GetItemData(path, 1, 4, GetXPPos())[0];
        }
        public static void SetXP(string path, int XP)
        {
            Editor.SetItemData(path, new int[] { XP }, 4, GetXPPos());
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Cats_save_editor.SaveEdits
{
    public class CatFood
    {
        public static void catFood(string path)
        {
            Console.WriteLine("Warning, editing cat food at all can get you banned after a few days, would you like to continue? (yes/no):");
            string answer = Console.ReadLine();
            if (answer.ToLower() == "no")
            {
                return;
            }
            int CatFood = GetCatFood(path);
            Console.WriteLine($"You have {CatFood} cat food");

            Console.WriteLine("How much cat food do you want?(max 900000, but I recommend below 20k, to be safer)");

            CatFood = Editor.MaxMinCheck((int)Editor.Inputed(), 900000);
            SetCatFood(path, CatFood);
            Console.WriteLine("Set Cat food to " + CatFood);
        }
        public static int GetCatFood(string path)
        {
            using var stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);

            byte[] catfoodB = new byte[4];
            stream.Position = 7;
            stream.Read(catfoodB, 0, 4);

            int CatFood = BitConverter.ToInt32(catfoodB, 0);

            return CatFood;
        }
        public static void SetCatFood(string path, int amount)
        {
            using var stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);

            byte[] bytes = Editor.Endian(amount);

            stream.Position = 7;
            stream.Write(bytes, 0, 4);
        }
    }
}

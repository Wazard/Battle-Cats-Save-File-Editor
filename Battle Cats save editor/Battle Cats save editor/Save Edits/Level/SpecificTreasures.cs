﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battle_Cats_save_editor.SaveEdits
{
    public class SpecificTreasures
    {
        public static void VerySpecificTreasures(string path)
        {
            string[] treasrureTypes1 =
            {
                "Energy Drink", "Giant Safe", "Relativity Clock", "Philosopher's Stone", "Smart Material Wall", "Super Register", "Legendary Cat Shield", "Legendary Cat Sword", "Energy Core", "Turbo Machine", "Management Bible",
            };
            string[] treasureTypes2 =
            {
                "Aqua Crystal", "Plasma Crystal", "Ancient Tablet", "Mysterious Force", "Cosmic Energy", "Void Fruit", "Blood Fruit", "Sky Fruit", "Heaven's Fruit", "Time Machine", "Future Tech",
            };
            string[] treasureTypes3 =
            {
                "Stellar Garnet", "Phoebe Beryl", "Lunar Citrine", "Ganymede Topaz", "Callisto Amethyst", "Titanium Fruit", "Antimatter Fruit", "Enigma Fruit", "Dark Matter", "Neutrino", "Mystery Mask"
            };
            // What stages have which treasure
            int[][] treasureLevels1 = new int[][]
            {
            new int[] { 46, 45, 44, 43, 42, 41, 40 },
            new int[] { 39, 38, 37, 36 },
            new int[] { 35, 34, 33, 32, 31 },
            new int[] {30, 29, 28, 27, 26, 25, 24},
            new int[] {23, 22, 19},
            new int[] {20, 21, 18},
            new int[] {17, 16, 15},
            new int[] {14, 13, 12, 11, 10, 9, 8},
            new int[] {7, 6, 5, 4, 3, 2},
            new int[] {1},
            new int[] {47, 48}

            };
            int[][] treasureLevels2 = new int[][]
            {
            new int[] { 46, 42, 39, 36, 33, 30, 27, 24},
            new int[] { 22, 19, 16, 13, 10, 7, 4, 1},
            new int[] {45, 44, 43},
            new int[] {23},
            new int[] { 41, 40, 38, 37, 35 },
            new int[] { 18, 17, 15, 14},
            new int[] { 26, 25, 21, 20 },
            new int[] { 12, 11, 9, 8 },
            new int[] { 6, 5, 3, 2 },
            new int[] { 34, 32, 31, 29, 28 },
            new int[] {47, 48}
            };
            int[][] treasureLevels3 = new int[][]
            {
            new int[] {46, 45, 44, 43, 42},
            new int[] {37, 36, 35, 34, 33},
            new int[] {28, 27, 26, 25, 24},
            new int[] {19, 18, 17, 16, 15},
            new int[] {10, 9, 8, 7, 6},
            new int[] {41, 40, 39, 38},
            new int[] {32, 31, 30, 29},
            new int[] {23, 22, 21, 20},
            new int[] {14, 13, 12, 11},
            new int[] {5, 3, 1, 48},
            new int[] {44, 42, 47}
            };

            Console.WriteLine("What level of treasures of you want?(max 255) 1 = inferior, 2 = normal 3 = superior, anything above 3 just aplifies the treasure effect");
            int level = (int)Editor.Inputed();
            if (level > 255) level = 255;
            Console.WriteLine("Do you want a list of the types of treasures?(yes,no):");
            if (Console.ReadLine().ToLower() == "yes")
            {
                Editor.ColouredText("Empire of Cats:&" + "\n" + "\n    &Energy Drink& – Worker Cat Efficiency increased! (EoC 1-7) (East Asia Quarantine Zone for Zombie Outbreaks)" + "\n    &Giant Safe& – Worker Cat Wallet Capacity increased! (EoC 8-11) (Indian Ocean QZ for ZO)" + "\n    &Relativity Clock& – Production Speed of Cats increased! (EoC 12-16) (Himalaya-Rift QZ for ZO)" + "\n    &Philosopher's Stone& – XP obtained from battle increased! (EoC 17-23) (Afro-Mediterranean QZ for ZO)" + "\n    &Smart Material Wall& – Cat Base health increased! (EoC 24, 25, 28) (Alps QZ for ZO)" + "\n    &Super Register& – Money for defeating enemies increased! (EoC 27, 26, 29) (West Europe QZ for ZO)" + "\n    &Legendary Cat Shield& – Cat Health increased! (EoC 30-32) (North Atlantic QZ for ZO)" + "\n    &Legendary Cat Sword& – Cat ATK increased! (EoC 33-39) (East Americas QZ for ZO)" + "\n    &Energy Core& – Cat Cannon ATK increased! (EoC 40-45) (Pacific QZ for ZO)" + "\n    &Turbo Machine& – Cat Cannon recharge speed increased! (EoC 46) (Fairbanks QZ for ZO)" + "\n    &Management Bible& – Max Cat Energy increased! (EoC 47-48) (Mauna Kea QZ for ZO)" + "\n" + "\n&Into the Future:&" + "\n" + "\n    &Aqua Crystal& – Attacks against unstarred Aliens are much more powerful! (ItF 1, 5, 8, 11, 14, 17, 20, 23) (? QZ for ZO)" + "\n    &Plasma Crystal& – Attacks against unstarred Aliens are much more powerful! (ItF 25, 28, 31, 34, 37, 40, 43, 46) (? QZ for ZO)" + "\n    &Ancient Tablet& – Your Cat Base's defense is increased! (ItF 2-4) (? QZ for ZO)" + "\n    &Mysterious Force& – Cat Cannon recharge time is decreased. (ItF 24) (? QZ for ZO)" + "\n    &Cosmic Energy& – Cat Cannon attacks are now more powerful! (ItF 6, 7, 9, 10, 12) (? QZ for ZO)" + "\n    &Void Fruit& – Abilities used on Black enemies are more effective! (ItF 29, 30, 32-33) (? QZ for ZO)" + "\n    &Blood Fruit& – Abilities used on Red enemies are more effective! (ItF 21, 22, 26, 27) (? QZ for ZO)" + "\n    &Sky Fruit& – Abilities used on Floating enemies are more effective! (ItF 35, 36, 38, 39) (? QZ for ZO)" + "\n    &Heaven's Fruit& – Abilities used on Angel enemies enemies are more effective! (ItF 41, 42, 44, 45) (? QZ for ZO)" + "\n    &Time Machine& – Energy recovery speed is increased! (ItF 13, 15, 16, 18, 19) (? QZ for ZO)" + "\n    &Future Tech& – Maximum energy total increased! (ItF 47, 48) (? QZ for ZO)" + "\n" + "\n&Cats of the Cosmos:&" + "\n" + "\n    &Stellar Garnet& – Attacks against Starred Aliens are much more powerful! (CotC 1-5)" + "\n    &Phoebe Beryl& – Attacks against Starred Aliens are much more powerful! (CotC 10-14)" + "\n    &Lunar Citrine& – Attacks against Starred Aliens are much more powerful! (CotC 19-23)" + "\n    &Ganymede Topaz& – Attacks against Starred Aliens are much more powerful! (CotC 28-32)" + "\n    &Callisto Amethyst& – Attacks against Starred Aliens are much more powerful! (CotC 37-41)" + "\n    &Titanium Fruit& – Anti-Metal abilities have increased effect! (CotC 6-9)" + "\n    &Antimatter Fruit& – Anti-Zombie abilities have increased effect! (CotC 15-18)" + "\n    &Enigma Fruit& – Anti-Alien abilities have increased effect! (CotC 24-27)" + "\n    &Dark Matter& – Maximum energy total is increased! (CotC 33-36)" + "\n    &Neutrino& – XP received from battle increased! (CotC 42, 44, 46, 48)" + "\n    &Mystery Mask& – A strange effect will activate when Ch.X is cleared! (CotC 43, 45, 47)\n");
            }
            Editor.ColouredText("\nWhat treasures do you want to edit(enter the name of the treasures,e.g energy drink,or ancient tablet), you can enter multiple treasures,separated by underscores, e.g giant safe_neutrino_Energy drink:\n");
            string[] answer = Console.ReadLine().Trim(' ').Split('_');
            for (int i = 0; i < answer.Length; i++)
            {
                int MainChapterToEdit = -1;
                bool skip = false;
                // Check if treasure exists
                int one = Array.FindIndex(treasrureTypes1, type => type.ToLower() == answer[i].ToLower());
                int two = Array.FindIndex(treasureTypes2, type => type.ToLower() == answer[i].ToLower());
                int three = Array.FindIndex(treasureTypes3, type => type.ToLower() == answer[i].ToLower());
                // If it exists in Empire of Cats
                if (one != -1)
                {
                    MainChapterToEdit = 0;
                }
                // If it exists in Into the Future
                else if (two != -1)
                {
                    MainChapterToEdit = 3;
                }
                // If it exists in Cats of the Cosmos
                else if (three != -1)
                {
                    MainChapterToEdit = 6;
                }
                else
                {
                    skip = true;
                    Console.WriteLine("Treasure type " + answer[i] + " doesn't exist!");
                }
                if (!skip)
                {
                    Editor.ColouredText("&What chapters for treasure type &" + answer[i] + "& do you want? (1, 2 or 3) you can enter more chapters separated by spaces:");
                    string[] anS = Console.ReadLine().Trim(' ').Split(' ');
                    for (int v = 0; v < anS.Length; v++)
                    {
                        bool end = false;
                        int chapterID = 0;
                        try
                        {
                            chapterID = int.Parse(anS[v]);
                            if (chapterID > 3) chapterID = 3;
                            else if (chapterID < 1) chapterID = 1;
                        }
                        catch
                        {
                            Console.WriteLine("Input string was not in the correct format");
                            end = true;
                        }
                        chapterID += MainChapterToEdit;
                        if (chapterID > 3)
                        {
                            chapterID++;
                        }
                        using var stream = new FileStream(path, FileMode.Open, FileAccess.ReadWrite);
                        int j = 0;
                        int id = 1;
                        int startPos = 2986;
                        int endPos = 4942;
                        // Loop through treasure data
                        for (int k = startPos; k <= endPos && !end; k += 4)
                        {
                            j++;
                            // If it's the end of a section of chapter data, increment the chapter id, and don't write anything
                            if (j % 49 == 0)
                            {
                                id++;
                            }
                            else if (j % 49 != 0)
                            {
                                // If the current chapter == the chapterID that you want to edit
                                if (id == chapterID)
                                {
                                    switch (MainChapterToEdit)
                                    {
                                        // Empire of Cats
                                        case 0:
                                            {
                                                // Loop through all of the types of treasures in Empire of Cats
                                                for (int g = 0; g < treasureLevels1[one].Length; g++)
                                                {
                                                    stream.Position = k - 4 + (treasureLevels1[one][g] * 4);
                                                    stream.WriteByte((byte)level);
                                                }
                                                end = true;
                                                break;
                                            }
                                        // Into the future
                                        case 3:
                                            {
                                                // Loop through all of the types of treasures in Into the Future
                                                for (int g = 0; g < treasureLevels2[two].Length; g++)
                                                {
                                                    stream.Position = k - 4 + (treasureLevels2[two][g] * 4);
                                                    stream.WriteByte((byte)level);
                                                }
                                                end = true;
                                                break;
                                            }
                                        // Cats of the Cosmos
                                        case 6:
                                            {
                                                // Loop through all of the types of treasures in Cats of the Cosmos
                                                for (int g = 0; g < treasureLevels3[three].Length; g++)
                                                {
                                                    stream.Position = k - 4 + (treasureLevels3[three][g] * 4);
                                                    stream.WriteByte((byte)level);
                                                }
                                                end = true;
                                                break;
                                            }
                                    }
                                }
                            }

                        }
                    }

                }
            }

        }
    }
}

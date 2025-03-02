using System;
using System.ComponentModel.Design;

namespace CG
{
    internal class Program
    {
        public static string charc;
        public static bool CanMove = true;
        public static bool IsAlive = true;
        public static bool FirstMove = true;
        static void Main(string[] args)
        {
            if (IsAlive == true)
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (FirstMove == true)
            {
                Console.Clear();
                Console.WriteLine("Use WASD or the arrow keys to move, Delete to clear, Escape to kill, Enter to save, and L to load");
                charc = ":3";
                FirstMove = false;

            }
            


            Move();
            Console.ReadKey();
        }
        public static void Move()
        {
            var input = Console.ReadKey().Key;
            
            if (CanMove == true && IsAlive == true)
            {
                



                if (input == ConsoleKey.D || input == ConsoleKey.RightArrow)
                {
                    if (charc.Contains("\n"))
                    {
                        var lastline = charc.Split("\n").Last();
                        lastline = " " + lastline;
                        charc = charc.Replace(charc.Split("\n").Last(), lastline);
                    }
                    else
                    {
                        charc = " " + charc;
                    }

                }
                else if (input == ConsoleKey.A || input == ConsoleKey.LeftArrow)
                {
                    if (charc.Contains(" "))
                    {
                        if (charc.Contains("\n"))
                        {
                            var lastline = charc.Split("\n").Last();
                            lastline = lastline.Remove(0, 1);
                            charc = charc.Replace(charc.Split("\n").Last(), lastline);
                        }
                        else
                        {
                            charc = charc.Remove(0, 1);
                        }

                    }

                }
                else if (input == ConsoleKey.S || input == ConsoleKey.DownArrow)
                {
                    charc = "\n" + charc;
                }
                else if (input == ConsoleKey.W || input == ConsoleKey.UpArrow)
                {
                    if (charc.Contains("\n"))
                    {
                        charc = charc.Remove(0, 1);
                    }
                }
                else if (input == ConsoleKey.Delete)
                {
                    Console.Clear();
                    charc = ":3";
                }
                else if (input == ConsoleKey.Escape)
                {
                    MCKill();
                }
                else if (input == ConsoleKey.L)
                {
                    charc = File.ReadAllText(@"GameData/Last.dat");
                }
                else if (input == ConsoleKey.Enter)
                {
                    File.WriteAllText(@"GameData/Last.dat", charc);
                }
            }
        
                Console.Clear();
            Console.WriteLine(charc);
            
            Main(null);
        }

        public static void MCKill()
        {
            IsAlive = false;
            charc = charc.Replace(":3", "X_X");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}

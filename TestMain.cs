﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesSpace
{
    public class TestMain
    {
        static void Main(string[] args)
        {
            int row = 0;

            do
            {
                if (row == 0 || row >= 25)
                    ResetConsole();

                string input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) break;
                Console.WriteLine($"Input: {input} {"Begins with uppercase? ",30}: " +
                                  $"{(input.StartsWithUpper() ? "Yes" : "No")}{Environment.NewLine}");
                row += 3;
            } while (true);
            return;

           
            void ResetConsole()
            {
                if (row > 0)
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                }
                Console.Clear();
                Console.WriteLine($"{Environment.NewLine}Press <Enter> only to exit; otherwise, enter a string and press <Enter>:{Environment.NewLine}");
                row = 3;
            }
        }
    }
}

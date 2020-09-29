using System;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Threading;

namespace BrandonsFirstProjectV2
{
    class Program
    {

        [STAThread]
        static void Main(string[] args)
        {

            Util.Log("(C) Max Playle 2020 - All rights reserved!");
            if (!Debugger.IsAttached)
            {
                Thread.Sleep(5000);
            }
            MainMenu();

        }

        static void MainMenu()
        {

        DO_MAIN_MENU:
                Console.Clear();
                Util.Log("------------------------------------------------------------------------------");
                Util.Log("Main Menu");
                Util.Log("------------------------------------------------------------------------------");
                Util.Log("1. Bully somebody");
                Util.Log("2. View the GitHub repository");
                Util.Log("3. Exit");
                Util.Log("------------------------------------------------------------------------------");

                switch (Util.GetKeyInput(ConsoleColor.Yellow, ConsoleColor.Green, "Select an option:").Key)
                {
                    case ConsoleKey.D1:
                        RoastScript.Start();
                        goto DO_MAIN_MENU;

                    case ConsoleKey.D2:
                        Miscellaneous.ViewGitHubRepo();
                        goto DO_MAIN_MENU;

                    case ConsoleKey.D3:
                        Miscellaneous.Exit();
                        goto DO_MAIN_MENU;

                    default:
                        Util.Log("Input not recognised! Sending you to the main menu!");
                        Thread.Sleep(1000);
                        goto DO_MAIN_MENU;
                }
        }

    
    }
}

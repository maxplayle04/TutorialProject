using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace BrandonsFirstProjectV2
{
    public class Miscellaneous
    {

        public static void ViewGitHubRepo()
        {
            // https://github.com/maxplayle04/BrandonsFirstProjectV2
            try
            {
                var psi = new ProcessStartInfo
                {
                    FileName = "https://github.com/maxplayle04/BrandonsFirstProjectV2",
                    UseShellExecute = true
                };
                Process.Start(psi);
            }
            catch (Exception ex)
            {
                Util.Log($"Exception thrown. Exception name: {ex.GetType().Name}\n\nException Stack: {ex.StackTrace}\n\nException Message: {ex.Message}");
                Util.Log("Press any key to quit application!");
                Console.ReadKey();
                Application.Exit();
                Environment.Exit(0);
            }
        }

        internal static void Exit()
        {
            if (AskForConfirmation("exit the application") == true)
            {
                Application.Exit();
                Environment.Exit(0);
            }
            return;
        }

        internal static bool AskForConfirmation(string OperationDisplayName)
        {
            ConsoleKeyInfo cki = Util.GetKeyInput(ConsoleColor.Yellow, ConsoleColor.Green, $"Are you sure you would like to {OperationDisplayName}?");
            switch (cki.Key)
            {
                case ConsoleKey.Y:
                    return true;

                default:
                    return false;
            }
        }

        internal static bool OfferClipboardCopy(string ContentsIn)
        {
            ConsoleKeyInfo cki = Util.GetKeyInput(ConsoleColor.Yellow, ConsoleColor.Green, "[Options: Y or N] Would you like to copy the result to your clipboard?");
            switch (cki.Key)
            {
                case ConsoleKey.Y:
                    {
                        Clipboard.SetText(ContentsIn);
                        Util.Log("That's done! I've copied it to your clipboard!", true);
                    }
                    return true;

                default:
                    Util.Log("No worries, I won't copy it!");
                    return false;
            }
        }
    }
}

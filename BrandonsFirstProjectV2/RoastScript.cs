using BrandonsFirstProjectV2.MultiRoast;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace BrandonsFirstProjectV2
{
    public class RoastScript
    {

        const string ExpectedInput__when__Lea = "lea";
        const string ExpectedInput__when__Dylan = "dylan";
        const string ExpectedInput__when__Harry = "harry";
        const string ExpectedInput__when__Stacie = "stacie";
            
        public static void Start()
        {
            var response = Util.GetInput(ConsoleColor.Cyan, ConsoleColor.Green, "Who would you like to roast?", "You need to tell me who to roast! (Type exit to go back to main menu!)");
            
            if (response.ToLower().Contains("exit"))
            {
                return;
            }

            // Assuming the user doesn't want to exit

            string Roast = string.Empty;

            switch (response.ToLower())
            {
                case ExpectedInput__when__Lea:
                    Roast = RoastingEngine.GetRoastForVictim(MultiRoast.Util.Victim.Lea);
                    break;

                case ExpectedInput__when__Dylan:
                    Roast = RoastingEngine.GetRoastForVictim(MultiRoast.Util.Victim.Dylan);
                    break;

                case ExpectedInput__when__Harry:
                    Roast = RoastingEngine.GetRoastForVictim(MultiRoast.Util.Victim.Harry);
                    break;

                case ExpectedInput__when__Stacie:
                    Roast = RoastingEngine.GetRoastForVictim(MultiRoast.Util.Victim.Stacie);
                    break;
            }

            Util.Log(Roast, true);
            Miscellaneous.OfferClipboardCopy(Roast);

            Util.Log("-- Press any key to continue.");
            Console.ReadKey();

            return;
        }

    }
}

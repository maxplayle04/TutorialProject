using BrandonsFirstProjectV2.MultiRoast.Util;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace BrandonsFirstProjectV2.MultiRoast
{
    public class RoastingEngine
    {

        static string[] Roasts__Lea = { "Left the FaceTime? Probably gone for Dan...", "Chicken is for the weak.", "God, she's annoying.", "https://photos.app.goo.gl/duFUWeTZy6WC41sJ9", "Oh.. she's the girl who got pushed over by a dog!" };

        static string[] Roasts__Dylan = { "Was Paige Harris really a good idea?", "Hey, remember when you liked that Lea girl?", "I wuv my PacMook Bro", "Discount Card", "oH i LoVe My PrOtEcTiVe ClOtHiNg", "Wait.. this MacBook has surround sound?", "SCP 20912 HAS BEEN CONTAINED OMFG THERE IS BLOOD EVERYWHERE!", "Ooh, I'm so cool - I know how to install Minecraft Addons. There definitely isn't a tutorial of how to do it on https://minecraft.net..." };

        static string[] Roasts__Harry = { "My ID photo is well bad...  It was taken by PROFESSIONAL PHOTOGRAPHERS.", "But don't shove a camera in my face.", "WeLl YoU cAn ShOvE tHaT cAmErA rIgHt Up YoUr ArSe", "That kid who definitely doesn't have a crush on Ella Hotspring...", "Office Staff Romance <3"};

        static string[] Roasts__Stacie = { "Don't you look like that Pumpkin out of Vortex Digital Control?", "The one freak known as SCARY Stacie", "Seriously, even the rats don't want to talk to you.", "Had a fight on your SECOND day. With the head of duty operations... Tut tut tut", "Well, you like printing passwords to the main screens don't you...", "FIX THE MAIN SCREENS AND GET MY FACE OFF THEM. NOW.", "What a pleb", "if (CurrentUser == CurrentUserStorage.Database.GetFromDatabase(\"StacieHouston\", 99841) { Object.FuckOff(); }"};

        public static string GetRoastForVictim(Victim victimIn)
        {
            switch (victimIn)
            {

                case Victim.Lea:
                    {
                        return GenerateRoastString(Roasts__Lea);
                    }

                case Victim.Dylan:
                    {
                        return GenerateRoastString(Roasts__Dylan);
                    }

                case Victim.Harry:
                    {
                        return GenerateRoastString(Roasts__Harry);
                    }

                case Victim.Stacie:
                    {
                        return GenerateRoastString(Roasts__Stacie);
                    }

                default:
                    return "We couldn't find a roast for that pleb, sorry!";
            }
        }

        private static string GenerateRoastString(string[] roastsIn)
        {
            Random rnd = new Random();
            int selected = rnd.Next(0, roastsIn.Length);
            return roastsIn[selected];
        }

    }
}

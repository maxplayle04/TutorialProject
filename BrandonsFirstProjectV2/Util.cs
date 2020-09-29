using System;
using System.Collections.Generic;
using System.Text;

namespace BrandonsFirstProjectV2
{
    public class Util
    {

        /// <summary>
        /// Gets an input from the user using the console.
        /// </summary>
        /// <param name="promptColor">The colour that the question will be displayed in.</param>
        /// <param name="answerColor">The colour that the answer will be dipslayed in as the user is typing.</param>
        /// <param name="questionIn">The question to ask the user.</param>
        /// <param name="errorMessage">The error message if the user doesn't type anything (if blank, will return null if the response is empty)</param>
        /// <returns>The user's input (or null, if there is no error message and the user types nothing)</returns>
        public static string GetInput(ConsoleColor promptColor, ConsoleColor answerColor, string questionIn, string errorMessage = null)
        {
        GET_INPUT_BEGIN:

            var precolor = Console.ForegroundColor;

            Console.ForegroundColor = promptColor;

            Console.Write($"\n{questionIn} ");

            Console.ForegroundColor = answerColor;

            var response = Console.ReadLine();

            if (string.IsNullOrEmpty(errorMessage) == false && string.IsNullOrEmpty(response))
            {
                Console.ForegroundColor = precolor;
                Console.WriteLine($"ERROR: {errorMessage}");
                goto GET_INPUT_BEGIN;
            }

            Console.ForegroundColor = precolor;

            return response;
        }

        public static ConsoleKeyInfo GetKeyInput(ConsoleColor promptColor, ConsoleColor answerColor, string promptIn)
        {
        GET_INPUT_BEGIN:

            var precolor = Console.ForegroundColor;

            Console.ForegroundColor = promptColor;

            Console.WriteLine($"\n{promptIn}");

            Console.ForegroundColor = answerColor;

            var response = Console.ReadKey();

            Console.ForegroundColor = precolor;

            return response;
        }

        public static void Log(string contentIn, bool newLine = true)
        {
            switch (newLine)
            {
                case true:
                    Console.WriteLine(contentIn);
                    break;

                case false:
                    Console.Write(contentIn);
                    break;
            }
        }

    }
}

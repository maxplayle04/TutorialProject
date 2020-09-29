﻿using System;
using System.ComponentModel.Design.Serialization;

namespace BrandonsFirstProjectV2
{
    class Program
    {


        static void Main(string[] args)
        {
           switch (GetInput(ConsoleColor.Green, ConsoleColor.Yellow, "Who do you want to bully?", "Tell me who you want to bully, you idiot!").ToLower())
            {
                case "lea":
                    {
                        Log("You want to bully Lea?"); 
                    }
                    break;
            }
        }

        /// <summary>
        /// Gets an input from the user using the console.
        /// </summary>
        /// <param name="promptColor">The colour that the question will be displayed in.</param>
        /// <param name="answerColor">The colour that the answer will be dipslayed in as the user is typing.</param>
        /// <param name="questionIn">The question to ask the user.</param>
        /// <param name="errorMessage">The error message if the user doesn't type anything (if blank, will return null if the response is empty)</param>
        /// <returns>The user's input (or null, if there is no error message and the user types nothing)</returns>
        static string GetInput(ConsoleColor promptColor, ConsoleColor answerColor, string questionIn, string errorMessage = null)
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

        static void Log(string contentIn, bool newLine = true)
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

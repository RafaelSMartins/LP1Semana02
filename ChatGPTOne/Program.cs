﻿using System;

namespace ChatGPTZero
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Place your question (EXIT to leave): ");
                string question = Console.ReadLine();
                string response;

                if (question.Equals("EXIT", StringComparison.OrdinalIgnoreCase))
                {
                    response = "Goodbye!";
                    Console.WriteLine(response);
                    break;
                }
                if (question == "What's your name?")
                {
                    response = "My name is ChatGPTOne.";
                }
                else if (question == "How are you?")
                {
                    response = "I'm good, thanks for asking!";
                }
                else if (question == "Do you like Benfica?")
                {
                    response = "Of course, biggest club in Portugal!";
                }
                else if (question == "What's the capital of Portugal?")
                {
                    response = "Lisbon.";
                }
                else if (question == "Do you like football?")
                {
                    response = "Yes, I love football!";
                }
                else
                {
                    response = "Sorry, I can't recognise your question, try again.";
                }
                Console.WriteLine(response);
            }
        }
    }
}


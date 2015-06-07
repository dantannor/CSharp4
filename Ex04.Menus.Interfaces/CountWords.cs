// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CountWords.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Ex04.Menus.Interfaces
{
    using System;

    public class CountWords : IAction
    {
        public void RunAction()
        {
            int numOfWords = 0;
            Console.WriteLine("Enter a sentence:");
            string userInput = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(userInput))            
            {
                userInput = userInput.Trim();

                while (userInput.Contains("  "))
                {
                    userInput = userInput.Replace("  ", " ");
                }

                numOfWords = userInput.Split(' ').Length;
            }

            Console.WriteLine("Number of words in the sentence: {0}", numOfWords);
            Console.ReadLine();
        }
    }
}

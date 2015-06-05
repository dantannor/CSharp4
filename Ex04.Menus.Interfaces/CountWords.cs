using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class CountWords : IAction
    {
        public void RunAction()
        {
            Console.WriteLine("Enter a sentence:");
            string userInput =  Console.ReadLine();
            int numOfWords = 1;
            if (userInput != null)
            {
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    numOfWords = 0;
                }
                else
                {
                    Regex.Replace(userInput, "[ ]+", " ");
                    userInput.Trim();
                    for (int i = 0; i < userInput.Length; i++)
                    {
                        if (userInput[i] == 32)
                        {
                            numOfWords++;

                        }
                    }
                }
         
            }
            Console.WriteLine("Number of words in the sentence: {0}",numOfWords);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;

namespace LetterLoops
{
    class Process
    {
        static public void ConvertInput(string userInput)
        {
            int index = 1;

            foreach (var letter in userInput)
            {
                string currentLetter = letter.ToString();
                for (int i = 1; i <= index; i++)
                {
                    if (i == 1 && index != 1)
                    {
                        var uppercaseCurrentLetter = currentLetter.ToUpper();
                        Console.Write($"-{uppercaseCurrentLetter}");
                    }
                    else if (i == 1 && index == 1)
                    {
                        var uppercaseCurrentLetter = currentLetter.ToUpper();
                        Console.Write($"{uppercaseCurrentLetter}");
                    }
                    else
                    {
                        currentLetter = currentLetter.ToLower();
                        Console.Write($"{currentLetter}");
                    }
                }
                index++;
            }
            Console.ReadKey();
        }
    }
}

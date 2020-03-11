using System;
using System.Collections.Generic;
namespace HangMan.Models
{
    public class HMGame
    {
        public string Solution;
        public string Unsolved;
        public int Game;
        public int MaxGuess;
        public string Correct;
        public string Wrong;
        HMGame(string solution, int maxGuess)
        {
            Solution = solution;
            MaxGuess = maxGuess;

        }
        public void Guess(char input)
        {
            if (char.IsLetter(input))
            {
                for (int i = 0; Solution.Length - 1 > i; i++)
                {
                    if (Solution[i] == input)
                    {

                        break;
                    }
                    if (Correct.Contains(input) || Wrong.Contains(input))
                    {
                        break;
                    }
                    else
                    {
                        Correct += input;
                    }
                }
            }
        }
    }
}
}
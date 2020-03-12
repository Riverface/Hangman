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
        public HMGame(string solution, int maxGuess)
        {
            Solution = solution;
            MaxGuess = maxGuess;
            Unsolved = "";
            Correct = "";
            Wrong = "";
        }
        public void Guess(char input)
        {
            if (char.IsLetter(input))
            {
                for (int i = 0; Solution.Length - 1 > i; i++)
                {
                    if (GuessCorrect(input, i))
                    {
                        Correct += input;
                    }
                    if (!GuessCorrect(input, i))
                    {
                        Wrong += input;
                    }

                }
            }
        }

        public bool GuessCorrect(char input, int index)
        {
            if (Solution[index] == input)
            {
                Correct += input;
                return true;
            }
            else
            {
                Wrong += input;
                return false;
            }
        }
        public bool GuessExists(char input)
        {
            if (Correct.Contains(input) || Wrong.Contains(input))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void BuildUnsolved()
        {
            bool found = false;
            Unsolved = "";
            for (int o = 0; Solution.Length > o; o++)
            {
                for (int i = 0; Correct.Length > i; i++)
                {


                        if (Correct[i] == Solution[o])
                        {
                            Unsolved += Correct[i];
                            found = true;
                        }
                    

                }
                if (found == false)
                {
                    Unsolved += "_";
                }
                else
                {
                    found = false;
                }
            }

        }
    }
}

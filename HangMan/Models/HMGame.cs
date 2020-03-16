using System;
using System.Collections.Generic;
namespace HangMan.Models
{
    public class HMGame
    {
        public string Solution;
        //
        public string Unsolved;
        //Game State 
        // 0 = running, 1 = win, 2 = lose
        public int Game;
        public int MaxGuess;
        // Correct guesses concatenated into one string (No duplicates)
        public string Correct;
        // Wrong guesses concatenated into one string (No duplicates)
        public string Wrong;

        public HMGame(string solution, int maxGuess)
        {
            Solution = solution.ToLower();
            MaxGuess = maxGuess;
            Unsolved = "";
            Correct = "";
            Wrong = "";
        }
        public void Guess(char input)
        {
            bool found = false;
            char temp = '_';
            input = Char.ToLower(input);
            if (char.IsLetter(input) && !GuessExists(input))
            {
                for (int i = 0; Solution.Length > i; i++)
                {
                    if (GuessCorrect(input, i))
                    {
                        Correct += input;
                        break;
                    }
                }
            }
            if (!GuessExists(input))
            {
                Wrong += input;
            }
        }

        public bool GuessCorrect(char input, int index)
        {
            if (Solution[index] == input)
            {

                return true;
            }
            else
            {

                return false;
            }
        }
        public bool GuessExists(char input)
        {
            if (Correct.Contains(input) || Wrong.Contains(input))
            {
                Console.WriteLine(input + " Exists in one of the strings");
                return true;
            }
            else if (!Correct.Contains(input) || !Wrong.Contains(input))
            {
                Console.WriteLine(input + " Does not exist in one of the strings");
                return false;
            }
            else
            {
                return false;
            }
        }
        public void BuildUnsolved()
        {
            bool found = false;
            char temp = '_';
            Unsolved = "";
            for (int o = 0; Solution.Length > o; o++)
            {

                for (int i = 0; Correct.Length > i; i++)
                {

                    if (Correct[i] == Solution[o])
                    {
                        temp = Correct[i];
                        found = true;
                    }
                }
                if (found == false)
                {
                    Unsolved += "_";
                }
                else
                {
                    Unsolved += temp;
                    found = false;
                }
                Console.WriteLine(Unsolved);
            }
        }
    }
}

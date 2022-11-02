using System;
using System.Collections.Generic;
using System.IO;

namespace jumper
{
    public class Word
    {
        List<char> answer = new List<char>();
        public List<char> guess = new List<char>();

        public Word()
        {

        }

        public string pullWord()
        {
            List<string> words = new List<string>();
            words.Add("giraffe");
            words.Add("cantaloupe");
            words.Add("prowler");
            words.Add("hurricane");
            words.Add("precipice");
            words.Add("poltergeist");
            words.Add("exponential");
            words.Add("sagebrush");
            words.Add("gazebo");
            words.Add("liberty");

            Random rand = new Random();
            int randomIndex = rand.Next(0, words.Count);
            string chosenWord = words[randomIndex];
            return chosenWord;
        }

        public void listWord(string ripWord)
        {
            answer.AddRange(ripWord.ToLower());
        }

        public void createHiddenWord()
        {
            foreach (int i in answer)
            {
                guess.Add('_');
            }
        }

        public void printGuess()
        {
            Console.WriteLine(string.Format("{0}", string.Join(" ", guess)));
        }

        public int compare(List<char> listPreviousGuesses, int numberOfGuesses)
        {
            for (int i = 0; i < answer.Count; i++)
            {
                if (listPreviousGuesses.Contains(answer[i]))
                {
                    guess[i] = answer[i];
                }
            }
            if (answer.Contains(listPreviousGuesses[numberOfGuesses - 1]))
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }

        public void printAnswer()
        {
            Console.WriteLine(string.Format("{0}", string.Join(" ", answer)));
        }

    };
}

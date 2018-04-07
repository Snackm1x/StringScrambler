using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringScrambler
{
    public class StringScrambler
    {
        private Random random = new Random();

        public void run()
        {
            HandleInput();
        }

        public void HandleInput()
        {
            Console.Clear();
            Console.WriteLine("Please enter your first sentence");
            string input = Console.ReadLine();
            Console.WriteLine("Please enter your second sentence");
            string input2 = Console.ReadLine();
            var scrambledSentence = scrambleTogether(input, input2);
            Console.WriteLine("Your scrambled string is: ");
            Console.WriteLine(scrambledSentence);
            Console.WriteLine("Enter 1 to play again, enter anything else to exit");
            string input3 = Console.ReadLine();
            if(input3 != "1")
            {
                Exit();
            }
            else
            {
                HandleInput();
            }
        }

        private string scrambleTogether(string sentence1, string sentence2)
        {
           string scrambledString = "";
           List<string> words = sentence1.Split(' ').ToList();
           List<string> split2 = sentence2.Split(' ').ToList() ;
           words.AddRange(split2);
            int totalWords = words.Count;

           for(var i = 0; i < totalWords; i++)
            {
                string word = pickRandomWord(words);
                words.Remove(word);
                scrambledString += " " + word;
            }
            return scrambledString;
        }

        private string pickRandomWord(List<string> words)
        {
            return words[random.Next(words.Count - 1)];
        }

        public void Exit()
        {
            System.Environment.Exit(0);
        }
    }
}

using System;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "apple", "banana", "cherry", "orange", "pear" };
            Random random = new Random();
            string word = words[random.Next(words.Length)];
            char[] guessed = new char[word.Length];

            for (int i = 0; i < guessed.Length; i++)
            {
                guessed[i] = '_';
            }

            int guesses = 6;

            while (guesses > 0)
            {
                Console.WriteLine("Guesses left: " + guesses);
                Console.WriteLine("Word: " + new string(guessed));

                Console.WriteLine("Enter a letter:");
                char letter = char.Parse(Console.ReadLine());

                bool found = false;

                for (int i = 0; i < word.Length; i++)
                {
                    if (word[i] == letter)
                    {
                        guessed[i] = letter;
                        found = true;
                    }
                }

                if (!found)
                {
                    guesses--;
                }

                if (new string(guessed) == word)
                {
                    Console.WriteLine("You win! The correct answer is " + word);
                    Console.ReadKey();
                    return;
                }
            }

            Console.WriteLine("You lose! The word was: " + word);
            Console.ReadKey();
        }
    }
}

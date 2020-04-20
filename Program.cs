using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            // Welcome and pick level
            Console.Write("Hey there! Pick a level. Easy [E], Medium [M] or Hard [H]: ");

            // Get answer
            char answer;
            var input = Console.ReadLine().ToUpper();

            if (char.TryParse(input, out answer))
            {
                if (answer == 'E') 
                {
                    PlayEasy();
                }
                else if (answer == 'M')
                {
                    PlayMedium();
                }
                else if (answer == 'H')
                {
                    PlayHard();
                }
                else 
                {
                    Console.WriteLine("Please pick from options given!");
                }
            } 
            else 
            {
                Console.WriteLine("Please input in the format given!");
            }

            
        }

        static void PlayEasy()
        {
            var min = 1;
            var max = 10;
            var random = new Random();
            var correctNum = random.Next(min, max);
            var guessesLeft = 6;

            // Guess variable
            var guess = 0;

            // Ask player to guess
            Console.Write($"Guess a number between {min} and {max}: ");

            GuessNotCorrect(min, max, guess, correctNum, guessesLeft);
        }
                    
        static void PlayMedium()
        {
            var min = 1;
            var max = 20;
            var random = new Random();
            var correctNum = random.Next(min, max);
            var guessesLeft = 4;

            // Guess variable
            var guess = 0;

            // Ask player to guess
            Console.Write($"Guess a number between {min} and {max}: ");

            GuessNotCorrect(min, max, guess, correctNum, guessesLeft);
        }

        static void PlayHard()
        {
            var min = 1;
            var max = 50;
            var random = new Random();
            var correctNum = random.Next(min, max);
            var guessesLeft = 4;

            // Guess variable
            var guess = 0;

            // Ask player to guess
            Console.Write($"Guess a number between {min} and {max}: ");

            GuessNotCorrect(min, max, guess, correctNum, guessesLeft);
        }

        static void GuessNotCorrect(int min, int max, int guess, int correctNum, int guessesLeft)
        {
            // While guees is not correct
            while (guess != correctNum)
            {
                // Decrease guesses left
                guessesLeft--;

                // User's input variable
                var input = Console.ReadLine();

                // Alert player to put in right number format
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Please put in an actual number");

                    continue;
                }

                // More validation
                if (guess < min || guess > max)
                {
                    Console.WriteLine($"Please enter a number between {min} and {max}");
                }

                guess = int.Parse(input);

                // if guess is not correct
                if (guess != correctNum)
                {
                    Console.WriteLine($"That was wrong! You have {guessesLeft} guess(es) left!");
                }

                // if Guesses left = 0, game over
                if (guessesLeft == 0)
                {
                    Console.WriteLine("Game Over!!!");
                    break;
                }
            } 
            
            if (guess == correctNum) 
            {
                Console.WriteLine("You got it right!"); 
            }

        }
    }
}

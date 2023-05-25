namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(0, 20);
            bool isAnswered = false;

           // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");
            Console.WriteLine("What's your guess?\n");

            // Keep track of the number of guesses and the current user guess
            int guessCounter = 0;

            // Loop while answer is not obtained 
            while (isAnswered == false)
            {
                guessCounter++; // Increment guessCounter

                // Start the game and run until user quits or guesses correctly

                try
                {
                    int userNumber = int.Parse(Console.ReadLine());
               
                    if (userNumber >= 0 && userNumber <= 20)
                    {
                        if (userNumber < theNumber)
                        {
                            Console.WriteLine("Nope, higher than that.");
                            Console.WriteLine("What's your guess?\n");
                        }
                        else if (userNumber > theNumber)
                        {
                            Console.WriteLine("Nope, lower than that.");
                            Console.WriteLine("What's your guess?\n");
                        }
                        else
                        {
                            Console.WriteLine($"You got it in {guessCounter} guesses!!");
                            isAnswered = true;
                        }
                    }
                    else if (userNumber == -1)
                    {
                        Console.WriteLine($"Oh well. I was thinking of {theNumber}.");
                        isAnswered = true;
                    }
                    else
                    {
                        Console.WriteLine("The number is not from 0 to 20.\n");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Hmmm, that doesn't look like a number. Try again.\n");
                }
            }
        }
    }
}

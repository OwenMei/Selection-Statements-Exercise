namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();
            int favNum = randomNum.Next(1,100);
            int guess = -1;
            Console.WriteLine("guess a number from 1 to 100");
            int numGuesses = 0;
            while (favNum != guess && numGuesses < 7)
            {
                guess = (int.TryParse(Console.ReadLine(), out int guessed)) ? guessed : 0;
                if(favNum < guess)
                {
                    numGuesses++;
                    Console.WriteLine("too high, you have " + (7-numGuesses) + " guesses left");
                }
                else if(guess < favNum)
                {
                    numGuesses++;
                    Console.WriteLine("too low, you have " + (7 - numGuesses) + " guesses left");
                }
                else
                {
                    Console.WriteLine($"Yeah! The number was {favNum}");
                }

            }
            if(numGuesses == 7) 
            {
                Console.WriteLine($"Hmm, looks like you're out of guesses, better luck next time. The correct number was {favNum} btw.");
            }
            

        }
    }
}

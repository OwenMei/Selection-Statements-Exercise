namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random randomNum = new Random();
            int favNum = randomNum.Next(1,100);
            int guess = -1;
            Console.WriteLine("guess a number");
            while (favNum != guess)
            {
                guess = (int.TryParse(Console.ReadLine(), out int guessed)) ? guessed : 0;
                if(favNum < guess)
                {
                    Console.WriteLine("too high");
                }
                else if(guess < favNum)
                {
                    Console.WriteLine("too low");
                }
                else
                {
                    Console.WriteLine($"Yeah! The number was {favNum}");
                }
                
            }

        }
    }
}

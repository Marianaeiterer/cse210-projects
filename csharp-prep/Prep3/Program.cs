using System;

class Program
{
    static void Main(string[] args)
    {       
        Random randomGenerator = new Random();
        int magicNumber;
        int guess;
        int numberOfGuesses;

        string wantPlayAgain = "yes";

        while(wantPlayAgain != "no"){
            guess = -1;
            numberOfGuesses = 0;
            magicNumber = randomGenerator.Next(1, 101);

            while(guess != magicNumber){
            
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                
                numberOfGuesses++;

                if(guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else if(guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }

            }
         
            Console.WriteLine($"You guessed {numberOfGuesses} times");
            Console.Write("Do you want to play again (yes or no)? ");
            wantPlayAgain = Console.ReadLine();

        
        }

        
    }
}
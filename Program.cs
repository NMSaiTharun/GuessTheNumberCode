using System;

namespace GuessTheNumberDotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);
            bool p=true;

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");
        

            // Keep track of the number of guesses and the current user guess

            int c=0,guessNumber=0;
            while(p)
            {
                Console.WriteLine("Enter your number which you are guessing");
                string s=Console.ReadLine();
                bool r=Int32.TryParse(s,out guessNumber);
                if(r==false)
                {
                    Console.WriteLine("You Entered Wrong Number, enter correct number again");
                }
                else
                {
                    if(guessNumber==-1)
                    {
                        Console.WriteLine($"You have give up, the correct number is {theNumber} ");
                        p=false;
                    }
                    else
                    {
                        c++;
                        if(guessNumber==theNumber)
                        {
                            Console.WriteLine($"You have guessed the correct number and you got in {c} guessess");
                            p=false;
                        }
                        else
                        {
                            Console.WriteLine("Enter {0} than that number", guessNumber>theNumber ? "Less": "High");
                        }


                    }
                }


            }


            
        }
    }
}
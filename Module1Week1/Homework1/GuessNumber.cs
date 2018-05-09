using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Guess the number
namespace Homework1
{
    class GuessNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GUESS THE NUMBER AND HAVE FUN ^_^");
            Random rand = new Random();
            int randomNumber = rand.Next(0, 100);
            //    Console.WriteLine($"The number you have to guess is: {randomNumber}");


            Console.WriteLine("Enter a number between 0 and 100");
            string number = Console.ReadLine();
            int numberToGuess = int.Parse(number);

            while (numberToGuess != randomNumber)
            {


                if (numberToGuess > randomNumber)
                {
                    Console.WriteLine("Your number is larger than the target number. Try again");
                    goto tryAgain;

                }

                if (numberToGuess < randomNumber)
                {
                    Console.WriteLine("Your number is smaller than the target number. Try again");
                    goto tryAgain;
                }

                tryAgain:
                {
                    Console.WriteLine("Enter another number: ");
                    number = Console.ReadLine();
                    numberToGuess = int.Parse(number);
                }
            }

            if (numberToGuess == randomNumber)
            {
                Console.WriteLine("YOU WON!!!");
            }

        }
    }
}

using System;

namespace MethodsExercise3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Numbers from 1000 to -1000
            OutputNumbers1000ToNeg1000();

            //Numbers from 3 to 999, by 3s
            Console.WriteLine();
            OutputNumbers3To999By3();

            //Check if two numbers are equal
            Console.WriteLine();
            var firstNumber = ParseNumberFromConsole("Enter a number (1 of 2)");
            var secondNumber = ParseNumberFromConsole("Enter a number (2 of 2)");
            CheckNumbersAreEqual(firstNumber, secondNumber);

            //Check if number is even or odd.
            Console.WriteLine();
            var userInput = ParseNumberFromConsole("Enter a number to see if it's even or odd.");
            CheckIfNumberIsEven(userInput);

            //Check if number is positive or negative
            Console.WriteLine();
            userInput = ParseNumberFromConsole("Enter a number to see if it's positive or negative.");
            CheckNumberIsPositiveOrNegative(userInput);

            //Check if candidate can vote or not
            Console.WriteLine();
            int candidateAge = ParseNumberFromConsole("Enter age of voting candidate.");
            CheckIfCandidateCanVote(candidateAge);

            //Check if integer is in range -10 to 10
            Console.WriteLine();
            userInput = ParseNumberFromConsole("Enter number to see if it's between 10 and -10");
            CheckIfNumberBetween10AndNeg10(userInput);

            //Output Multiplication table for number
            Console.WriteLine();
            userInput = ParseNumberFromConsole("Enter a number to get its multiplication table");
            OutputMultiplicationTable(userInput);
        }

        private static void OutputMultiplicationTable(int userInput)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{userInput} X {i} = {userInput * i}");
            }
        }

        private static void CheckIfNumberBetween10AndNeg10(int userInput)
        {
            if (userInput >= -10 && userInput <= 10)
            {
                Console.WriteLine($"{userInput} is between -10 and 10");
            }
            else
            {
                Console.WriteLine($"{userInput} is NOT between -10 and 10");
            }
        }

        private static void CheckIfCandidateCanVote(int candidateAge)
        {
            if (candidateAge > 120)
            {
                Console.WriteLine($"{candidateAge} is definitely old enough to vote. By quite a bit, I would say.");
            }
            else if (candidateAge >= 18)
            {
                Console.WriteLine($"{candidateAge} is old enough to vote. Get out there this November!");
            }
            else if (candidateAge == 17)
            {
                Console.WriteLine($"{candidateAge} isn't old enough to vote yet, but you can still register if you will BE 18 by election day!");
            }
            else if (candidateAge > 13)
            {
                Console.WriteLine($"{candidateAge} isn't old enough to vote yet; it won't be very long, though!");
            }
            else if (candidateAge < 0)
            {
                Console.WriteLine($"{candidateAge} doesn't seem like a valid age to me!");
            }
            else
            {
                Console.WriteLine($"{candidateAge} is pretty young. You have some time; go outside and play!");
            }
        }

        private static int ParseNumberFromConsole(string prompt)
        {
            bool numberWasEntered = false;
            int numberEntered = 0;
            do
            {
                Console.WriteLine(prompt);
                numberWasEntered = int.TryParse(Console.ReadLine(), out numberEntered);
            } while (!numberWasEntered);
            return numberEntered;

        }
        private static void CheckNumberIsPositiveOrNegative(int userInput)
        {
            if (userInput > 0)
            {
                Console.WriteLine($"{userInput} is positive. Yay!");
            }
            else if (userInput < 0)
            {
                Console.WriteLine($"{userInput} is negative. Maybe it needs to be cheered up?");
            }
            else
            {
                Console.WriteLine($"{userInput} is neither positive nor negative (it is 0.)");
            }
        }

        private static void CheckIfNumberIsEven(int userInput)
        {
            if ((userInput % 2) == 0)
            {
                Console.WriteLine($"{userInput} is even, Steven.");
            }
            else
            {
                Console.WriteLine($"{userInput} is odd, Todd.");
            }

        }

        private static void CheckNumbersAreEqual(int firstNumber, int secondNumber)
        {
            if (firstNumber == secondNumber)
            {
                Console.WriteLine($"{firstNumber} and {secondNumber} are equal. Are they twins?");
            }
            else
            {
                Console.WriteLine($"{firstNumber} and {secondNumber} are NOT equal. But we love them both.");
            }

        }

        private static void OutputNumbers3To999By3()
        {
            Console.WriteLine("Numbers from 3 to 999, by 3s.");
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine($"{i}");
            }
        }

        private static void OutputNumbers1000ToNeg1000()
        {
            Console.WriteLine("Numbers from 1000 to -1000");
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine($"{i}");
            }
        }
    }
}

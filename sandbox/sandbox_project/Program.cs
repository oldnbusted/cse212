using System;

public class Program
{
    static void Main(string[] args)
    {
        // This project is here for you to use as a "Sandbox" to play around
        // with any code or ideas you have that do not directly apply to
        // one of your projects.

        // Console.WriteLine("Hello Sandbox World!");
        // Console.Write("What is your first name? ");
        // string first_name = Console.ReadLine();
        // Console.Write("What is your last name? ");
        // string last_name = Console.ReadLine();
        // Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");

        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int gradePercentageNumber = int.Parse(gradePercentage);
        // int gradePercentageNumberLast = int.
        string gradeLetter;

        if (gradePercentageNumber >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradePercentageNumber >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradePercentageNumber >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradePercentageNumber >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        int lastDigit = gradePercentageNumber % 10;

        if ((gradePercentageNumber < 90 && gradePercentageNumber >= 60) && lastDigit >= 7)
        {
            gradeLetter += "+";
        }

        else if (gradePercentageNumber >= 60 && lastDigit <= 3)
        {
            gradeLetter += "-";
        }


        Console.WriteLine($"Your grade is {gradeLetter}");
        if (gradePercentageNumber >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }
        else
        {
            Console.WriteLine("Well...try again next time.");
        }

        string keepLooping = "yes";

        while (keepLooping == "yes")
        {
            int guess;
            int numberOfGuesses = 0;

            Console.Write("What is the magic number? ");
            int magicNumber = int.Parse(Console.ReadLine());
            do
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                numberOfGuesses++;
            } while (guess != magicNumber);

            Console.WriteLine($"You made {numberOfGuesses} guesses.");
            Console.Write("Would you like to play again? (yes/no) ");
            keepLooping = Console.ReadLine();
        }

        List<int> numbers = new List<int>();
        int newNumber;
        int listSum = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (true)
        {
            Console.Write("Enter number: ");
            newNumber = int.Parse(Console.ReadLine());
            if (newNumber == 0)
            {
                break;
            }
            numbers.Add(newNumber);
        }
        numbers.Sort();
    
        foreach (int num in numbers)
        {
            listSum += num;

        }
        float average = (float)listSum / numbers.Count;
        Console.WriteLine($"The sum is: {listSum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine("The largest number is " + numbers[numbers.Count - 1]);

    }
}
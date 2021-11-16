using System;
class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Please enter a number between 1 and 100:");
        string entry = Console.ReadLine();

        int number = int.Parse(entry);
    
        if (1 <= number && number <= 100)
        {
            if (number % 2 == 0) //number is even
            {
                if (number < 25)
                {
                    Console.WriteLine(number + " is Even and less than 25.");
                }
                else if (number < 61)
                {
                    Console.WriteLine(number + " is Even and between 26 and 60 inclusive.");
                }
                else
                    Console.WriteLine(number + " is Even and greater than 60.");
            }
            else //number is odd
                if (number < 60)
            {

                Console.WriteLine(number + " is Odd and less than 60.");
            }
            else
            {
                Console.WriteLine(number + " is Odd and greater than 60.");
            }
        }
        else
            Console.WriteLine("Sorry, next time please enter a number between 1 and 100.");


    }
}
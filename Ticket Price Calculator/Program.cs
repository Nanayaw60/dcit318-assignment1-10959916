using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        double ticketPrice;

        if (age <= 12 || age >= 65)
        {
            ticketPrice = 7.0;
            Console.WriteLine("You are eligible for a discounted ticket price of GHC" + ticketPrice);
        }
        else
        {
            ticketPrice = 10.0;
            Console.WriteLine("The regular ticket price is GHC" + ticketPrice);
        }

        Console.WriteLine("Your ticket price is GHC" + ticketPrice);
    }
}
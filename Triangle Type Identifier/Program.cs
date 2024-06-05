


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the length of side 1: ");
        int side1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the length of side 2: ");
        int side2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the length of side 3: ");
        int side3 = Convert.ToInt32(Console.ReadLine());

        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            Console.WriteLine("Invalid input. Side lengths must be positive.");
            return;
        }

        if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
        {
            Console.WriteLine("Invalid input. The sum of the lengths of any two sides must be greater than the length of the third side.");
            return;
        }

        if (side1 == side2 && side2 == side3)
        {
            Console.WriteLine("The triangle is Equilateral.");
        }
        else if (side1 == side2 || side1 == side3 || side2 == side3)
        {
            Console.WriteLine("The triangle is Isosceles.");
        }
        else
        {
            Console.WriteLine("The triangle is Scalene.");
        }
    }
}
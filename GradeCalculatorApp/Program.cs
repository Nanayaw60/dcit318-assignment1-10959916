using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


   

class Program
{
    static void Main()
    {
        Console.Write("Enter a numerical grade between 0 and 100: ");
        int grade = Convert.ToInt32(Console.ReadLine());

        if (grade < 0 || grade > 100)
        {
            Console.WriteLine("Invalid grade. Please enter a grade between 0 and 100.");
        }
        else if (grade >= 90)
        {
            Console.WriteLine("Grade: A");
        }
        else if (grade >= 80)
        {
            Console.WriteLine("Grade: B");
        }
        else if (grade >= 70)
        {
            Console.WriteLine("Grade: C");
        }
        else if (grade >= 60)
        {
            Console.WriteLine("Grade: D");
        }
        else
        {
            Console.WriteLine("Grade: F");
        }
    }
}


using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter monthly income: ");
        double income = Convert.ToDouble(Console.ReadLine());

        if (age >= 25 && age <= 35 && income > 50000)
        {
            Console.WriteLine("Category: Young Professional");
        }
        else if (age >= 36 && age <= 55 && income > 70000)
        {
            Console.WriteLine("Category: Middle-Aged Professional");
        }
        else if (age >= 56 && income < 30000)
        {
            Console.WriteLine("Category: Senior Citizen");
        }
        else
        {
            Console.WriteLine("Category: Other");
        }
    }
}

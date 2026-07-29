using System;

class Program
{
    static void Main(string[] args)
    {
        double principal, rate, time, interest;
        Console.Write("Enter Principal amount: ");
        principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Rate of Interest (%): ");
        rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter Time (in years): ");
        time = Convert.ToDouble(Console.ReadLine());
      
        interest = (principal * rate * time) / 100;
      
        Console.WriteLine();
        Console.WriteLine("Simple Interest: " + interest);
    }
}

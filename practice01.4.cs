using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter exam score: ");
        int score = Convert.ToInt32(Console.ReadLine());

        string result = (score >= 50) ? "Passed" : "Failed";

        Console.WriteLine(result);
    }
}

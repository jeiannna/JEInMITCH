using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nChoose an option:");
        Console.WriteLine("A - Compute Area");
        Console.WriteLine("P - Compute Perimeter");
        Console.WriteLine("X - Exit");

        Console.Write("Enter your choice: ");
        char choice = Convert.ToChar(Console.ReadLine().ToUpper());

        switch (choice)
        {
            case 'A':
                double area = Math.PI * radius * radius;
                Console.WriteLine("Area of the circle: " + area);
                break;

            case 'P':
                double perimeter = 2 * Math.PI * radius;
                Console.WriteLine("Perimeter of the circle: " + perimeter);
                break;

            case 'X':
                Console.WriteLine("Exiting the application...");
                break;

            default:
                Console.WriteLine("Invalid choice.");
                break;
        }
    }
}

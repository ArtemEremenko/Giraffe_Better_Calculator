using System.Diagnostics.Metrics;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)

    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter number 1 ");
        float num1;
        while (!float.TryParse(Console.ReadLine(), out num1))
        {
            Console.WriteLine("Enter float please");
        }
         
        Console.WriteLine("Enter operator");
        string operato;
        while (true) 
        {
            operato = Console.ReadLine();
            if (operato == "+" || operato == "-" || operato == "*" || operato == "/")
            {
                break;
            }
            else
            {
                Console.WriteLine("Enter operator + - * /");
            }
        }

        Console.WriteLine("Enter number 2 ");
        float num2;
        while (!float.TryParse(Console.ReadLine(), out num2))
        {
            Console.WriteLine("Enter float please");
        }

        if (operato == "+")
        {
            Console.WriteLine("Answer is " + (num1 + num2));
        }
        else if (operato == "-")
        {
            Console.WriteLine("Answer is " + (num1 - num2));
        }
        else if (operato == "*")
        {
            Console.WriteLine("Answer is " + (num1 * num2));
        }
        else if (operato == "/")
        {
            Console.WriteLine("Answer is " + (num1 / num2));
        }
        else
        {
            Console.WriteLine("Wrong operator");
        }
    }
} 
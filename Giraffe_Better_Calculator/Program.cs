using System.Diagnostics.Metrics;
using System.Dynamic;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)


    {

        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Enter number 1");
        float num1 = GetFloatInput();

        Console.WriteLine("Enter operator");
        string oper = GetOperInput();

        Console.WriteLine("Enter number 2");
        float num2 = GetFloatInput();

        string answ = "Answer is ";

        if (oper == "+")
        {
            Console.WriteLine(answ + (num1 + num2));
        }
        else if (oper == "-")
        {
            Console.WriteLine(answ + (num1 - num2));
        }
        else if (oper == "*")
        {
            Console.WriteLine(answ + (num1 * num2));
        }
        else if (oper == "/")
        {
            Console.WriteLine(answ + (num1 / num2));
        }

    }
    private static float GetFloatInput()
    {
        float num;
        while (!float.TryParse(Console.ReadLine(), out num))
        {
            Console.WriteLine("Enter float please");
        }
        
        return num;
    }

    private static string GetOperInput()
    {
        string oper;
        while (true)
        {
            oper = Console.ReadLine();
            if (oper == "+" || oper == "-" || oper == "*" || oper == "/")
            {
                break;
            }
            else
            {
                Console.WriteLine("Enter operator + - * /");
            }
        }
        return oper;


        //Console.WriteLine("Enter number 1 ");
        //float num1;

        //while (!float.TryParse(Console.ReadLine(), out num1))
        //{
        //    Console.WriteLine("Enter float please");
        //}

        //Console.WriteLine("Enter operator");
        //string operato;
        //while (true) 
        //{
        //    operato = Console.ReadLine();
        //    if (operato == "+" || operato == "-" || operato == "*" || operato == "/")
        //    {
        //        break;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Enter operator + - * /");
        //    }
        //}

        //Console.WriteLine("Enter number 2 ");
        //float num2;
        //while (!float.TryParse(Console.ReadLine(), out num2))
        //{
        //    Console.WriteLine("Enter float please");
        //}

        //string answ = ("Answer is ");

        //if (operato == "+")
        //{
        //    Console.WriteLine(answ + (num1 + num2));
        //}
        //else if (operato == "-")
        //{
        //    Console.WriteLine(answ + (num1 - num2));
        //}
        //else if (operato == "*")
        //{
        //    Console.WriteLine(answ + (num1 * num2));
        //}
        //else if (operato == "/")
        //{
        //    Console.WriteLine(answ + (num1 / num2));
        //}
    }
    
    
} 
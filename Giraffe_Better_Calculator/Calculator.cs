using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giraffe_Better_Calculator
{
    internal class Calculator
    {
        public static void Run()
        {
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
        }
    }
}

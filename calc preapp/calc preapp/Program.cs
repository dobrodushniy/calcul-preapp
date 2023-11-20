using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc_preapp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char again = 'y';
            while (again == 'y')
            {
                double a;
                double b;
                double total;
                char oper;

                Console.WriteLine("enter the first number.");
                if (!double.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("enter a valid number.");
                    continue;
                }

                Console.WriteLine("Enter operator (+, -, *, /):");
                if (!char.TryParse(Console.ReadLine(), out oper) || !IsValidOperator(oper))
                {
                    Console.WriteLine("enter a valid operator (+, -, *, /).");
                    continue;
                }

                Console.WriteLine("enter the second number.");
                if (!double.TryParse(Console.ReadLine(), out b))
                {
                    Console.WriteLine("enter a valid number.");
                    continue;
                }

                switch (oper)
                    {
                        case '+':
                            total = a + b;
                            Console.WriteLine($"{a} + {b} = {total}.");
                            break;

                        case '-':
                            total = a - b;
                            Console.WriteLine($"{a} - {b} = {total}.");
                            break;

                        case '*':
                            total = a * b;
                            Console.WriteLine($"{a} * {b} = {total}.");
                            break;

                        case '/':
                            if (b == 0)
                            {
                                Console.WriteLine("cannot divide");
                            }
                            else
                            {
                                total = a / b;
                                Console.WriteLine($"{a} / {b} = {total}.");
                            }
                            break;

                        default:
                            Console.WriteLine("Unknown operator.");
                            break;
                    }
                
                    Console.WriteLine("you want to continue? (y/n)");
                again = Convert.ToChar(Console.ReadLine());


            }
        }
            static bool IsValidOperator(char op)
            {
                return op == '+' || op == '-' || op == '*' || op == '/';
            }


        
    }
}













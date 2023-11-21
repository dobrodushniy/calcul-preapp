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
            char again = 'y'; // assigns 'y' = again

            while (again == 'y')  // if button y active === repeat action if no end 
            {
                Console.WriteLine("number");
                string input = Console.ReadLine();  //convert text in the input variable..... text == input 
                int.TryParse(input, out int number);  //assigns input (string) in the number (int) variable which can be used in the operation

                Console.WriteLine("number1");
                string input1 = Console.ReadLine();  //same shit
                int.TryParse(input1, out int number1);


                Console.WriteLine("choise the operation? (q, w, e. r)"); 
                ConsoleKeyInfo keyInfo = Console.ReadKey(); // assigns keyinfo == button active == for use this information in switch lines


                switch (keyInfo.Key) // =_=  0_0 0-0 
                {
                    case ConsoleKey.Q: // 'q' == active division
                        Division(number, number1);
                        break;

                    case ConsoleKey.W: // same example top
                        Multipl(number, number1);
                        break;

                    case ConsoleKey.E:
                        Minus(number, number1);
                        break;

                    case ConsoleKey.R:
                        Plus(number, number1);
                        Console.Clear();
                        break;

                    default: // if someone missclick will repeat the fonction
                        Console.WriteLine("invalid operation.");
                        break;
                }

                Console.WriteLine("Press any key to return to Main...");
                Console.ReadKey(); // pendint active button before write text
                Console.WriteLine("Do you want to continue? (y/n)");
                again = Console.ReadKey().KeyChar; // again == y == restart calculator
                Console.Clear(); // clear console
            }

        }

        static void Division(int number, int number1) 
        {
            if (number1 != 0) // if number1 isnt 0 will start method
            {
                double result = (double)number / number1; // double means it converts integers to decimals 
                Console.WriteLine($" --- Division result: {result}");
            }
            else
            {
                Console.WriteLine(" --- Cannot divide by zero.");
            }
        }

        static void Multipl(int number, int number1) // +_-
        {
            double result = (double)number * number1; //same
            Console.WriteLine($" --- Multiplication result: {result}");
        }

        static void Minus(int number, int number1) //  \_+_+_/
        {
            double result = (double)number - number1;//same
            Console.WriteLine($" --- subtracting result: {result}");
        }

        static void Plus(int number, int number1)
        {
            double result = (double)number + number1; //same
            Console.WriteLine($" --- addition result: {result}");
        }



    }

}
















//same calcultor but more simple and practical
//where you dont need to know binds on keyboard.....:)

/* char again = 'y';
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


*/













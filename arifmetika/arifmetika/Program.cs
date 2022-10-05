using System;

namespace arifmetika
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double result;
            char op;

            Console.WriteLine("Введите первое число: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите арифметическое действие: ");
            op = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Введите второе число: ");
            b = Convert.ToDouble(Console.ReadLine());

            if (op == '+')
            {
                result = a + b;
                Console.WriteLine(+a + "+" + b + "=" + result);
            }
            else if (op == '-')
            {
                result = a - b;
                Console.WriteLine(+a + "-" + b + "=" + result);
            }
            else if (op == '*')
            {
                result = a * b;
                Console.WriteLine(+a + "*" + b + "=" + result);
            }
            else if (op == '/')
            {
                result = a / b;
                Console.WriteLine(+a + "/" + b + "=" + result);
            }
            else
            {
                Console.WriteLine("Неправильно! Попытайтесь заново.");
            }

        }
    }

}



using System;

namespace AppWorking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число:");
            int _one = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            int _two = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите арифметический знак:");
            string _znak = Console.ReadLine();

            int result;

            switch (_znak)
            {
                case "+":
                    Arguments arguments = new Arguments();
                    result = arguments.Summ(_one,_two);
                    Console.WriteLine($"{_one} + {_two} = {result}");
                    break;
                case "-":
                    Arguments arguments1 = new Arguments();
                    result = arguments1.Minus(_one,_two);
                    Console.WriteLine($"{_one} - {_two} = {result}");
                    break;
                case "*":
                    Arguments arguments2 = new Arguments();
                    result = arguments2.Umn(_one,_two);
                    Console.WriteLine($"{_one} * {_two} = {result}");
                    break;
                case "/":
                    Arguments arguments3 = new Arguments();
                    result = arguments3.Delenie(_one, _two);
                    Console.WriteLine($"{_one} / {_two} = {result}");
                    break;
                default:
                    Console.WriteLine("Вы ввели не тот символ");
                    break;

            }
        }
    }
}

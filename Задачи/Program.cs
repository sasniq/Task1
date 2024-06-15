using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите первое число:");
            double firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            double secondNumber = Convert.ToDouble(Console.ReadLine());

            if (firstNumber == secondNumber)
            {
                Console.WriteLine("Числа равны");
            }
            else if (firstNumber > secondNumber)
            {
                Console.WriteLine("Первое число больше второго");
            }
            else
            {
                Console.WriteLine("Первое число меньше второго");
            }

            Console.WriteLine("\nХотите сравнить другие числа? (да/нет)");
            string answer = Console.ReadLine().ToLower();

            if (answer != "да")
            {
                break;
            }
        }

        Console.WriteLine("Программа завершена. Нажмите любую клавишу, чтобы выйти...");
        Console.ReadKey();
    }
}

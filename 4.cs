using System;

class Program
{
    static void Main()
    {
        int sum = 0;
        int x;

        Console.WriteLine("Введите положительное число X: ");
        x = Convert.ToInt32(Console.ReadLine());

        while (true)
        {
            Console.WriteLine("Введите число (для завершения введите отрицательное число): ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                break; // Завершение цикла при вводе отрицательного числа
            }

            if (number % x == 0)
            {
                sum += number;
            }
        }

        Console.WriteLine("Сумма чисел, делящихся на " + x + " нацело, равна " + sum);
    }
}
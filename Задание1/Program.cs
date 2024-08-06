using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение M (натуральное число): ");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите значение N (натуральное число, большее или равное M): ");
        int N = Convert.ToInt32(Console.ReadLine());

        if (M > 0 && N >= M)
        {
            PrintNaturalNumbers(M, N);
        }
        else
        {
            Console.WriteLine("Неправильные значения. Убедитесь, что M - натуральное число и N >= M.");
        }
    }

    static void PrintNaturalNumbers(int current, int N)
    {
        if (current > N) return; // Если текущее число больше N, завершаем рекурсию

        Console.WriteLine(current); // Выводим текущее число
        PrintNaturalNumbers(current + 1, N); // Рекурсивный вызов с увеличением текущего числа
    }
}
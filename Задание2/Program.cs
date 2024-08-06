using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите неотрицательное число m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Введите неотрицательное число n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (m >= 0 && n >= 0)
        {
            long result = Ackermann(m, n);
            Console.WriteLine($"A({m}, {n}) = {result}");
        }
        else
        {
            Console.WriteLine("Введите неотрицательные числа для m и n.");
        }
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0) return n + 1;
        else if (m == 1) return n + 2;
        else if (m == 2) return 2 * n + 3;
        else if (m == 3) return (1 << (n + 3)) - 3; 
        else return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}
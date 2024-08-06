using System;

class Program
{
    static void Main(string[] args)
    {
        // Создание произвольного массива
        int[] array = { 1, 2, 3, 4, 5 };

        Console.WriteLine("Элементы массива в обратном порядке:");
        
        // Вызов рекурсивной функции для вывода элементов массива
        PrintArrayReverse(array, array.Length - 1);
    }

    static void PrintArrayReverse(int[] array, int index)
    {
        // Базовый случай: если индекс меньше 0, выходим из функции
        if (index < 0)
            return;

        // Вывод текущего элемента массива
        Console.WriteLine(array[index]);

        // Рекурсивный вызов для следующего элемента
        PrintArrayReverse(array, index - 1);
    }
}
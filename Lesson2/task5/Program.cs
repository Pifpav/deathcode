using System;

class Program
{
    static void Main()
    {
        int size = 10;
        int[] arr_int = new int[size];
        int i = 0;
        
        while (i < size)
        {
            Console.Write($"Введите элемент [{i + 1}/{size}]: ");
            string input = Console.ReadLine();
            
            // Проверка корректности ввода
            if (int.TryParse(input, out int number))
            {
                arr_int[i] = number;
                i++;
            }
            else
            {
                Console.WriteLine("Ошибка! Введите целое число.");
            }
        }
        
        // Вывод результата
        Console.WriteLine("\nГотовый массив:");
        for (int j = 0; j < size; j++)
        {
            Console.WriteLine($"arr_int[{j}] = {arr_int[j]}");
        }
        
        Console.WriteLine("\nНажмите любую клавишу для выхода...");
        Console.ReadKey();
    }
}

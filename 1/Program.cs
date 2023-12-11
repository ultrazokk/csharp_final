// Задайте значения M и N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

class Program
{
    static void PrintNumbersInRange(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNumbersInRange(m + 1, n);
        }
    }

    static void Main()
    {
        int m = 1; 
        int n = 5; 

        Console.WriteLine($"Натуральные числа от {m} до {n}:");
        PrintNumbersInRange(m, n);
    }
}












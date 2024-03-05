using System;

class Program
{
    static void Main()
    {
        int num = 5; 
        int length = 10 + num;
        int[] X = new int[length];

        Console.WriteLine($"Введіть {length} чисел для масиву X:");
        for (int i = 0; i < length; i++)
        {
            X[i] = Convert.ToInt32(Console.ReadLine());
        }

        int min = X[0];
        int max = X[0];
        foreach (int val in X)
        {
            if (val < min) min = val;
            if (val > max) max = val;
        }

        Console.WriteLine("Масив X:");
        foreach (int val in X)
        {
            Console.Write(val + " ");
        }
        Console.WriteLine($"\nМінімальне значення: {min}");
        Console.WriteLine($"Максимальне значення: {max}");
    }
}

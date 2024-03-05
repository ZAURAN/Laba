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

        Console.WriteLine("Введіть число М:");
        int M = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        foreach (int val in X)
        {
            if (Math.Abs(val) > M) count++;
        }

        int[] Y = new int[count];
        int j = 0; 
        foreach (int val in X)
        {
            if (Math.Abs(val) > M)
            {
                Y[j] = val;
                j++;
            }
        }

        Console.WriteLine($"Число М: {M}");
        Console.Write("Масив X: ");
        foreach (int val in X)
        {
            Console.Write(val + " ");
        }
        Console.Write("\nМасив Y: ");
        foreach (int val in Y)
        {
            Console.Write(val + " ");
        }
    }
}

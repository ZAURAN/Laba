using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть три цілих числа:");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int c = Convert.ToInt32(Console.ReadLine());
        
        
        int num = 5; 
        int max = 10 + num;

        Console.WriteLine($"Числа, що належать інтервалу [1, {max}]:");
        if (a >= 1 && a <= max) Console.WriteLine(a);
        if (b >= 1 && b <= max) Console.WriteLine(b);
        if (c >= 1 && c <= max) Console.WriteLine(c);
    }
}

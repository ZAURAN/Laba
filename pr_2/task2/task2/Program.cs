using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть три сторони трикутника:");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        if (a <= 0 || b <= 0 || c <= 0 || a + b <= c || a + c <= b || b + c <= a)
        {
            Console.WriteLine("Трикутник неможливий.");
            return;
        }

        double perimeter = a + b + c;
        double s = perimeter / 2;
        double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

        Console.WriteLine($"Периметр трикутника: {perimeter}");
        Console.WriteLine($"Площа трикутника: {area}");

        if (a == b && b == c)
            Console.WriteLine("Трикутник рівносторонній.");
        else if (a == b || b == c || a == c)
            Console.WriteLine("Трикутник рівнобедрений.");
        else
            Console.WriteLine("Трикутник різносторонній.");
    }
}

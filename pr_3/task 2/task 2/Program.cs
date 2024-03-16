using System;
using System.Drawing;

/* --- Клас Point
public class Point
{
    private int x;
    private int y;
    private string pointName;

    public int X
    {
        get { return x; }
    }

    public int Y
    {
        get { return y; }
    }

    public string PointName
    {
        get { return pointName; }
    }

    public Point(int x, int y, string pointName)
    {
        this.x = x;
        this.y = y;
        this.pointName = pointName;
    }
}
*/


/* --- Клас Figure
using System.Drawing;

public class Figure
{
    private Point[] points;

    public Figure(Point a, Point b, Point c)
    {
        points = new Point[] { a, b, c };
    }

    public Figure(Point a, Point b, Point c, Point d)
    {
        points = new Point[] { a, b, c, d };
    }

    public Figure(Point a, Point b, Point c, Point d, Point e)
    {
        points = new Point[] { a, b, c, d, e };
    }

    private double LengthSide(Point A, Point B)
    {
        return Math.Sqrt(Math.Pow((B.X - A.X), 2) + Math.Pow((B.Y - A.Y), 2));
    }

    public void PerimeterCalculator()
    {
        double perimeter = 0;
        for (int i = 0; i < points.Length; i++)
        {
            if (i == points.Length - 1)
            {
                perimeter += LengthSide(points[i], points[0]);
            }
            else
            {
                perimeter += LengthSide(points[i], points[i + 1]);
            }
        }

        Console.WriteLine($"Периметр багатокутника: {perimeter}");
    }
}
*/



/* --- Програма для демонстрації
class Program
{
    static void Main(string[] args)
    {
        Point a = new Point(0, 0, "A");
        Point b = new Point(4, 0, "B");
        Point c = new Point(4, 3, "C");

        Figure triangle = new Figure(a, b, c);
        Console.WriteLine("Трикутник:");
        triangle.PerimeterCalculator();

        Point d = new Point(0, 3, "D");
        Figure rectangle = new Figure(a, b, c, d);
        Console.WriteLine("Прямокутник:");
        rectangle.PerimeterCalculator();
    }
}
*/
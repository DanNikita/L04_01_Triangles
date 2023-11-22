using System;

public class Operation
{
    public static double Calc(double a, double b, double c)
    {
        if (Operation.Check(a, b, c) == true)
        {
            Console.WriteLine("Entering method for three sides");
            double per = a + b + c;
            double s = Math.Sqrt(per * (per - a) * (per - b) * (per - c));
            return s;
        }
        else
        {
            Console.WriteLine("Not a trinagle");
            return 0;
        }

    }
    static bool Check(double a, double b, double c)
    {
        Console.WriteLine("Entering method to check sides");
        if (a != 0 & b != 0 & c != 0)
            return true;
        else
            return false;
    }
    public static double Calc(double a)
    {
        if (a != 0)
        {
            Console.WriteLine("Entering method for 3 same sides");
            double per = a * 3;
            double s = Math.Sqrt(per * (per - a) * (per - a) * (per - a));
            return s;
        }
        else
        {
            Console.WriteLine("Not a triangle");
            return 0;
        }

    }
}
internal class Triangles
{

    static void Main(string[] args)
    {
        Console.Write("Enter three sides, a:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c:");
        double c = double.Parse(Console.ReadLine());
        double result;
        if (a == b & b == c)
        {
            Console.WriteLine("Three sides are the same");
            result = Operation.Calc(a);
        }
        else
        {
            Console.WriteLine("Three sides are different");
            result = Operation.Calc(a, b, c);
        }
        Console.Write("Result: {0}", result);
        Console.ReadLine();
    }
}
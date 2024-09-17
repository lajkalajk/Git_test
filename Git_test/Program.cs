internal class Program
{
    private static void Main(string[] args)
    {
        //hi﻿
        Console.WriteLine("ahoi");
        Console.WriteLine("aho");

        Console.WriteLine("23 + 27 = " + Add(23, 27));
        Console.WriteLine("2 - 2 = " + Subtract(3, 2));
        Console.WriteLine("3 * 8 = " + Multiply(3, 8));
    }

    public static int Add(int x, int y)
    {
        return x + y;
    }
    public static int Subtract(int x, int y)
    {
        return x - y;
    }
    public static int Multiply(int x, int y)
    {
        return x * y;
    }
}
















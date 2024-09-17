internal class Program
{
    private static void Main(string[] args)
    {
        //hi﻿
        Console.WriteLine("ahoi");
        Console.WriteLine("aho");

        Console.WriteLine("2 + 2 = " + Add(2, 2));
        Console.WriteLine("2 - 2 = " + Subtract(2, 2));
        Console.WriteLine("2 * 2 = " + Multiply(2, 2));
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
















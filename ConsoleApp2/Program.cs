﻿namespace ConsoleApp2
{
    internal class Program
    {
        private static int func(int x, int y)
        {
            int z = (int)Math.Pow(x, y);
            return z;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int res = func(a, b);
            Console.WriteLine(res);
        }
    }
}
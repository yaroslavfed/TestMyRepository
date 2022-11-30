namespace ConsoleApp2
{
    internal class Program
    {
        private static void func(ref int z, int x, int y)
        {
            z = (int)Math.Pow(x, y);
        }

        static void Main(string[] args)
        {
            int z = 0;
            Console.WriteLine("Hello, World!");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            func(ref z, a, b);
            Console.WriteLine(z);
        }
    }
}
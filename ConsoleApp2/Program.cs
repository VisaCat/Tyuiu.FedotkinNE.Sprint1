namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = 7;

            int b = a % 3 + 1;

            a++;

            b *= a - 5;

            int x = a - b;

            Console.WriteLine(x);
        }
    }
}

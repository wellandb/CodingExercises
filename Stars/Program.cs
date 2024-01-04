using System.Data;

namespace Stars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 5;
            int r = 2 * row + 1;

            for (int i = 0; i < row; i++)
            {
                Console.WriteLine(String.Concat(Enumerable.Repeat(" ", r-i)) + String.Concat(Enumerable.Repeat("*",i*2+1)));
            }
        }
    }
}

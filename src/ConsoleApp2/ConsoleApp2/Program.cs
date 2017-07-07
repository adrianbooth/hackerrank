using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            decimal itemCount = n;

            Console.WriteLine(Math.Round(arr.Where(e => e > 0).Count() / itemCount, 6));
            Console.WriteLine(Math.Round(arr.Where(e => e < 0).Count() / itemCount, 6));
            Console.WriteLine(Math.Round(arr.Where(e => e == 0).Count() / itemCount, 6));
            Console.ReadLine();
        }
    }
}

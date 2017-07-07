using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static int birthdayCakeCandles(int n, int[] ar)
        {
            var highestCandle = ar.Max();
            return ar.Where(e => e == highestCandle).Count();
        }

        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            int result = birthdayCakeCandles(n, ar);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

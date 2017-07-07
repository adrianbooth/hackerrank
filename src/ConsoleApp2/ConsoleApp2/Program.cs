using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(String[] args)
        {
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            var orderedArray = arr.OrderBy(e => e);
            long lowestSum = orderedArray.Select(e => (long)e).Take(4).Sum();
            long highestSum = orderedArray.Select(e => (long)e).Skip(1).Take(4).Sum();

            Console.WriteLine($"{lowestSum} {highestSum}");

            Console.ReadLine();
        }
    }
}

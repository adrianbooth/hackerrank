using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static string timeConversion(string dateString)
        {
            DateTime date;
            if (!DateTime.TryParse(dateString, out date))
                throw new ArgumentException("error parsing date", nameof(dateString));

            return date.ToString("HH:mm:ss");
        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}

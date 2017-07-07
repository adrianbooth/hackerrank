using System;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                var spacesNeeded = n - i;
                var hashesNeeded = i;
                string output = "";
                while (spacesNeeded > 0)
                {
                    output+=" ";
                    spacesNeeded--;
                }

                while (hashesNeeded > 0)
                {
                    output += "#";
                    hashesNeeded--;
                }
                Console.WriteLine(output);
            }
            Console.ReadLine();
        }
    }
}

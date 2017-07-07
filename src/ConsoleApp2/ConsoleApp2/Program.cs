using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(String[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[][] a = new int[n][];
            for (int a_i = 0; a_i < n; a_i++)
            {
                string[] a_temp = Console.ReadLine().Split(' ');
                a[a_i] = Array.ConvertAll(a_temp, Int32.Parse);
            }

            var primaryDiagonal = SumPrimaryDiagonal(a, n);
            var secondaryDiagonal = SumSecondaryDiagonal(a, n);

            Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
        }

        private static int SumPrimaryDiagonal(int[][] matrix, int length)
        {
            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                sum += matrix[i][i];
            }
            return sum;
        }
        private static int SumSecondaryDiagonal(int[][] matrix, int length)
        {
            int sum = 0;

            for (int i = 0; i < length; i++)
            {
                sum += matrix[i][length - (1 + i)];
            }
            return sum;
        }
    }
}

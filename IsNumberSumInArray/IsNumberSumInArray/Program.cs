using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsNumberSumInArray
{
    public class Program
    {
        public static bool IsKSumInArray(int[] arr, int k)
        {
            foreach (int number in arr)
            {
                if (arr.Contains(k - number))
                {
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            int[] arr = { 10, 15, 3, 7 };
            Console.WriteLine(IsKSumInArray(arr, 26));
            Console.ReadKey();
        }
    }
}

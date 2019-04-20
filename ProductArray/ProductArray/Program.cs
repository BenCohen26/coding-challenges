using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductArray
{
    class Program
    {
        public static int[] ProductOfOtherItems(int[] arr)
        {
            int[] productArray = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int product = 1;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (!j.Equals(i))
                    {
                        product *= arr[j];
                    }
                }

                productArray[i] = product;
            }

            return productArray;
        }

        public static void Main(string[] args)
        {
            int[] testArray = { 1, 2, 3, 4, 5 };
            ProductOfOtherItems(testArray);
            Console.ReadKey();
        }
    }
}

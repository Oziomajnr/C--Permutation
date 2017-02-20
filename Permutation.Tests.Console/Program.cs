using System;
using System.Linq;
using System.Collections.Generic;

namespace Permutation.Tests.Console
{
    public class Test
    { 
        public static void Main()
        {
            Permutation<int> permutation_object = new Permutation<int>();
            int[] my_set = { 1, 2, 3, 4 };

            foreach (int[] arr in permutation_object.permutate(4, 1, 2, 3, 4))
            {
                printArray(arr);
            }
            System.Console.Read();
        }

        public static void printArray(int[] arr)
        {
            System.Console.WriteLine(arr.Select(item => Convert.ToString(item)).Aggregate((itemA, itemB) => itemA + ", " + itemB));
        }
    }
}

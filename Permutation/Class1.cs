using System.Collections.Generic;

namespace Permutation
{
    /// <summary>
    /// Implementation of heaps algorithm for permutating through an array of items
    /// </summary>
    /// <typeparam name="T">place holder for the type of item</typeparam>
    class Permutation<T>
    {
        //Pseudocode for heaps algorithm from https://en.wikipedia.org/wiki/Heap's_algorithm

        //        procedure generate(n : integer, A: array of any):
        //if n = 1 then
        //      output(A)
        //else
        //    for i := 0; i < n - 1; i += 1 do
        //                generate(n - 1, A)
        //        if n is even then
        //            swap(A[i], A[n - 1])
        //        else
        //            swap(A[0], A[n - 1])
        //        end if
        //    end for
        //    generate(n - 1, A)
        //end if


        /// <summary>
        /// Permutate an array of items and get a list of the permutated items
        /// </summary>
        /// <param name="n">The lenght of the items to be permutated</param>
        /// <param name="array">The array of items to be permutated</param>
        /// <returns>A list of the different permutated array</returns>
        public static List<T[]> permutate(int n, params T[] array)
        {
            List<T[]> permutated_items = new List<T[]>();

            if (n == 1)
            {
                    permutated_items.Add(array);
            }

            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    permutate(n - 1, array);
                    if (n % 2 == 0)
                    {
                        swap(ref array[i], ref array[n - 1]);
                    }
                    else
                    {
                        swap(ref array[0], ref array[n - 1]);
                    }
                }
                permutate(n - 1, array);
            }
            return permutated_items;
        }

        private static void swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}



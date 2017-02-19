using System.Linq;
using System.Collections.Generic;

namespace Permutation
{
    /// <summary>
    /// Implementation of heaps algorithm for permutating through an array of items
    /// </summary>
    /// <typeparam name="T">place holder for the type of item</typeparam>
  public class Permutation<T>
    {
        /// <summary>
        /// Permutate an array of items and get a list of the permutated items
        /// </summary>
        /// <param name="n">The lenght of the items to be permutated</param>
        /// <param name="array">The array of items to be permutated</param>
        /// <returns>A list of the different permutated array</returns>
        /// 
        List<T[]> permutated_items = new List<T[]>();
        private List<T[]> perm(int n, params T[] array)
        {
            if (n == 1)
            {
                // the is where each permutation is added 
                    permutated_items.Add(array.ToList().ToArray());
            }

            else
            {
                for (int i = 0; i < n - 1; i++)
                {
                    perm(n - 1, array);
                    if (n % 2 == 0)
                    {
                        swap(ref array[i], ref array[n - 1]);
                    }
                    else
                    {
                        swap(ref array[0], ref array[n - 1]);
                    }
                }
                perm(n - 1, array);
            }
           
            return permutated_items;
        }

        public List<T[]> permutate(params T[] array)
        {
          List<T[]> result =  perm(array.Length, array);
            permutated_items = new List<T[]>();
            return result;
        }

        /// <summary>
        /// Permuation for Arrays rather than params
        /// </summary>
        /// <param name="array">The Array to be permutated</param>
        /// <param name="n"></param>
        /// <param name="permutated_items"></param>
        /// <returns>Permutated Items</returns>
        public List<T[]> permutate(T[] array, int n = -1, List<T[]> permutated_items = null)
        {
            if (permutated_items == null) permutated_items = new List<T[]>();
            if (n == -1) n = array.Length;
            if (n == 1) permutated_items.Add(array.ToList().ToArray());
            else
            {
                for (int i = 0; i < n; i++)
                {
                    permutate(array, n - 1, permutated_items);//
                    if (n % 2 == 0) swap(ref array[i], ref array[n - 1]);
                    else swap(ref array[0], ref array[n - 1]);
                }
            }
            return permutated_items;
        }

        /// <summary>
        /// swap two variables
        /// </summary>
        /// <param name="x">the first variable to be swapped</param>
        /// <param name="y">the second variable to be swapped</param>
        private static void swap(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }
    }
}

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


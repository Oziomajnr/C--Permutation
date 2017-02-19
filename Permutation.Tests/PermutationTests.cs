using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Permutation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Permutation.Tests
{
    [TestClass]
    public class PermutationTests
    {
        private int nFactoria (int n)
        {
            int product = 1;
            while (n >= 1) product *= n--;
            return product;
        }

        private void printArray(int[] arr)
        {
            System.Console.WriteLine(arr.Select(item => Convert.ToString(item)).Aggregate((itemA, itemB) => itemA + ", " + itemB));
        }

        [TestMethod]
        public void Test_That_No_Of_Returned_Items_Is_N_Factoria()
        {
            int[] arr = new int[] {  };
            Permutation<int> p = new Permutation<int>();
            var results = p.permutate(1, 2, 3, 4, 5);
            Assert.AreEqual(results.Count, nFactoria(5));
            results.ForEach((result) => printArray(result));
        }

        [TestMethod]
        public void Test_That_Returned_Items_Are_Unique()
        {
            int[] arr = new int[] { };
            Permutation<int> p = new Permutation<int>();
            var results = p.permutate(1, 2, 3, 4, 5);
            CollectionAssert.AllItemsAreUnique(results.Select(result => result.Select(item => Convert.ToString(item)).Aggregate((a, b) => Convert.ToString(a) + " " + Convert.ToString(b))).ToList());
            results.ForEach((result) => printArray(result));
        }
    }
}

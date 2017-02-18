namespace Permutation
{
    class Test
    {
      
        public static void Main()
        {
            Permutation<int> permutation_object = new Permutation<int>();
            int[] my_set = { 1, 2, 3, 4 };

            foreach (int[] x in Permutation.Permutation<int>.permutate(4, my_set))
            {
                System.Console.WriteLine(x);
            }
            System.Console.Read();
        }
    }
}

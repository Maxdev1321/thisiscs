using System;

namespace GenericDelegate
{
    delegate int Compare<T>(T a, T b);

    class MainApp
    {
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }
        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b)*-1;
        }


        static void BubbleSort<T>(T[] Dataset, Compare<T> Comparer)
        {
            int i = 0;
            int j = 0;
            T temp;

            for (i=0;i<Dataset.Length;i++)
            {
                for (j = 0; j < Dataset.Length - (i+1); j++)
                {
                    if(Comparer(Dataset[j],Dataset[j+1])>0)
                    {
                        temp = Dataset[j + 1];
                        Dataset[j + 1] = Dataset[j];
                        Dataset[j] = temp;
                    }
                }
            }
        }
        static void Main(string[]args)
        {
            int[] array = { 3, 7, 4, 2, 10 };

            Console.WriteLine("Sorting ascending...");
            BubbleSort(array, new Compare<int>(AscendCompare));
            
            for (int i = 0; i < array.Length; i++)
                Console.Write($"{array[i]},");

            string[] array2 = { "abc", "def", "ghi", "jkl", "mno" };
            Console.WriteLine("\nSorting descending...");
            BubbleSort<string>(array2, new Compare<string>(DescendCompare));

            for (int i = 0; i < array2.Length; i++)
                Console.Write($"{array2[i]},");

            Console.WriteLine();

        }
    }
}

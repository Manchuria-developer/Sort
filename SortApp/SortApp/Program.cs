using System;

namespace SortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 6, 2 };
            BubbleSort(array);
            foreach (var i in array)
            {
                Console.Write(i + " ");
            }
        }

        static void BubbleSort(int[] intArray)
        {
            int temp = 0;
            bool swapped;
            for (int i = 0; i < intArray.Length; i++)
            {
                swapped = false;
                for (int j = 0; j < intArray.Length - 1 - i; j++)
                    if (intArray[j] > intArray[j + 1])
                    {
                        temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                        if (!swapped)
                            swapped = true;
                    }
                if (!swapped)
                    return;
            }
        }
    }
}


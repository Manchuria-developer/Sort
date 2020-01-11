using System;

namespace SortApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 3, 5, 6, 2 };
            ShellSort(array);
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
                { 
                    if (intArray[j] > intArray[j + 1])
                    {
                        temp = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j + 1] = temp;
                        if (!swapped)
                            swapped = true;
                    }
                }
                if (!swapped)
                    return;
            }
        }

        static void SelectionSort(int[] intArray)
        {
            int i, j, min, len = intArray.Length;
            int temp;
            for (i = 0; i < len - 1; i++)
            {
                min = i;
                for (j = i + 1; j < len; j++)
                {
                    if (intArray[j]< intArray[min]) 
                        min = j;
                }
                temp = intArray[min];
                intArray[min] = intArray[i];
                intArray[i] = temp;
            }
        }

        static void InsertSort(int[] intArray)
        {
            for (int i = 1; i < intArray.Length; i++)
            {
                int temp = intArray[i];
                for (int j = i - 1; j >= 0; j--)
                {
                    if (intArray[j] > temp)
                    {
                        intArray[j + 1] = intArray[j];
                        intArray[j] = temp;
                    }
                    else
                        break;
                }
            }
        }

        static void ShellSort(int[] intArray)
        {
            int length = intArray.Length;
            for (int h = length / 2; h > 0; h = h / 2)
            {
                for (int i = h; i < length; i++)
                {
                    int temp = intArray[i];
                    if (temp.CompareTo(intArray[i - h]) < 0)
                    {
                        for (int j = 0; j < i; j += h)
                        {
                            if (temp.CompareTo(intArray[j]) < 0)
                            {
                                temp = intArray[j];
                                intArray[j] = intArray[i];
                                intArray[i] = temp;
                            }
                        }
                    }
                }
            }
        }

    }
}


using System;

namespace Test_11_PolesUP
{
    class Program
    {
        static int[] SortAscending(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        static void Main(string[] args)
        {
            int[] arr = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3 };
            arr = SortAscending(arr);
            for(int i = 0; i<arr.Length;i++)
            {
                Console.Write(arr[i]+",");
            }
        }
    }
}

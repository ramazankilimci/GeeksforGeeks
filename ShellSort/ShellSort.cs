using System;
using System.Collections.Generic;
using System.Text;

namespace ShellSort
{
    class ShellSort
    {
        //Prints any arrays
        public void PrintArray(int[] arr)
        {

            int n = arr.Length;
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " \n");
            Console.ReadLine();
        }

        //Sorting array items starting from arr[0]
        //Always compares all next array items. For n-th item, it will always compare arr[n+1], arr[n+2], arr[n+3]
        // If arr[n] > arr[n+1], order of items will be switched
        public int Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return 0;
        }
    }
}

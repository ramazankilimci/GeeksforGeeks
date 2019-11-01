using System;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 5, 2, 10 };

            ShellSort ob = new ShellSort();
            ob.Sort(arr);
            ob.PrintArray(arr);

            Console.WriteLine("Hello World!");
        }
    }
}

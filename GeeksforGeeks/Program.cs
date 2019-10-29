using System;
using System.Text.RegularExpressions;

namespace GeeksforGeeks
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double retryMax = Math.Pow(10, 5);
            int num = 0;
            for (int retryCount = 1; retryCount <= retryMax; retryCount++)
            {
                if (retryCount < retryMax)
                {
                    //Console.Write("Enter you string : ");
                    string str = Console.ReadLine();
                    string[] numbers = Regex.Split(str, @"\D+");
                    
                    if (str.Length < 100)
                    {
                        foreach (string value in numbers)
                        {
                            if (!string.IsNullOrEmpty(value))
                            {
                                int i = int.Parse(value);
                                num = num + i;

                            }
                        }
                        Console.WriteLine("Sum of numbers in string is : " + num);

                    }
                    else
                    {
                        Console.WriteLine("String length is more than expected!");
                    }
                }
                else
                {
                    Console.WriteLine("You've reached the retry count");
                }

            }




        }
    }
}

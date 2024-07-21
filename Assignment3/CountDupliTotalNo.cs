using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class CountDupliTotalNo
    {
        static void Main()
        {
            int[] arr = { 11, 22, 44, 33, 44, 88, 11 };

            for (int i = 0; i < arr.Length; i++)
            {
                int count = 1;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                        arr[j] = -1;
                    }
                }

                if (arr[i] != -1)
                {
                    Console.WriteLine($"{arr[i]} is repeated {count} times");
                }
            }
        }
    }
}

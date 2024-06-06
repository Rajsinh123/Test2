using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateNumberFind
{
    using System;

    class Program
    {
        public static void Main()
        {
            // Initialize array   
            int[] arr = new int[] { 1, 2, 3, 4, 2, 7, 8, 8, 3 };

            Console.WriteLine("Duplicate elements in the given array: ");

            // Searches for duplicate elements  
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                        Console.WriteLine(arr[j]);
                    Console.ReadLine();
                }
            }
        }
    }

}

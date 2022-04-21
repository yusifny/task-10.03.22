using System;

namespace ConsoleApp32
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 285, -44, 131, -117, -58, 265, 97, -105};
            int i = 0;

            for (i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    arr[i] = -arr[i];
            }

            Console.Write("Array Elements(modulus): ");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

using System;

namespace mehods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "BabeK";
            string reverse = "";
            int length = str.Length - 1;

            while (length >= 0)
            {
                reverse += str[length];
                length--;
            }

            Console.WriteLine(reverse);
        }
    }
}
using System;
namespace Practical_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(ReverseString("Hello"));
        }

        static string ReverseString(string str)
        {
            string reverseStr = "";
            for (int i = str.Length-1; i >=0; i--)
            {
                reverseStr=reverseStr + str[i];
            }
            return reverseStr;
        }
    }
}
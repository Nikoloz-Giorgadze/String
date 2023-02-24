using static System.Net.Mime.MediaTypeNames;

namespace Practical_3
{
    class Program
    {
        static void Main()
        {

            Console.WriteLine("Enter string: ");
            string str = Console.ReadLine();
            Console.WriteLine(Func(str));
        }

        static string Func(string str)
        {
            string spacedStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                spacedStr = spacedStr + str[i] + " ";
            }
            return spacedStr;
        }
    }
}
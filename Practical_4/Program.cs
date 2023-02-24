namespace Practical_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(FindWordAmount("Hello world"));
        }

        static int FindWordAmount(string str)
        {
            int amount = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    amount++;
                }
            }
            return amount;
        }
    }
}
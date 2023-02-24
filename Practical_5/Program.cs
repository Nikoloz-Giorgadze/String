using System;

namespace Practical_5
{
    class Program
    {
        static void Main()
        {
            string str = "Hello 1";
            ReturnAll(ReturnNumberAmount(str), ReturnLetterAmount(str), str);


        }

        static int ReturnNumberAmount(string str)
        {
            int numberAmount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 0 && str[i] <= 9)
                {
                    numberAmount++;
                }
            }
            return numberAmount;
        }
        static int ReturnLetterAmount(string str)
        {
            int letterAmount = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] <= 'Z')
                {
                    letterAmount++;
                }
            }
            return letterAmount;
        }


        static void ReturnAll(int numberAmount, int letterAmount, string str)
        {
            int other = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] <= 'Z')
                {
                    continue;
                }
                else if (str[i] >= 0 && str[i] <= 9)
                {
                    continue;
                }
                else
                {
                    other++;
                }
            }

            Console.WriteLine($"The number of letters are {letterAmount}, the number of numbers is {numberAmount}, the number of others {other} ");

        }
    }
}
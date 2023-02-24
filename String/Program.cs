namespace Practical_1
{
    class Program
    {
        static void Main()
        {
            Letters();
        }
        static void Letters()
        {
            string str;
            int vowel = 0;
            int conconant = 0;
            string vowels = "";
            string conconants = "";
            Console.Write("Enter word: ");
            str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u')
                {
                    vowels = vowels + str[i];
                    vowels = vowels + " ";
                    vowel++;
                }
                else if (str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    vowels = vowels + str[i];
                    vowels = vowels + " ";
                    vowel++;
                }
                else
                {
                    conconants = conconants += str[i];
                    conconants = conconants + " ";
                    conconant++;
                }

            }
            Console.WriteLine($"vowels count: {vowel} vowels: {vowels}");
            Console.WriteLine($"Conconants count: {conconant} conconants: {conconants}");

        }

    }
}
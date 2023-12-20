namespace Task_3_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] vowels = { 'a', 'e', 'o', 'i', 'u' };

            Console.WriteLine("Enter a string ");
            string userInp = Console.ReadLine().ToLower();

            char[] charArray = new char[userInp.Length];

            for (int i = 0; i < userInp.Length; i++)
            {
                charArray[i] = userInp[i];
            }


            void checkVowel(char[] letters)
            {
                bool hasVowel = false;
                for (int i = 0; i < letters.Length; i++)
                {
                    for (int j = 0; j < vowels.Length; j++)
                    {
                        if (letters[i] == vowels[j])
                        {
                            hasVowel = true;
                            break;
                        }
                    }
                }
                if (!hasVowel)
                {
                    throw new Exception("NO VOWELS FOUND");
                }
                else
                {
                    Console.WriteLine("Scuccess");
                }
            }


            try
            {
                checkVowel(charArray);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.ReadLine();

        }
    }
}

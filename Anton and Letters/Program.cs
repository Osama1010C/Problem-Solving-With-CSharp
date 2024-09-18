namespace Anton_and_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            line = line[1..^1];
            line = RemoveSpacesAndSemiColon(line);
            char[] letters = GetArrayOfEnglishLetters();
            bool[] flags = GetArrayOfBools();

            int count = 0;
            for (int i = 0; i < line.Length; i++)
            {
                int index = Array.IndexOf(letters, line[i]);
                if (!flags[index])
                {
                    count++;
                    flags[index] = true;
                }
            }
            Console.WriteLine(count);

        }

        static string RemoveSpacesAndSemiColon(string s)
        {
            string result = "";
            foreach (char c in s) if (!c.Equals(' ') && !c.Equals(',')) result += c;
            return result;
        }
        static char[] GetArrayOfEnglishLetters()
        {
            char[] result = new char[26];
            int index = 0;
            for (int i = 97; i <= 122; i++)
                result[index++] = (char)i;         
            return result;
        }
        static bool[] GetArrayOfBools()
        {
            bool[] result = new bool[26];
            for (int i = 0; i < 26; i++)
                result[i] = false;        
            return result;
        }
    }
}

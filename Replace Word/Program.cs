namespace Replace_Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(Replace(s));
        }
        public static string Replace(string s)
        {   
            string result = "";
            for (int i = 0; i< s.Length; i++)
            {
                if(i < s.Length - 4)
                {
                    if (s[i] == 'E' && s[i + 1] == 'G' && s[i + 2] == 'Y' && s[i + 3] == 'P' && s[i + 4] == 'T')
                    {
                        result += " ";
                        i += 4;
                    }
                    else result += s[i];
                }
                else result += s[i];
            }

            return result;
        }
    }
}

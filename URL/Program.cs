namespace URL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            GetParameters(s);
        }
        public static void GetParameters(string s)
        {
            int index = IndexOfChar(s, '?');
            for(int i = index + 1; i < s.Length; i++)
            {
                if (s[i] == '=') Console.Write(": ");
                else if (s[i] == '&') Console.Write("\n");
                else Console.Write(s[i]);
            }
        }
        public static int IndexOfChar(string s, char c)
        {
            for(int i = 0; i <= s.Length; i++)
            {
                if (s[i] == c) return i;
            }
            return -1;
        }
    }
}

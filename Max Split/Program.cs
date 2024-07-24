namespace Max_Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int slize = 1;
            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == 'R' && s[i + 1] == 'L') slize++;
            }
            Console.WriteLine(slize);

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (s[i] == 'R' && s[i + 1] == 'L')
                {
                    Console.Write(s[i]);
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(s[i]);
                }
            }
            Console.Write(s[s.Length - 1]);
        }
    }
}

namespace Games
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] lines = new string[n];
            for (int i = 0; i < lines.Length; i++) lines[i] = Console.ReadLine();
            int count = 0;
            for (int i = 0; i<lines.Length; i++)
            {
                for(int j= 0;  j < lines.Length; j++)
                {
                    string[] s1 = lines[i].Split(' ');
                    string[] s2 = lines[j].Split(' ');
                    if (lines[i] == lines[j]) continue;
                    if (s1[0] == s2[1]) count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

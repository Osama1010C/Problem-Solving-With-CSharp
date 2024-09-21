namespace Amusing_Joke
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string s3 = Console.ReadLine();
            if (s1.Length + s2.Length != s3.Length)
            {
                Console.WriteLine("NO");
                return;
            }
            List<char> list = new List<char>();
            for(int i = 0; i < s1.Length; i++) list.Add(s1[i]);
            for(int i = 0; i < s2.Length; i++) list.Add(s2[i]);
            bool flag = true;
            for (int i = 0; i < s3.Length; i++)
            {
                if (list.Contains(s3[i])) list.Remove(s3[i]);
                else flag = false;
            }
            Console.WriteLine((list.Count == 0) &&(flag)  ? "YES" : "NO");
        }
    }
}

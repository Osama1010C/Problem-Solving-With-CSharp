namespace Translation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine(Process(a, b) == true ? "YES" : "NO");
            
        }

        static bool Process(string a, string b)
        {
            if (a.Length != b.Length)  return false;
            for (int i = 0, j = a.Length-1; i < a.Length; i++, j--)
            {
                if (a[i] != b[j]) return false;
            }
            return true;
        }
    }
}

namespace YES_or_YES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            while(t-- > 0)
            {
                string line = Console.ReadLine().ToLower();
                Console.WriteLine(line == "yes" ? "YES" : "NO");
            }
        }
    }
}

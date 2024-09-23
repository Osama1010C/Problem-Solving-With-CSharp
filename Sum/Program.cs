namespace Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            while(t-- > 0)
            {
                string[] line = Console.ReadLine().Split(' ');
                int a = Convert.ToInt32(line[0]), b = Convert.ToInt32(line[1]), c = Convert.ToInt32(line[2]);
                Console.WriteLine((a + b == c) || (a + c == b) || (b + c == a) ? "YES":"NO");
            }
        }
    }
}

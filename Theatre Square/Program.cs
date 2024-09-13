namespace Theatre_Square
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] results = line.Split(' ');
            long n = int.Parse(results[0]);
            long m = int.Parse(results[1]);
            long a = int.Parse(results[2]);
            long x = m/a, y = n/a;
            if (m % a != 0) x++;
            if (n % a != 0) y++;
            Console.WriteLine(x*y);
        }
    }
}

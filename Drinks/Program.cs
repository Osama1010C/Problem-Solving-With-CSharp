namespace Drinks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string line = Console.ReadLine();
            string[] results = line.Split(' ');
            double sum = 0;
            foreach (string s in results)
            {
                int num = int.Parse(s);
                sum += num;
            }
            Console.WriteLine(sum/n);
        }
    }
}

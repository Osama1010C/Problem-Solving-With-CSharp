namespace Buy_a_Shovel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int k = int.Parse(line[0]);
            int r = int.Parse(line[1]);
            int shovels = 0;
            int totalPrice = 0;
            while (true)
            {
                shovels++;
                totalPrice = shovels * k;
                if ((totalPrice) % 10 == 0) break;
                if ((totalPrice - r) % 10 == 0) break;
            }
            Console.WriteLine(shovels);
        }
    }
}

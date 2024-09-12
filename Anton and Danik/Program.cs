namespace Anton_and_Danik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int anton = 0, danik = 0;
            foreach (char c in s)
            {
                if (c == 'A') anton++;
                else danik++;
            }
            Console.WriteLine(anton == danik ? "Friendship" : anton > danik ? "Anton" : "Danik");
        }
    }
}

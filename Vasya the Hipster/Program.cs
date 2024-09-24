namespace Vasya_the_Hipster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);

            int NumOfDaysWithDifferentSocks = a < b ? a : b;
            int NumOfDaysWithSameSocks = a < b ? (b-a)/2 : (a-b)/2;
            Console.WriteLine($"{NumOfDaysWithDifferentSocks} {NumOfDaysWithSameSocks}");
        }
    }
}

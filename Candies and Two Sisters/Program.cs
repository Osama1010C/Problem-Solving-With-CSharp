namespace Candies_and_Two_Sisters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int testCases = Convert.ToInt32(Console.ReadLine());
            while(testCases-- > 0)
            {
                long number = Convert.ToInt32(Console.ReadLine());
                decimal equation = (number-1) / 2;
                decimal count = Math.Floor(equation);
                Console.WriteLine(count);
            }
        }
    }
}

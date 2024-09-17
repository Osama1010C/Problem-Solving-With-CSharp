namespace Divisibility_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            while(n-- > 0)
            {
                string input = Console.ReadLine();
                string[] results = input.Split(' ');
                long num1 = Convert.ToInt64(results[0]);
                long num2 = Convert.ToInt64(results[1]); 
                long moves = 0;
                if (num1 % num2 == 0) moves = 0;
                else
                {
                    long result = ((num1 / num2) + 1) * num2;
                    moves = result - num1;
                }
                
                Console.WriteLine(moves);
            }
        }
    }
}

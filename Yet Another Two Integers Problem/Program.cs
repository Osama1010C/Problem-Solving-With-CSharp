namespace Yet_Another_Two_Integers_Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            while(t-- > 0)
            {
                string[] line = Console.ReadLine().Split(' ');
                int num1 = int.Parse(line[0]);
                int num2 = int.Parse(line[1]);
                int result = Math.Abs(num1-num2);
                if (num1 == num2) { Console.WriteLine(0); continue; }
                else Console.WriteLine(NumberOfMoves(result));
            }
        }
        static int NumberOfMoves(int n)
        {
            if ((n + "").Length == 1 || n == 10) return 1;
            return n%10 == 0 ? (n/10) : (n / 10) + 1;
        }
    }
}

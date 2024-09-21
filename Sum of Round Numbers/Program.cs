using System.Diagnostics.CodeAnalysis;

namespace Sum_of_Round_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            while(t-- > 0)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                int tens = 1;
                int result;
                int count = 0;
                string strNum = num + "";
                foreach (char c in strNum) count += c == '0' ? 0 : 1;
                Console.WriteLine(count);
                while (num != 0)
                {
                    result = num % 10;
                    result *= tens;
                    tens *= 10;
                    num /= 10;
                    if (result == 0) continue;
                    Console.Write($"{result} ");
                }
                Console.WriteLine();
            }
        }
    }
}

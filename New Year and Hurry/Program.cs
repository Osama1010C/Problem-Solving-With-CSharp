using System.Xml.Schema;

namespace New_Year_and_Hurry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // total minutes is 240
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int k = int.Parse(line[1]);
            int solvedProblems = 0;
            int total = 0;
            for(int i = 1; i <= n; i++)
            {
                if (total + k > 240) break;
                total += 5 * i;
                solvedProblems+= total+k > 240 ? 0: 1;
            }
            Console.WriteLine(solvedProblems);
        }
    }
}

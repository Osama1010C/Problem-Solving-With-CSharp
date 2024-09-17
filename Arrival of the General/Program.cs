namespace Arrival_of_the_General
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string line = Console.ReadLine();
            string[] lineResult = line.Split(' ');
            List<int> result = ConvertToIntList(lineResult);

            int maxElement = result[0], minElement = result[0], pMax = 0, pMin = 0;

            for (int i = 1; i < n; i++)
            {
                if(result[i] > maxElement)
                {
                    maxElement = result[i];
                    pMax = i;
                }
                if (result[i] <= minElement)
                {
                    minElement = result[i];
                    pMin = i;
                }
            }

            int ans = (n - 1 - pMin) + (pMax - 0);
            if (pMax > pMin) ans--;

            Console.WriteLine(ans);

        }

        private static List<int> ConvertToIntList(string[] lineResult)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < lineResult.Length; i++)
            {
                int num = Convert.ToInt32(lineResult[i]);
                result.Add(num);
            }
            return result;
        }
    }
}

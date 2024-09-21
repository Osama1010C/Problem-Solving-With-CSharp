namespace The_New_Year_Meeting_Friends
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] result = Console.ReadLine().Split(' ');
            int x1 = int.Parse(result[0]);
            int x2 = int.Parse(result[1]);
            int x3 = int.Parse(result[2]);
            int[] arr = { x1, x2, x3 };
            int total = int.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                int eq = 0;
                
                for(int j = 0; j < 3; j++)
                {
                    if (j == i) continue;
                    eq = eq + (Math.Abs(arr[i] - arr[j]));
                }
                if (total > eq) total = eq;
            }
            Console.WriteLine(total);
        }
    }
}

namespace Remove_Smallest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            while(t-- > 0)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                string[] line = Console.ReadLine().Split(' ');
                int[] ints = ConvertToArrOfInt(line);
                Array.Sort(ints);
                bool flag = true;
                for (int i = 0; i < ints.Length-1; i++)
                {
                    if (Math.Abs(ints[i] - ints[i + 1]) <= 1) continue;
                    else { flag = false; break; }
                }
                Console.WriteLine(flag ? "YES" : "NO");
            }
        }

        static int[] ConvertToArrOfInt(string[] line)
        {
            int[] arr = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
                arr[i] = Convert.ToInt32(line[i]);
           return arr;
        }
        static int Max(int[] arr)
        {
            int max = arr[0];
            foreach(int i in arr)
                if (i > max) max = i;
            return max;
        }
        static int Min(int[] arr)
        {
            int min = arr[0];
            foreach (int i in arr)
                if (i < min) min = i;
            return min;
        }
    }
}

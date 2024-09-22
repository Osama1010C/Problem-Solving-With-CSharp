namespace Soft_Drinking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = ConvertToIntArray(Console.ReadLine().Split(' '));
            int n = arr[0], k = arr[1], l = arr[2], c = arr[3], d = arr[4], p = arr[5], nl = arr[6], np = arr[7];
            int eq1 = (k * l) / nl, eq2 = c * d, eq3 = p / np;
            int[] arrr = {eq1, eq2, eq3};
            int result = GetMin(arrr);
            Console.WriteLine(result/n);
        }
        private static int[] ConvertToIntArray(string[] result)
        {
            int[] arr = new int[result.Length];
            for (int i = 0; i < result.Length; i++)
                arr[i] = int.Parse(result[i]);
            return arr;
        }
        private static int GetMin(int[] arr)
        {
            int min = arr[0];
            foreach (int i in arr)
                min = min > i ? i : min;
            return min;
        }
    }
}

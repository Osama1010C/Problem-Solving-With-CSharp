namespace I_love__username_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = ConvertToIntArray(Console.ReadLine().Split(' '));
            int max = arr[0], min = arr[0];
            int performance = 0;
            for(int i = 1; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                    performance++;
                }
                if(arr[i] < min)
                {
                    min = arr[i];
                    performance++;
                }
            }
            Console.WriteLine(performance);
            
        }
        private static int[] ConvertToIntArray(string[] result)
        {
            int[] arr = new int[result.Length];
            for (int i = 0; i < result.Length; i++)
            {
                arr[i] = int.Parse(result[i]);
            }
            return arr;
        }
    }
}

namespace Police_Recruits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string line = Console.ReadLine();
            string[] result = line.Split(' ');
            int[] arr = ConvertToIntArray(result);
            int unTreatedCrimes = 0;
            int hired = 0;
            for(int i = 0;  i < arr.Length; i++)
            {
                if(arr[i] > 0) { hired += arr[i]; }
                else
                {
                    if(hired > 0) hired--;
                    else unTreatedCrimes++;
                }
            }
            Console.WriteLine(unTreatedCrimes);
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

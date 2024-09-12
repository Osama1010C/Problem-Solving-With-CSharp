namespace Vanya_and_Fence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputs = Console.ReadLine();
            string[] arrinputs = inputs.Split(' ');
            int n = Convert.ToInt32(arrinputs[0]);
            int h = Convert.ToInt32(arrinputs[1]);
            string s = Console.ReadLine();
            string[] results = s.Split(' ');
            int[] result = ConvertToArray(results, n);
            int sum = 0;
            foreach (int i in result)
            {
                if (i <= h) sum += 1;
                else sum += 2;
            }
            Console.WriteLine(sum);
            
        }

        static int[] ConvertToArray(string[] str , int n)
        {
            int[] result = new int[n];
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                result[i] = Convert.ToInt32(str[i]);
            }
            return result;
        }
    }
}

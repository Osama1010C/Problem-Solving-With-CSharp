namespace Tram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] str = new string[n];
            for(int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }
            int[] arr = ConvertToArray(str);
            int max = arr[1];


            for (int i = 0; i < arr.Length - 2; i += 2)
            {
                int tmp = Math.Abs((arr[i + 1] - arr[i + 2])) + (arr[i + 3]);
                if (tmp > max)
                    max = tmp;
                arr[i+3] = tmp;

            }

            Console.WriteLine(max);

        }

        static int[] ConvertToArray(string[] str)
        {
            int[] result = new int[str.Length*2];
            int count = 0;
            for(int i = 0;i < str.Length;i++)
            {
                string[] s = str[i].Split(' ');
                for(int j = 0; j < s.Length;j++)
                {
                    result[count++] = Convert.ToInt32(s[j]);
                }
            }
            return result;
        }
    }
}

namespace Presents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            int[] result = ConvertToArray(s.Split(' '), n);
            // 1 2 3 4
            // 2 3 4 1

            // 4 1 2 3
            int[] newArr = new int[n];
            int item = 1;
            for (int i = 0; i < result.Length; i++)
            {
                int index = result[i];
                newArr[index-1] = item++;
            }
            for (int i = 0;i < newArr.Length; i++)
            {
                if(i == newArr.Length-1) Console.Write(newArr[i]);
                else Console.Write(newArr[i] + " ");
            }
        }

        static int[] ConvertToArray(string[] str, int n)
        {
            int[] result = new int[n];
            for (int i = 0; i < str.Length; i++)
            {
                result[i] = Convert.ToInt32(str[i]);
            }
            return result;
        }
    }
}

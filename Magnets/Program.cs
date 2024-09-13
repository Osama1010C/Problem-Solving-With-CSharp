namespace Magnets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr = new string[n];
            for (int i = 0; i < arr.Length; i++) arr[i] = Console.ReadLine();

            string tmp = arr[0];
            int groups = 1;
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] != tmp) groups++;
                tmp = arr[i];
            }
            Console.WriteLine(groups);
        }
    }
}

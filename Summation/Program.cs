namespace Summation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Number Of Numbers: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++) arr[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sum = "+Sum(arr));
            
        }
        static int Sum(int[] arr)
        {
            int result = 0;
            foreach (int i in arr)
            {
                result += i;
            }
            return result;
        }
    }
}

namespace Restoring_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] line = Console.ReadLine().Split(' ');
            int x1 = int.Parse(line[0]);
            int x2 = int.Parse(line[1]);
            int x3 = int.Parse(line[2]);
            int x4 = int.Parse(line[3]);
            int[] x = { x1, x2, x3, x4 };
            int AblusBblusC = Max(x);
            for(int i = 0; i < 4; i++)
            {
                Console.Write(AblusBblusC - x[i] == 0 ? "": AblusBblusC - x[i] + " ");
            }
        }
        static int Max(int[] x)
        {
            int max = x[0];
            foreach (int i in x)
                if (i > max) max = i;
            return max;
        }
    }
}

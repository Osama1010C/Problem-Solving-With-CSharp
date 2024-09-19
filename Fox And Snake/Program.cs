namespace Fox_And_Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] result = line.Split(' ');
            int r = int.Parse(result[0]);
            int c = int.Parse(result[1]);
            int[,] s = new int[r, c];

            string shape1 = ""; // ###
            string shape2 = ""; // ..#
            string shape3 = ""; // #..
            for (int i = 0; i < c; i++) 
            {
                shape1 += "#";
                shape2 += i == c - 1 ? "#" : ".";
                shape3 += i == 0 ? "#" : ".";
            }

            string[] shapes = { shape1, shape2, shape1,  shape3 };
            int index = 0;
            for(int i = 0;i < r; i++)
            {
                Console.WriteLine(shapes[index++]);
                index = index == 4 ? 0 : index;
            }
        }
    }
}

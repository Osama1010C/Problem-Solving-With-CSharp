namespace George_and_Accommodation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfRooms = Convert.ToInt32(Console.ReadLine());
            string[] rooms = new string[numOfRooms];
            int count = 0;
            for (int i = 0; i < numOfRooms; i++)
            {
                rooms[i] = Console.ReadLine();
                string[] line = rooms[i].Split(' ');
                int p = int.Parse(line[0]);
                int q = int.Parse(line[1]);
                if (p + 2 <= q) count++;
            }
            Console.WriteLine(count);   
        }
    }
}

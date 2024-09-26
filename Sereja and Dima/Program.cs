namespace Sereja_and_Dima
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32 (Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            List<int> ints = ConvertToIntList(line);
            int serjaSum = 0, dimaSum = 0;
            bool switchTurn = true;
            while (ints.Count > 0)
            {
                int maxNumber = Max(ints[0], ints[ints.Count-1]);
                if (switchTurn)
                {
                    serjaSum += maxNumber;
                    switchTurn = false;
                }
                else
                {
                    dimaSum += maxNumber;
                    switchTurn = true;
                }
                ints.Remove(maxNumber);
            }

            Console.WriteLine($"{serjaSum} {dimaSum}");
        }

        static int Max(int n1, int n2) => n1 > n2 ? n1 : n2;
        
        static List<int> ConvertToIntList(string[] array)
        {
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                result[i] = Convert.ToInt32(array[i]);
            return result.ToList();
        }
    }
}

namespace Is_your_horseshoe_on_the_other_hoof
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] result = line.Split(' ');
            int count = 0;
            for(int i = 0; i < result.Length; i++)
            {
                bool isRepeated = false;
                for(int j = i+1; j<result.Length; j++)
                {
                    if (result[j] == result[i]) 
                    { 
                        isRepeated = true;
                        break;
                    }
                }
                if (isRepeated) count++;
            }
            Console.WriteLine(count);
        }
    }
}

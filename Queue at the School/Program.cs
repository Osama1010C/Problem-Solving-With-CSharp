namespace Queue_at_the_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputs = Console.ReadLine();
            string[] arrinputs = inputs.Split(' ');
            int n = Convert.ToInt32(arrinputs[0]);
            int second = Convert.ToInt32(arrinputs[1]);
            string s = Console.ReadLine();

            for(int i = 0; i < second; i++)
            {
                for(int j = 0; j < s.Length-1; j++)
                {
                    if (s[j] == 'B' && s[j+1] == 'G') { s = Swap(s, j, j + 1); j++; }
                }
            }
            Console.WriteLine(s);
        }
        static string Swap(string s, int firstIndex, int secondIndex)
        {
            char[] chars = s.ToCharArray();
            char tmp = chars[firstIndex];
            chars[firstIndex] = chars[secondIndex];
            chars[secondIndex] = tmp;
            return new string(chars);
        }
    }
}

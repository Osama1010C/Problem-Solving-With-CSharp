namespace Reverse_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            s = Reverse(s);
            Console.WriteLine(s);
        }
        private static string Reverse(string s)
        {
            string result = "";          
            
            for(int i = s.Length-1; i >=0; i--)
                result += s[i];
            string[] parts = result.Split(' ');
            result = "";
            for(int i = parts.Length-1; i >= 0; i--)
            {
                if(i != 0) result += parts[i]+" ";
                else result += parts[i];
            }
            return result;
        }
    }
}

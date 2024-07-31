namespace Palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(10));
        }
        public static bool IsPalindrome(int x)
        {
            string tmp = x + "";
            for(int i = 0; i < tmp.Length; i++)
            {
                if (tmp[i] != tmp[tmp.Length-1-i]) return false;
            }
            return true;
        }
    }
}

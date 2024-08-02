namespace Encrypt___Decrypt_Message
{
    internal class Program
    {
        const string KEY = "PgEfTYaWGHjDAmxQqFLRpCJBownyUKZXkbvzIdshurMilNSVOtec#@_!=.+-*/";
        const string ORIGINAL = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        const int LEN = 62;
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine());
            string s  = Console.ReadLine();
            Console.WriteLine(ProcessMessage(s,q));
        }
        public static string ProcessMessage(string s, int q)
        {
            string result = "";
            int index = 0;

            //encrypt
            if (q == 1)
            {
                for(int i = 0; i < s.Length; i++)
                {
                    index = IndexOfCharInOriginal(s[i]);
                    result += KEY[index];
                }
            }

            //decrypt
            // q = 2
            else
            {
                for (int i = 0; i < s.Length; i++)
                {
                    index = IndexOfCharInKey(s[i]);
                    result += ORIGINAL[index];
                }
            }

            return result;
        }

        public static int IndexOfCharInOriginal(char c)
        {
            for(int i = 0 ; i < LEN; i++)
            {
                if (ORIGINAL[i] == c) return i;
            }
            return -1;
        }
        public static int IndexOfCharInKey(char c)
        {
            for (int i = 0; i < LEN; i++)
            {
                if (KEY[i] == c) return i;
            }
            return -1;
        }
    }
}

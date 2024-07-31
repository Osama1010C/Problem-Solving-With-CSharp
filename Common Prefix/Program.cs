namespace Common_Prefix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LongestCommonPrefix(new string[] { "reflower", "flow", "flight" }));
            Console.WriteLine(LongestCommonPrefix(new string[] {  "a", "a", "b" }));
            

        }

        public static string LongestCommonPrefix(string[] strs)
        {
            string result = "";

            for(int i = 0; i < SmallestLength(strs); i++)
            {
                if (CommonIndexOfChar(strs, i))
                {
                    result += strs[0][i];
                }
                else break;
            }

            return result;
        }

        public static bool CommonIndexOfChar(string[] s, int index)
        {
            for(int i = 0; i < s.Length-1; i++)
            {
                if(s[i][index] != s[i + 1][index]) return false;
            }
            return true;
        }
        
        public static int SmallestLength(string[] strs)
        {
            int len = strs[0].Length;
            for(int i = 1; i <strs.Length; i++)
            {
                if(len > strs[i].Length) len = strs[i].Length;
            }
            return len;
        }   
        
    }
}

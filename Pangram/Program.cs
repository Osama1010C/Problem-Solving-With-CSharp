namespace Pangram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] chars = new char[26];
            int index = 0;
            for (int i = 97; i <= 122; i++)
            {
                chars[index] = (char)i;
                index++;
            }
            bool[] elementsExist = new bool[26];
            for (int i = 0; i < 26; i++) elementsExist[i] = false;

            int n = Convert.ToInt32(Console.ReadLine());
            string line = Console.ReadLine();
            line = line.ToLower();
            for(int i = 0; i < n; i++)
            {
                if (IsExist(line[i], chars))
                {
                    int theIndex = Array.IndexOf(chars, line[i]);
                    elementsExist[theIndex] = true;
                }
            }

            bool flag = true;
            foreach (bool i in elementsExist)
            {
                if (!i)
                {
                    flag = false; break;
                }
            }
            if (flag) Console.WriteLine("YES");
            else Console.WriteLine("NO");
        }

        static bool IsExist(char c, char[] arr)
        {
            foreach (char i in arr)
            {
                if (i == c) return true;
            }
            return false;
        }
    }
}

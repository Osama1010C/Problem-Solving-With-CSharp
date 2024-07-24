namespace String_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string s = Console.ReadLine();
            StringScore(s);

        }

        private static void StringScore(string s)
        {
            int score = 0;
            for(int i =0; i< s.Length; i++)
            {
                if (s[i] == 'V')
                {
                    score = V(score);
                }
                else if (s[i] == 'W')
                {
                    score = W(score);
                }
                else if (s[i] == 'X')
                {
                    s = X(s, i);
                }
                else if (s[i] == 'Y')
                {
                    s = Y(s, i);
                }
                else if (s[i] == 'Z')
                {
                    score = Zscore(s, i, score);
                    s = Zstring(s, i);
                }
                else continue;
            }
            Console.WriteLine(score);
        }
        static int V(int score)
        {
            return score + 5;
        }
        static int W(int score)
        {
            return score + 2;
        }
        static string X(string s, int index)
        {
            if (index == s.Length - 1) return s;
            
            string newString = null;
            int pos = index + 1;
            for(int i = 0; i < s.Length; i++)
            {
                if (i == pos) continue;
                else newString += s[i];
            }
            return newString;
        }
        static string Y(string s, int index)
        {
            if (index == s.Length - 1) return s;
            
            string newString = null;
            int pos = index + 1;
            
            newString = X(s, index);
            newString += s[index+1];
            return newString;
        }
        static int Zscore(string s, int index, int score)
        {
            int newScore = score;
            int pos = index + 1;
            if (s[pos] == 'V') newScore /= 5;
            else if (s[pos] == 'W') newScore /= 2;
            return newScore;
        }
        static string Zstring(string s, int index)
        {
            if (index == s.Length - 1) return s;
            else if (s[index+1] == 'V' ||  s[index+1] == 'W')
            {
                string newString = null;
                newString = X(s, index);
                return newString;
            }
            else
            {
                return s;
            }
            
        }
    }
}

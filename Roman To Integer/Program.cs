namespace Roman_To_Integer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RomanToInt("MCMXCIV"));
        }
        //I             1
        //V             5
        //X             10
        //L             50
        //C             100
        //D             500
        //M             1000
        public static int RomanToInt(string s)
        {
            const int I = 1;
            const int V = 5;
            const int X = 10;
            const int L = 50;
            const int C = 100;
            const int D = 500;
            const int M = 1000;
            int result = 0;
            //MCMXCIV
            s += "0";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'I')
                {
                    if (s[i+1] == 'V')
                    {
                        result += (V - I);i++;
                    }
                    else if(s[i+1] == 'X')
                    {
                        result += (X - I); i++;
                    }
                    else if (s[i+1] == 'L')
                    {
                        result += (L - I); i++;
                    }
                    else if (s[i + 1] == 'C')
                    {
                        result += (C - I); i++;
                    }
                    else if (s[i + 1] == 'D')
                    {
                        result += (D - I); i++;
                    }
                    else if (s[i + 1] == 'M')
                    {
                        result += (M - I); i++;
                    }
                    else
                    {
                        result += I;
                    }
                }
                
                else if(s[i] == 'V')
                {
                    if (s[i + 1] == 'X')
                    {
                        result += (X - V); i++;
                    }
                    else if (s[i+1] == 'L')
                    {
                        result += (L - V); i++;
                    }
                    else if (s[i+1] == 'C')
                    {
                        result += (C - V); i++;
                    }
                    else if (s[i+1] == 'D')
                    {
                        result += (D - V); i++;
                    }
                    else if (s[i+1] == 'M')
                    {
                        result += (M - V); i++;
                    }
                    else
                    {
                        result += V;
                    }
                }
                
                else if (s[i] == 'X')
                {
                    if (s[i + 1] == 'L')
                    {
                        result += (L - X); i++;
                    }
                    else if (s[i + 1] == 'C')
                    {
                        result += (C - X); i++;
                    }
                    else if (s[i + 1] == 'D')
                    {
                        result += (D - X); i++;
                    }
                    else if (s[i + 1] == 'M')
                    {
                        result += (M - X); i++;
                    }
                    else
                    {
                        result += X;
                    }
                }
                
                else if (s[i] == 'L')
                {
                    if (s[i + 1] == 'C')
                    {
                        result += (C - L); i++;
                    }
                    else if (s[i + 1] == 'D')
                    {
                        result += (D - L); i++;
                    }
                    else if (s[i + 1] == 'M')
                    {
                        result += (M - L); i++;
                    }
                    else
                    {
                        result += L;
                    }
                }
                
                else if (s[i] == 'C')
                {
                    if (s[i + 1] == 'D')
                    {
                        result += (D - C); i++;
                    }
                    else if (s[i + 1] == 'M')
                    {
                        result += (M-C); i++;
                    }
                    else
                    {
                        result += C;
                    }
                }
                
                else if (s[i] == 'D')
                {
                    if (s[i + 1] == 'M')
                    {
                        result += (M - D); i++;
                    }
                    else
                    {
                        result += D;
                    }
                }
                
                else if (s[i] == 'M')
                {
                    result += M;
                }
            }
            
            // 1000 + 900 + 90 + 4
            return result;
        }
    }
}

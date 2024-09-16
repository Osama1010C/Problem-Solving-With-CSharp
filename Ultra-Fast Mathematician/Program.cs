using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ultra_Fast_Mathematician_binary_easy_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bin1 = Console.ReadLine();
            string bin2 = Console.ReadLine();
            Console.WriteLine(SumBinarySimple(bin1, bin2));
            
        }


        // this is the right one but codeforces need simple one
        static string SumBinary(string firstBinary, string secondBinary)
        {
            char[] n1 = firstBinary.ToCharArray();
            char[] n2 = secondBinary.ToCharArray();
            string result = "";
            char tmp = '0';
            for(int i = firstBinary.Length -1; i >= 0; i--)
            {
                char firstTerm = '0', secondTerm = '0';
                if (n1[i] == '0') firstTerm = '0';
                else firstTerm = '1';
                if (n2[i] == '0') secondTerm = '0';
                else secondTerm = '1';

                if(firstTerm.Equals('0') && secondTerm.Equals('0') && tmp.Equals('0'))
                {
                    result = "0" + result;
                    tmp = '0';
                }
                else if (firstTerm.Equals('1') && secondTerm.Equals('1') && tmp.Equals('1'))
                {
                    result = "1" + result;
                    tmp = '1';
                }
                else if (firstTerm.Equals('1') && secondTerm.Equals('0') && tmp.Equals('0'))
                {
                    result = "1" + result;
                    tmp = '0';
                }
                else if (firstTerm.Equals('0') && secondTerm.Equals('1') && tmp.Equals('0'))
                {
                    result = "1" + result;
                    tmp = '0';
                }
                else if (firstTerm.Equals('0') && secondTerm.Equals('0') && tmp.Equals('1'))
                {
                    result = "1" + result;
                    tmp = '0';
                }
                else if (firstTerm.Equals('1') && secondTerm.Equals('1') && tmp.Equals('0'))
                {
                    result = "0" + result;
                    tmp = '1';
                }
                else if (firstTerm.Equals('1') && secondTerm.Equals('0') && tmp.Equals('1'))
                {
                    result = "0" + result;
                    tmp = '1';
                }
                else if (firstTerm.Equals('0') && secondTerm.Equals('1') && tmp.Equals('1'))
                {
                    result = "0" + result;
                    tmp = '1';
                }

            }
            if(tmp == '1') result = "1" + result;  
            return result;
        }

        static string SumBinarySimple(string firstBinary, string secondBinary)
        {
            char[] n1 = firstBinary.ToCharArray();
            char[] n2 = secondBinary.ToCharArray();
            string result = "";
            for (int i = firstBinary.Length - 1; i >= 0; i--)
            { 
                if (n1[i] == n2[i])
                    result = "0" + result;
                else
                    result = "1" + result;
            }
            return result;
        }
    }
}



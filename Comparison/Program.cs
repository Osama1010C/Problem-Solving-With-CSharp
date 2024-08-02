namespace Comparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(Process(s));

        }
        public static string Process(string s)
        {
            string s1 = "";
            string s2 = "";
            string result = "";
            
            // splitting s to s1,s2
            for(int i = 0; i < s.Length - 1; i++)
            {
                
            }


            return result;
        }
        //public static string Sort(string s)
        //{
        //    string result = "";
        //    char[] chars = s.ToCharArray();

        //    int[] intValues = new int[chars.Length];
        //    for(int i = 0; i < chars.Length; i++) intValues[i] = chars[i]; 

        //    for(int i = 0; i < intValues.Length; i++)
        //    {
        //        int tmp;
        //        for(int j = i+1; j < intValues.Length; j++)
        //        {
        //            if(intValues[i] > intValues[j])
        //            {
        //                tmp = intValues[i];
        //                intValues[i] = intValues[j];
        //                intValues[j] = tmp;
        //            }
        //        }
        //    }
        //    foreach (char c in intValues) result += c; 

        //    return result;
        //}
    }
}

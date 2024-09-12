namespace Beautiful_Year
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = Convert.ToInt32(Console.ReadLine());
            string? result = null;

            while (true)
            {
                year++;
                string strYear = year + "";
                if (IsUnique(strYear))
                {
                    result = strYear;
                    break;
                }
            }
            Console.WriteLine(result);
        }

        static bool IsUnique(string str)
        {
            for (int i = 0; i < str.Length-1; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j]) return false;
                }
            }
            return true;
        }
    }
}

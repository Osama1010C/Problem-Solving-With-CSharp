using System.ComponentModel;

namespace New_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            Console.WriteLine(HowMany(s));
        }
        public static int HowMany(string s)
        {
            s=s.ToLower();
            int result = 0;
            int[] recurrence = new int[5];

            for(int i = 0; i < s.Length; i++)
            {
                if (s[i] == 'e') recurrence[0]++;
                if (s[i] == 'g') recurrence[1]++;
                if (s[i] == 'y') recurrence[2]++;
                if (s[i] == 'p') recurrence[3]++;
                if (s[i] == 't') recurrence[4]++;

            }
            if (IsEquals(recurrence)) result = recurrence[0];
            else result = MinOfArray(recurrence);

            return result;
        }
        public static bool IsEquals(int[] array)
        {
            int first = array[0];
            for(int i = 1; i < array.Length; i++)
            {
                if(array[i] != first) return false;
            }
            return true;
        }

        public static int MinOfArray(int[] array)
        {
            int min = array[0];
            for(int i = 1;i < array.Length; i++)
            {
                if(min > array[i]) min = array[i];
            }
            return min;
        }
    }
}

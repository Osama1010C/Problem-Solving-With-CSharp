namespace Two_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] result = TwoSum(new int[] { 3, 2, 4 }, 6);
            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i+1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == target)
                    {
                        result[0] = i;
                        result[1] = j;
                        break;
                    }
                }
            }

            return result;
        }
    }
}

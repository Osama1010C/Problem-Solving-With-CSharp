namespace Remove_Duplicates_from_Sorted_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] a = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

            Console.WriteLine(RemoveDuplicates(a));
            foreach (int i in a) Console.Write(i+",");

        }
        public static int RemoveDuplicates(int[] nums)
        {
            int index = 0;
            int k = NumberOfDuplicates(nums);
            for (int i = 0; i < nums.Length; i++)
            {
                if (IsUnique(nums, nums[i], i))
                {
                    nums[index++] = nums[i];
                }
            }

            // Fill the rest of the array with 0 or another placeholder
            for (int i = index; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
            return k;
        }
        public static int NumberOfDuplicates(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (!IsUnique(nums, nums[i], i)) result++;
            }

            return nums.Length - result;
        }
        public static bool IsUnique(int[] nums, int k, int index)
        {
            for (int i = index + 1; i < nums.Length; i++)
            {
                if (nums[i] == k) return false;
            }
            return true;
        }


    }
}

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
            // i = 0, index = 0 |  -> 0 0 1 1 1 2 2 3 3 4
            // i = 1, index = 0 | nums[0] = nums[0] -> 0 0 1 1 1 2 2 3 3 4 || index++
            // i = 2, index = 1 |  -> 0 0 1 1 1 2 2 3 3 4
            // i = 3, index = 1 |  -> 0 0 1 1 1 2 2 3 3 4
            // i = 4, index = 1 | nums[1] = nums[4] -> 0 1 1 1 1 2 2 3 3 4 || index++
            // i = 5, index = 2 |  -> 0 1 1 1 1 2 2 3 3 4
            // i = 6, index = 2 | nums[2] = nums[6] -> 0 1 2 1 1 2 2 3 3 4 || index++
            // i = 7, index = 3 |  -> 0 1 2 1 1 2 2 3 3 4
            // i = 8, index = 3 | nums[3] = nums[8] -> 0 1 2 3 1 2 2 3 3 4 || index++
            // i = 9, index = 4 | nums[4] = nums[9] -> 0 1 2 3 4 2 2 3 3 4 || index++
            //index = 5

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

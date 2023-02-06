namespace RemoveElement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] test = { 0, 1, 2, 2, 3, 0, 4, 2 };
            int val = 2;

            int count = RemoveElement(test, val);
            Console.Write("First Left values: ");
            for(int i = 0; i < count; i++)
            {
                Console.Write(test[i] + ",");
            }

            Console.WriteLine("\nRemove duplicates in a sorted array");
            int[] test2 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            count = RemoveDuplicates(test2);
            for (int i = 0; i < count; i++)
            {
                Console.Write(test2[i] + ",");
            }
        }

        private static int RemoveDuplicates(int[] nums)
        {
            int last = 1;
            int length = nums.Length;
            for (int i = 1; i < length; i++)
            {
                if (nums[i] != nums[last-1])
                {
                    nums[last++] = nums[i];
                }
            }
            return last;
        }

        public static int RemoveElement(int[] nums, int val) 
        {
            int length = nums.Length;
            int last = 0;
            for(int i = 0; i < length; i++)
            {
                if (nums[i] != val)
                {
                    nums[last++] = nums[i];
                }
            }
            return last;
        }
    }
}
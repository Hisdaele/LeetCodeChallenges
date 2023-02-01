namespace MergedSortesArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };
            int m = 3;
            int[] nums2 = { 4, 5, 6 };
            int n = 3;
            Merge(nums1, m, nums2, n);
            foreach(int i in nums1)
            {
                Console.WriteLine(i);
            }
        }

        private static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int last1 = m - 1;
            int last2 = n - 1;
            int lastMerge = m + n - 1;

            while((last1 >= 0) && (last2 >= 0))
            {
                if (nums1[last1] > nums2[last2])
                {
                    nums1[lastMerge--] = nums1[last1--];
                }
                else
                {
                    nums1[lastMerge--] = nums2[last2--];
                }
            }

            while (last1 >= 0)
            {
                nums1[lastMerge--] = nums1[last1--];
            }

            while (last2 >= 0)
            {
                nums1[lastMerge--] = nums2[last2--];
            }
        }
    }
}
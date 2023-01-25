namespace SortedSquaredArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayTest1 = {-4, -1, 0, 3, 10};
            PrintArray(arrayTest1);
            int[] sortedArray = SortSquaredArray(arrayTest1);
            PrintArray(sortedArray);

        }

        private static int[] SortSquaredArray(int[] nums)
        {
            int[] result = new int[nums.Length];

            int head = 0;
            int tail = nums.Length - 1;
            for(int i = tail; i >= 0; i--)
            {
                if (Math.Abs(nums[head]) > Math.Abs(nums[tail]))
                {
                    result[i] = nums[head]* nums[head];
                    head++;
                }
                else
                {
                    result[i] = nums[tail]* nums[tail];
                    tail--;
                }
            }

            return result;
        }

        private static void PrintArray(int[] nums)
        {
            Console.Write("[");
            foreach(int val in nums)
            {
                Console.Write($"{val},");
            }
            Console.WriteLine("]");
        }   
    }
}
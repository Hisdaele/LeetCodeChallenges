namespace LeetCodeChallenges
{
    internal class Utils
    {
        private static void PrintArray(int[] nums)
        {
            Console.Write("[");
            foreach (int val in nums)
            {
                Console.Write($"{val},");
            }
            Console.WriteLine("]");
        }
    }
}

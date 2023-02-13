namespace Challenges
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Just try to make it");
        }

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
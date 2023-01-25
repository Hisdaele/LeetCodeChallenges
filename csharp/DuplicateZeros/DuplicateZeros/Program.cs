namespace DuplicateZeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 1,0,2,3,0,4,5,0 };
            //Console.WriteLine(CountExtraZeroes(testArray));
            DuplicateZeros(testArray);
            PrintArray(testArray);

        }

        public static void DuplicateZeros(int[] arr)
        {
            int extraZeroes = 0;
            int copyTo = arr.Length - 1;

            for (int i = 0; i <= arr.Length - extraZeroes - 1; i++)
            {
                if (arr[i] == 0)
                {
                    if(i == arr.Length - extraZeroes - 1)
                    {
                        arr[copyTo] = 0;
                        copyTo--;
                    }
                    extraZeroes++;
                }
            }

            int copyFrom = arr.Length - extraZeroes - 1;
            while (copyFrom < copyTo)
            {
                arr[copyTo] = arr[copyFrom];
                if (arr[copyFrom] == 0)
                {
                    arr[--copyTo] = 0;
                }
                copyFrom--;
                copyTo--;
            }
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
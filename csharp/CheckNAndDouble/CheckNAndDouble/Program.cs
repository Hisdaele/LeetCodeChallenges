namespace CheckNAndDouble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 2, 5, 3 };
            bool hasDouble = CheckIfExist(arr);
            Console.WriteLine(hasDouble);
        }

        private static bool CheckIfExist(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = i+1; j < arr.Length; j++)
                {
                    if(arr[i] == 2 * arr[j] || arr[j] == 2 * arr[i])
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
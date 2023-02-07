
namespace ValidMountainArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3,5,5};
            bool ans = CheckMountainArray(arr);
            Console.WriteLine(ans);
    }

        private static bool CheckMountainArray(int[] arr)
        {
            if(arr.Length < 3) { return false; }

            //Looking for top index
            int top = 0;
            for(; top < arr.Length - 1; top++) 
            {
                if (arr[top] > arr[top+1])
                {
                    break;
                }else if(arr[top] == arr[top + 1])
                {
                    return false;
                }
            }

            for (; top < arr.Length - 1; top++)
            {
                if (arr[top] <= arr[top + 1])
                {
                    return false;
                }
            }

            return true;


        }
    }
}
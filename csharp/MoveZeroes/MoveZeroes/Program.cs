namespace MoveZeroes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 0 };
            MoveZeroes(arr);
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }

        private static void MoveZeroes(int[] arr)
        {
            int writerPointer = 0;
            int length = arr.Length;

            //Move non null infront
            for(int i = 0; i < length; i++)
            {
                if (arr[i] != 0)
                {
                    arr[writerPointer++] = arr[i];
                }
            }

            //Complete the rest with zero
            while(writerPointer < length)
            {
                arr[writerPointer++] = 0;
            }
        }
    }
}
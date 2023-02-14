namespace LeetCodeChallenges
{
    
    internal class SortArrayByParity
    {
        public void Test()
        {
            int[] arr = { 0 , 1, 2};//{ 3, 1, 2, 4 };
            arr = Execute2(arr);
            Utils.PrintArray(arr);
        }

        /*
         * Given an integer array nums, move all the even integers at the beginning of the array followed by all the odd integers.
         * Return any array that satisfies this condition.
         */
        private int[] Execute(int[] arr)
        {
            int writerPointer = 0;
            int readerPointer = 0;
            int length = arr.Length;

            while(readerPointer < length)
            {
                if ((arr[readerPointer] % 2 == 0))
                {
                    (arr[writerPointer], arr[readerPointer]) = (arr[readerPointer], arr[writerPointer]);
                    writerPointer++;
                }

                readerPointer++;
            }

            return arr;
        }

        private int[] Execute2(int[] arr)
        {
            int start = 0, end = arr.Length - 1;

            while(start < end)
            {
                (int i, int j ) = (arr[start]%2, arr[end]%2);
                if(i > j)
                {
                    (arr[start], arr[end]) = (arr[end], arr[start]); 
                }

                if(i == 0) start++;
                if(j == 1) end--;
            }
            return arr;
        }
    }
}

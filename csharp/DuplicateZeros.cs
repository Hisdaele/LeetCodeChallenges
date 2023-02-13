class DuplicateZeros
{

    public static void Execute(int[] arr)
    {
        int extraZeroes = 0;
        int copyTo = arr.Length - 1;

        for (int i = 0; i <= arr.Length - extraZeroes - 1; i++)
        {
            if (arr[i] == 0)
            {
                if (i == arr.Length - extraZeroes - 1)
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
}
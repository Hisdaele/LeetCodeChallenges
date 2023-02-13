class ValidMountainArray
{
    public static bool Execute(int[] arr)
    {
        if (arr.Length < 3) { return false; }   

        //Looking for top index
        int top = 0;
        for (; top < arr.Length - 1; top++)
        {
            if (arr[top] > arr[top + 1])
            {
                break;
            }
            else if (arr[top] == arr[top + 1])
            {
                return false;
            }
        }

        if (top == 0 || top == arr.Length - 1) { return false; }

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
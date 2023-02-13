class ReplaceElements
{
    public static int[] Execute(int[] arr)
    {
        int size = arr.Length;
        int currentMax = -1;

        for (int i = size - 1; i >= 0; i--)
        {
            int tempo = arr[i];
            arr[i] = currentMax;
            if (tempo > currentMax)
            {
                currentMax = tempo;
            }
        }
        return arr;
    }
}
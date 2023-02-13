class RemoveElement
{
    public static int RemoveDuplicates(int[] nums)
    {
        int last = 1;
        int length = nums.Length;
        for (int i = 1; i < length; i++)
        {
            if (nums[i] != nums[last - 1])
            {
                nums[last++] = nums[i];
            }
        }
        return last;
    }

    public static int Execute(int[] nums, int val)
    {
        int length = nums.Length;
        int last = 0;
        for (int i = 0; i < length; i++)
        {
            if (nums[i] != val)
            {
                nums[last++] = nums[i];
            }
        }
        return last;
    }
}
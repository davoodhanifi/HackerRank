static int RemoveElement(int[] nums, int val)
{
    if (nums.Length == 0)
    {
        return 0;
    }

    var currentIndex = 0;
    for (var i = 0; i < nums.Length; i++)
    {
        if (nums[i] != val)
        {
            nums[currentIndex] = nums[i];
            currentIndex++;
        }
    }

    return currentIndex;
}
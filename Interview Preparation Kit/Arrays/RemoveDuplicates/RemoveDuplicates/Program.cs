static int RemoveDuplicates(int[] nums)
{
    if (nums.Length == 0)
    {
        return 0;
    }

    var currentIndex = 1;
    for (var i = 1; i < nums.Length; i++)
    {
        if (nums[i] != nums[i - 1])
        {
            nums[currentIndex] = nums[i];
            currentIndex++;
        }
    }

    return currentIndex;
}

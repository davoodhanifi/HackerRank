// See https://aka.ms/new-console-template for more information
static int[] TwoSum(int[] nums, int target)
{
    Dictionary<int, int> numDic = []; 
    for (int i = 0; i < nums.Length; i++)
    {
        var result = target - nums[i];

        if (numDic.TryGetValue(result, out int value))
        {
            return [i, value];
        }

        numDic[nums[i]] = i;
    }

    throw new ArgumentException($"Not match found for the given target {target}");
}
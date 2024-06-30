static IList<IList<int>> Subsets(int[] nums)
{
    IList<IList<int>> result = [[]];

    result[0] = [];
    foreach (int num in nums)
    {
        int currentCount = result.Count;
        for (int i = 0; i < currentCount; i++)
        {
            List<int> newSubset = new(result[i])
            {
                num
            };
            result.Add(newSubset);
        }
    }

    return result;
}

Subsets([0,1,2]);
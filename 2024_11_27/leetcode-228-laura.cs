public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        if (nums.Length == 0)
        {
            return new List<string>();
        }

        var firstNum = nums[0];
        var lastNum = nums[nums.Length - 1];
        List<string> rangeToDisplayTemp = new List<string>();
        List<string> rangeToDisplay = new List<string>();

        for (int i = firstNum; i <= lastNum; i++)
        {
            if (nums.Contains(i))
            {
                rangeToDisplayTemp.Add(i.ToString());
            }
            else
            {
                if(rangeToDisplayTemp.Any())
                {
                    rangeToDisplay.Add(MapListToRangeFormat(rangeToDisplayTemp));
                }
                rangeToDisplayTemp = new List<string>();
            }
        }

        if(rangeToDisplayTemp.Any())
        {
            rangeToDisplay.Add(MapListToRangeFormat(rangeToDisplayTemp));
        }

        return rangeToDisplay;
    }

        public string MapListToRangeFormat(List<string> nums) {
            if (nums.Count == 1)
            {
                return nums.First();
            }
            return nums.First() + "->" + nums.Last();
    }
}
public class Solution {
    public IList<string> SummaryRanges(int[] nums) {
        if(nums.Length == 0){
            return new List<string>();
        }
        var ret = new List<string>();
        int start = nums[0];
        int end   = nums[0];
        foreach(var n in nums){
            if(n == start){
                continue;
            }
            if(n - end != 1){
                if(start == end){
                    ret.Add(start.ToString());
                } else {
                    ret.Add(start.ToString() + "->" + end.ToString());
                }
                start = n;
            }
            end = n;
        }
        if(start == end){
            ret.Add(start.ToString());
        } else {
            ret.Add(start.ToString() + "->" + end.ToString());
        }
        return ret;
    }
}
from types import List

class Solution:
    def summaryRanges(self, nums: List[int]) -> List[str]:
        if len(nums) == 0:
            return []
        ret = []
        rs = nums[0]
        re = nums[0]
        for x in nums[1:]:
            if x - re != 1:
                ret.append(f'{rs}->{re}' if rs != re else f'{rs}')
                rs = x
            re = x
        ret.append(f'{rs}->{re}' if rs != re else f'{rs}')

        return ret
public class Solution {
    public int Rob(int[] nums) {
        if(nums.Length == 1) return nums[0];
        if(nums.Length == 2) return Math.Max(nums[0],nums[1]);
        int prev1 = nums[0];
        int prev2 = Math.Max(nums[1],nums[0]);
        int cur = 0;
        for(int i = 2; i<nums.Length;i++){
            cur = Math.Max(prev2, nums[i]+prev1);
            prev1=prev2;
            prev2 = cur;
        }

        return cur;
    }
}

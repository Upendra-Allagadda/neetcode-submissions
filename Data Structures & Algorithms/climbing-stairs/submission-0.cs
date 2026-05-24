public class Solution {
    public int ClimbStairs(int n) {
        if(n==1) return 1;
        if(n==2) return 2;
        int[] dp = new int[n];
        int prev1 = 1;
        int prev2 = 2;
        int cur = 0;
        for(int i =2; i<n;i++){
            cur = prev1+prev2;
            prev1=prev2;
            prev2 = cur;
        }
        return cur;
    }
}
public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hset = new HashSet<int>();
        foreach(int i in nums){
            if(!hset.Add(i)){
                return true;
            }            
        }
        return false;
    }
}

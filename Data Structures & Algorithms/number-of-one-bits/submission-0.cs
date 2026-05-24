public class Solution {
    public int HammingWeight(uint n) {
        int count = 0;
        while(n>0){
            uint i = n%2;
            if(i == 1) count++;
            n = n/2; 
        }
        return count;
    }
}

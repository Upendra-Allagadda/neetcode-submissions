public class Solution {
    public int[] CountBits(int n) {
        int[] arr = new int[n+1];
        arr[0] = 0;
        for(int i =1; i<=n; i++){
            arr[i] = CountIndividual(i);
        }
        return arr;
    }

    public int CountIndividual(int k){
        int count = 0;
        while(k!=0){
            k&=(k-1);
            count++;
        }
        return count;
    }
}

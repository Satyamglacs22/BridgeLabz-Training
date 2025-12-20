public class NumberMissing {
    public int MissingNumber(int[] nums) {
        int n= nums.Length;
        int totalSum= n*(n+1)/2;
        int sum=0;
        for(int i=0;i<n;i++){
            sum +=nums[i];
        }

        return totalSum-sum;

        
    }
}
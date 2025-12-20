using System.Collections.Generic;

public class DuplicatesFromSorted {
    public int RemoveDuplicates(int[] nums) {

        HashSet<int> set = new HashSet<int>();

        foreach (int num in nums) {
            set.Add(num);
        }

        int index = 0;
        foreach (int val in set) {
            nums[index++] = val;
        }

        return index;   // same as set.Count
    }
}

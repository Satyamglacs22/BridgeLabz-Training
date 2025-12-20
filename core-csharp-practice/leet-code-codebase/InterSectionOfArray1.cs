using System.Collections.Generic;

public class InterSectionOfArray1 {
    public int[] Intersection(int[] nums1, int[] nums2) {

        HashSet<int> set = new HashSet<int>();

        foreach (int num in nums1) {
            set.Add(num);
        }

        List<int> ls = new List<int>();

        foreach (int num in nums2) {
            if (set.Contains(num)) {
                ls.Add(num);
                set.Remove(num);   // important: avoid duplicates
            }
        }

        int p = ls.Count;
        int[] arr = new int[p];

        for (int i = 0; i < p; i++) {
            arr[i] = ls[i];
        }

        return arr;
    }
}

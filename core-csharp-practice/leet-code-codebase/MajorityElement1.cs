using System.Collections.Generic;
public class MajorityElement1 {
    public int MajorityElement(int[] nums) {
        int n= nums.Length;
        Dictionary<int,int>map= new Dictionary<int,int>();
        foreach(int num in nums){
            if(map.ContainsKey(num)){
                map[num]++;

            }
            else{
                map[num]=1;

            }

        }
        foreach(var e in map){
            if(e.Value >n/2){
                return e.Key;
            }
        }
        return 0;
        
    }
}
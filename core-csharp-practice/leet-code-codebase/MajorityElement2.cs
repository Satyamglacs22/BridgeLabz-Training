using System.Collections.Generic;
public class MajorityElent2 {
    public IList<int> MajorityElement(int[] nums) {
        int n= nums.Length;
        List<int>ls= new List<int>();
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
            if(e.Value >n/3){
                ls.Add(e.Key);
            }
        }
        return ls;
        
    }
}
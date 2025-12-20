using System.Collections.Generic;
public class AllDuplicatesFind {
    public IList<int> FindDuplicates(int[] nums) {
        // int n= nums.length;
        List<int>ls = new List<int>();
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
            if(e.Value>1){
                ls.Add(e.Key);
            }
        }
        return ls;
    }
}
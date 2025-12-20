using System.Collections.Generic;
public class DuplicateFind {
    public bool ContainsDuplicate(int[] nums) {
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
                return true;

            }
        }
        return false;

        
    }
}
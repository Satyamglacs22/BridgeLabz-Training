// using System.Collections.Generic;
public class ValidAnagram {
    public bool IsAnagram(string s, string t) {
        if(s.Length!=t.Length){
            return false;
        }
       char[] a= s.ToCharArray();
       char[] b= t.ToCharArray();
       Array.Sort(a);
       Array.Sort(b);

       return new String(a).Equals(new String(b));

        
    }
}
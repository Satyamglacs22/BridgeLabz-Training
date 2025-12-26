using System.Collections.Generic;

public class FirstUniqueCharacter {
    public int FirstUniqChar(string s) {

        Dictionary<char, int> map = new Dictionary<char, int>();

        // frequency count
        foreach (char c in s) {
            map[c] = map.GetValueOrDefault(c, 0) + 1;
        }

        // first unique character index
        for (int i = 0; i < s.Length; i++) {
            if (map[s[i]] == 1) {
                return i;
            }
        }

        return -1;
    }
}

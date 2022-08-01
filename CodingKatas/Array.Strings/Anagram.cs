using System.Collections.Generic;

namespace CodingKatas.Array.Strings
{
    public class Anagram
    {
        public bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length)
                return false;
            var dictionary = new Dictionary<char, int>();
            for (var i = 0; i < s.Length; i++)
            {
                if (!dictionary.TryAdd(s[i], 1))
                {
                    dictionary[s[i]] += 1;
                }
                if (!dictionary.TryAdd(t[i], -1))
                {
                    dictionary[t[i]] -= 1;
                }
            }

            foreach (var value in dictionary.Values)
            {
                if (value != 0)
                    return false;
            }
            
            
                
    
            
            return true;
        }
    }
}


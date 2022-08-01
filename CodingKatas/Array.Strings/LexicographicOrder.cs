using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CodingKatas.Array.Strings
{
    public class LexicographicOrder
    {
        public bool IsAlienSorted(string[] words, string order)
        {
            return IsAlienSorted(0, words, order);
        }
    
      
        public bool IsAlienSorted(int index, string[] words, string order)
        {
            var dictionary = new Dictionary<char, List<string>>();
            var previousIndex = -1;
            
            for (var i = 0; i < words.Length; i++)
            {
                var word = words[i];
                
                if (index >= word.Length)
                {
                    if (i > 0 && words[i - 1].Length > word.Length)
                        return false;

                    continue;
                }

                var l = word[index];
                var ixd = order.IndexOf(l);
                if (previousIndex > ixd)
                    return false;
                previousIndex = ixd;
                if (dictionary.TryGetValue(l, out var list))
                {
                    list.Add(word);
                }
                else
                {
                    dictionary.Add(l,new List<string>(new string[]{word}));
                }
            }

            if (dictionary.Count == words.Length)
                return true;
            foreach (var dict in dictionary)
            {
                if(dict.Value.Count > 1 && !IsAlienSorted(index + 1, dict.Value.ToArray(), order))
                    return false;
            }
            return true;
        }

        
    }
}


/*
 * In an alien language, surprisingly, they also use English lowercase letters, but possibly in a different order. The order of the alphabet is some permutation of lowercase letters.

Given a sequence of words written in the alien language, and the order of the alphabet, return true if and only if the given words are sorted lexicographically in this alien language.

 

Example 1:

Input: words = ["hello","leetcode"], order = "hlabcdefgijkmnopqrstuvwxyz"
Output: true
Explanation: As 'h' comes before 'l' in this language, then the sequence is sorted.
Example 2:

Input: words = ["word","world","row"], order = "worldabcefghijkmnpqstuvxyz"
Output: false
Explanation: As 'd' comes after 'l' in this language, then words[0] > words[1], hence the sequence is unsorted.
Example 3:

Input: words = ["apple","app"], order = "abcdefghijklmnopqrstuvwxyz"
Output: false
Explanation: The first three characters "app" match, and the second string is shorter (in size.) According to lexicographical rules "apple" > "app", because 'l' > '∅', where '∅' is defined as the blank character which is less than any other character (More info).
 

Constraints:

1 <= words.length <= 100
1 <= words[i].length <= 20
order.length == 26
All characters in words[i] and order are English lowercase letters.
 */
 
 
/*
     public bool IsAlienSorted(string[] words, string order)
     {       
         var word1 =  IsAlienSortedB(words[0], order);
         for(var i=1;i<words.Length;i++)
         {
             var word2 = IsAlienSortedB(words[i],order);
             var j = 0;
             while (word1.Length > j)
             {
                 if (word1[j] < word2[j])
                     break;
                 if (word1[j] > word2[j])
                     return false;
                 j++;
                 if (j == word2.Length && word2.Length < word1.Length)
                    return false;
             }
             
             word1 = word2;
         }

         return true;
     }

     public int[] IsAlienSortedB(string word, string order)
     {
         var indexes = new int[word.Length];
         var i = 0;
         foreach (var letter in word)
         {
             indexes[i] = order.IndexOf(letter);
             i++;
         }

         return indexes;
     }
*/
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CodingKatas.Array.Strings
{
    public class Palindrome
    {
        public IList<IList<int>> PalindromePairs(string[] words) {
            IList<IList<int>> list = new List<IList<int>>();
            var dict = new Dictionary<string, int>();
        
            for(var i = 0; i < words.Length; i++){
                var sb = new StringBuilder();
                for(var j = words[i].Length - 1; j >= 0; j--){
                    sb.Append(words[i][j]);
                }
                dict.Add(sb.ToString(), i);
            }
        
            for(var i = 0; i < words.Length; i++){
                var str = words[i];
                for(var j = 0; j < str.Length; j++){
                    var sub1 = str.Substring(j);
                    var sub2 = str.Substring(0, j);
                    if(IsPalindrome(sub1) && dict.ContainsKey(sub2) && dict[sub2] != i){
                        list.Add(new List<int>{i, dict[sub2]});
                        if(sub2 == ""){
                            list.Add(new List<int>{dict[sub2], i});
                        }
                    }
                    if(IsPalindrome(sub2) && dict.ContainsKey(sub1) && dict[sub1] != i){
                        list.Add(new List<int>{dict[sub1], i});
                    }
                
                }
            }
        
            return list;
        }
    
        private bool IsPalindrome(string str){
            for(var i = 0; i < str.Length / 2; ++i){
                if(str[i] != str[str.Length - 1 - i]){
                    return false;
                }
            }
            return true;
        }

    }
}


/*
 *
 *
 *
 *          var startDic = new Dictionary<char, List<int>>();
            var endDic = new Dictionary<char, List<int>>();
            var emptyIndexes = new List<int>();
            var i = 0;
            var simpleScan = false;
            var result = new List<IList<int>>();
            foreach (var word in words)
            {
                if (string.IsNullOrEmpty(word))
                {
                    emptyIndexes.Add(i);
                    simpleScan = true;
                }
                else{
                    AddToDictionary(startDic, word[0], i);
                    AddToDictionary(endDic, word[word.Length - 1], i);
                }

                if (endDic.TryGetValue(word[0], out var end))
                {
                    if (startDic.TryGetValue(word[0], out var items))
                    {


                        foreach (var x in items)
                        {
                            foreach (var y in end)
                            {
                                if (y == x) continue;
                                if (isPalindrome($"{words[x]}{words[y]}"))
                                {
                                    result.Add(new List<int>(new int[] { x, y }));
                                }
                            }
                        }
                    }
                }
                i++;
            }

            if (simpleScan)
            {
                i = 0;
                foreach (var word in words)
                {
                    if (isPalindrome(word))
                    {
                        foreach (var y in emptyIndexes)
                        {
                            result.Add(new List<int>(new int[] { i, y }));
                            result.Add(new List<int>(new int[] { y, i }));
                        }
                       
                    }

                    i++;
                }
            }

            return result;
 *
 * 
 */
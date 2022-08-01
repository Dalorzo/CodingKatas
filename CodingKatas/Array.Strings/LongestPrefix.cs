using System.Security.Cryptography;

namespace CodingKatas.Array.Strings
{
    public class LongestPrefix
    {
        public string LongestCommonPrefix(string[] strs)
        {
            var pasEncore = true;
            var i = 0;
            while (pasEncore)
            {
                if ( strs[0].Length <= i)
                {
                    i++;
                    pasEncore = false;
                    continue;
                }
                var letter = strs[0][i];
                foreach (var word in strs)
                {
                    if (word.Length <= i || !pasEncore)
                    {
                        pasEncore = false;
                        break;
                    }
                    pasEncore = word[i] == letter;
                }
                i++;
            }

            if (i == 1)
                return "";
            return strs[0].Substring(0,i-1);
        }
    }
}
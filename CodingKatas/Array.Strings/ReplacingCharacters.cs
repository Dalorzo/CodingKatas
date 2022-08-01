using System;
using System.Collections.Generic;

namespace CodingKatas.Array.Strings
{
    public class ReplacingCharacters
    {
        public  string WordParser(string input) {
            // IMPLEMENT YOUR SOLUTION HERE
            var result = GetNewPhrase(input);
            return result;
        }
        private  string GetNewPhrase(string input){
            var dictionary = new HashSet<string>();
            var from  =0;
            var to =0;
            var value = "";
            foreach (var letter in input)
            {
                value += letter;
                if (!char.IsLetter(letter) || char.IsPunctuation(letter))
                {
                    var word = input.Substring(from, to - from);
                    if (!string.IsNullOrEmpty(word))
                    {
                        value = value.Replace(word, TransformOneWord(word));
                    }
                    from = to + 1;
                }
                to++;
            }

            if (from < input.Length)
            {
                var word = input.Substring(from, to - from);
                value = value.Replace(word, TransformOneWord(word));
            }

            return value;
        }
        private  string TransformOneWord(string input){
            var length = input.Length;
            if (string.IsNullOrEmpty(input))
                return "";
            if (length < 3)
                return input;
           
            var firstLetter = input[0];
            var lastLetter = input[length-1];
    
            var list = new HashSet<char>();
            for(var i=1;length-1 > i; i++){
                var letter = input[i];
                list.Add(letter);
            }
            return $"{firstLetter}{list.Count}{lastLetter}";
        }
       
    }
}
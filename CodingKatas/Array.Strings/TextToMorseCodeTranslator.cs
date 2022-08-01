using System.Collections.Generic;

namespace CodingKatas.Array.Strings
{
    public class TextToMorseCodeTranslator
    {
        public int UniqueMorseRepresentations(string[] words)
        {
            var morseCode = new Dictionary<char, string>();
        
            morseCode.Add('a',".-");
            morseCode.Add('b',"-...");
            morseCode.Add('c',"-.-.");
            morseCode.Add( 'd',"-..");
            morseCode.Add( 'e',".");
            morseCode.Add( 'f',"..-.");
            morseCode.Add( 'g',"--.");
            morseCode.Add( 'h',"....");
            morseCode.Add( 'i',"..");
            morseCode.Add( 'j',".---");
            morseCode.Add( 'k',"-.-");
            morseCode.Add( 'l',".-..");
            morseCode.Add( 'm',"--");
            morseCode.Add( 'n',"-.");
            morseCode.Add( 'o',"---");
            morseCode.Add( 'p',".--.");
            morseCode.Add( 'q',"--.-");
            morseCode.Add( 'r',".-.");
            morseCode.Add( 's',"...");
            morseCode.Add( 't',"-");
            morseCode.Add( 'u',"..-");
            morseCode.Add( 'v',"...-");
            morseCode.Add( 'w',".--");
            morseCode.Add( 'x',"-..-");
            morseCode.Add( 'y',"-.--");
            morseCode.Add( 'z',"--..");
            var transformations = new HashSet<string>();
            foreach (var word in words)
            {
                var morseWord = "";
                foreach (var letter in word)
                {
                    morseWord += morseCode[letter];
                }
                transformations.Add(morseWord);
            }

            return transformations.Count;
        }
    }
}


/*
 *
 * International Morse Code defines a standard encoding where each letter is mapped to a series of dots and dashes, as follows:

'a' maps to ".-",
'b' maps to "-...",
'c' maps to "-.-.", and so on.
For convenience, the full table for the 26 letters of the English alphabet is given below:

[".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."]
Given an array of strings words where each word can be written as a concatenation of the Morse code of each letter.

For example, "cab" can be written as "-.-..--...", which is the concatenation of "-.-.", ".-", and "-...". We will call such a concatenation the transformation of a word.
Return the number of different transformations among all words we have.

 

Example 1:

Input: words = ["gin","zen","gig","msg"]
Output: 2
Explanation: The transformation of each word is:
"gin" -> "--...-."
"zen" -> "--...-."
"gig" -> "--...--."
"msg" -> "--...--."
There are 2 different transformations: "--...-." and "--...--.".
Example 2:

Input: words = ["a"]
Output: 1
 

Constraints:

1 <= words.length <= 100
1 <= words[i].length <= 12
words[i] consists of lowercase English letters.
 */
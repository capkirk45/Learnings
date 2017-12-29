using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class StringPuzzles
    {
        public static string FindFirstRepeatingCharacterUsingHashLookup(string s)
        {
            //ex:  ABCEBD

            var hash = new Hashtable();

            for (int i = 0; i <= s.Length - 1; i++)
            {
                var stringchar = s.Substring(i, 1);
                if (hash.ContainsKey(stringchar))
                {
                    return stringchar;
                }
                hash.Add(stringchar, 1);
            }
            return null; //no matches found
        }

        public static string CapitalizeTitle(string s)
        {
            //example:          i'm going to correctly cAPiTALizE these words
            //manual fix:       I'm Going to Correctly Capitalize These Words

            /* rules
             1. Capitalize first word
             2. Capitalize last word
             3. lower case following words unless they are first or last:
               "a"
               "the"
               "to"
               "at"
               "in"
               "with"
               "and"
               "but"
               "or"
            */

            /* steps
                1. Break up words into array
                2. Find first word and capitalize
                3. Find last word and capitalize
                4. For each word in array starting with second word and ending next to last:
                5. If NOT in list of lowercase, capitalize first letter and lower case remaining lettes
                6. Combine array of words back into a sentense
            */

            if (string.IsNullOrEmpty(s)) return string.Empty; //always null check and handle
            s = s.ToLower(); //set the whole thing to lower

            var words = s.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                if (i == 0 || i == words.Length || !ExceptionWords(words[i]).Contains(words[i]))
                    words[i] = UpperCaseWord(words[i]);
            }
            return string.Join(" ", words);
        }

        static List<string> ExceptionWords(string word)
        {
            var list = new List<string>() { "a", "the", "to", "at", "in", "with", "and", "but", "or" };
            return list;
        }
        static string LowerCaseWord(string word)
        {
            return word.ToLower();
        }

        static string UpperCaseWord(string word)
        {
            word = LowerCaseWord(word);
            return char.ToUpper(word[0]) + word.Substring(1);
        }
    }
}

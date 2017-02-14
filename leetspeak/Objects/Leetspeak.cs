using System.Collections.Generic;

namespace LeetSpeakTranslator.Objects
{
    public class LeetSpeak
    {
        public static Dictionary<char, string> cipher = new Dictionary<char, string>()
        {
            {'E', "3"},
            {'e', "3"},
            {'O', "0"},
            {'o', "0"},
            {'I', "1"}
        };
        private string _input;

        public LeetSpeak(string phrase)
        {
            SetPhrase(phrase);
        }

        public string GetPhrase()
        {
            return _input;
        }

        public void SetPhrase(string phrase)
        {
            _input = phrase;
        }

        public string Translate(string phrase)
        {
            char[] holder = phrase.ToCharArray();
            string output = "";

            for(var i=0;i<holder.Length;i++)
            {
                if(holder[i].ToString() == "s" && i == 0)
                {
                    output += holder[i];
                }
                else if((holder[i].ToString() == "s") && !(holder[i-1].ToString() == " "))
                {
                    output += "z";
                }
                else if(cipher.ContainsKey(holder[i]))
                {
                    output += cipher[holder[i]];
                }
                else
                {
                    output += holder[i].ToString();
                }
            }
            return output;
        }
    }
}

//another bad draft of translate, OG
// public string Translate(string phrase)
// {
//     string holder = phrase;
//
//     foreach (KeyValuePair<string, string> x in cipher)
//     {
//         holder = holder.Replace(x.Key, x.Value);
//     }
//     return holder;
// }

//old filter method
//     for(var i=0; i<phrase.ToCharArray().Length; i++)
//     {
//         char[] holder = phrase.ToCharArray();
//
//         if(holder[i].ToString() = "s" && holder[i-1].ToString() != " ")
//         {
//             holder[i] = "z";
//         }
//         else if(cipher.ContainsKey(holder[i]))
//         {
//             holder[i] = cipher[holder[i]];
//         }
//     }
// }

using System.Collections.Generic;

namespace LeetSpeakTranslator.Objects
{
    public class LeetSpeak
    {
        public static Dictionary<string, string> cipher = new Dictionary<string, string>()
        {
            {"E", "3"},
            {"e", "3"},
            {"O", "0"},
            {"o", "0"},
            {"I", "1"},
            {"s", "z"}
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
            foreach(char c in cipher.Keys)
            {
                var pattern = "\b" + c + "\b";
                
            }
        }
    }
}

using System.Collections.Generic;

namespace PingPongModule.Objects
{
    public class PingPong
    {
        private int _countTo;
        private List<string> outputs = new List<string> {};

        public PingPong(int count)
        {
            _countTo = count;
        }

        public int GetCountTo(){
            return _countTo;
        }

        public void SetCountTo(int count)
        {
            _countTo = count;
        }

        public string PingPongFilter(int number)
        {
            string newString;
            if(number % 15 == 0)
            {
                newString = "PingPong";
            }
            else if(number % 5 == 0)
            {
                newString = "Pong";
            }
            else if(number % 3 == 0)
            {
                newString = "Ping";
            }
            else
            {
                newString = number.ToString();
            }
            return newString;
        }
    }
}

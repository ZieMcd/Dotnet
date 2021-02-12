using System;

namespace BasicEvetntExample
{
    public class EventArgsClass : EventArgs
    {
        public EventArgsClass(string str)
        {           

            msg = str; 
        }

        private string msg;
        public string Message
        {
            get {return msg; }
        }
    }
}
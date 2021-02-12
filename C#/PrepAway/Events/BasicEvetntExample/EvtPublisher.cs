using System;

namespace BasicEvetntExample
{
    public class EvtPublisher
    {
        //public delegate void del(string x);
        //public event del evt;
        public EventHandler<EventArgsClass> evt;
        public void CheckBalance(int x)
        {
            if (x > 250)
            {
                EventArgsClass eac = new EventArgsClass("Balance above 250");
                evt(this,eac); // rasing event
            }
        }
    }
}
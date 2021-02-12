using System;

namespace BasicEvetntExample
{
    public class EvtSubscriber
    {
        public void HandleTheEvent(object sender, EventArgsClass e)
        {
            System.Console.WriteLine("Attention from "+ sender + " "+e.Message);
        }
    }
}
using System;

namespace BasicEvetntExample
{
    class Program
    {
        static void Main(string[] args)
        {
            EvtPublisher ep = new EvtPublisher();

            EvtSubscriber es = new EvtSubscriber();

            ep.evt += es.HandleTheEvent;

            ep.CheckBalance(260);
        }
    }
}

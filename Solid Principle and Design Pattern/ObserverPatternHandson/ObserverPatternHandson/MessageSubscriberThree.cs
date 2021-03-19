using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternHandson
{
    public class MessageSubscriberThree: Observer

    {
    public void update(Message m)
    {

       Console.WriteLine("MessageSubscriberThree :: " + m.getMessageContent());

    }

}
}

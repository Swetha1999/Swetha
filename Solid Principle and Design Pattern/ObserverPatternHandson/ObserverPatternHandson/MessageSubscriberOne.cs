using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternHandson
{
    public class MessageSubscriberOne: Observer

    {
       
       public void update(Message m)
    {
       Console.WriteLine("MessageSubscriberOne :: " + m.getMessageContent());

    }

}
}

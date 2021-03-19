using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternHandson
{
    public class MessageSubscriberTwo: Observer

    {

     public void update(Message m)
     {

        Console.WriteLine("MessageSubscriberTwo :: " + m.getMessageContent());

     }

}
}

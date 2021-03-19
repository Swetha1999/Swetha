using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternHandson
{
    public class Message

    {

         String messageContent;

        public Message(String m)
        { 
            this.messageContent = m; 
        }
        public String getMessageContent() 
        {
            return messageContent;
        }
    }
}

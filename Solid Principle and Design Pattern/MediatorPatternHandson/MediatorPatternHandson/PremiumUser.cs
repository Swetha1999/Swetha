using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatternHandson
{
    public class PremiumUser:IUser
    {
        
        string name;
        private IChatMediator chatMediator;
        public PremiumUser(IChatMediator chatMediator,string name)
        {
            this.chatMediator = chatMediator;
            this.name = name;
        }
        public void  SendMessage(string msg)
        {
            Console.WriteLine(this.name + ": Sending Message" + msg + "\n");
            chatMediator.SendMessage(msg, this);
        }
        public void ReceiveMessage(string msg)
        {
            Console.WriteLine(this.name + ": Received Message:" + msg);
        }
    }
}

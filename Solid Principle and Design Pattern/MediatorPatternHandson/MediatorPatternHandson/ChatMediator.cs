using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatternHandson
{
    public class ChatMediator:IChatMediator
    {
        public List<IUser> users = new List<IUser>();

        
        public ChatMediator()
        {
            
        }
        public void AddUser(IUser user)
        {
            users.Add(user);
        }
        public void SendMessage(string msg,IUser user)
        {
            foreach(var u in users)
            {
                if(u != user)
                {
                    u.ReceiveMessage(msg);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatternHandson
{
    public interface IChatMediator
    {
        public void AddUser(IUser user );
        public void  SendMessage(string msg,IUser user);
    }
}

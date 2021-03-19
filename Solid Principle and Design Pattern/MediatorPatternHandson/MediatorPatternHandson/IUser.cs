using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPatternHandson
{
    public interface IUser
    {
        public void SendMessage(string msg);
        public void ReceiveMessage(string msg);
    }
}

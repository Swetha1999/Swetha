using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilitiesHandson
{
    public class HR:ILeaveRequestHandlercs
    {
        private ILeaveRequestHandlercs nextHandler;
        public ILeaveRequestHandlercs NextHandler
        {
            get
            {
                return nextHandler;
            }
            set
            {
                nextHandler = value;
            }
        }
        public void HandleRequest(int leave)
        {
            if (leave >5)
            {
                Console.WriteLine("Leave Request is Approved by HR");
            }
           
        }
    }
}

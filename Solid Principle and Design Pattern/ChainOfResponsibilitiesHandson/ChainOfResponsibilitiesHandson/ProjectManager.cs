using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilitiesHandson
{
    public class ProjectManager:ILeaveRequestHandlercs
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
            if (leave >= 3 && leave <= 5)
            {
                Console.WriteLine("Leave Request is Approved by Project Manager");
            }
            else
            {
                Console.WriteLine("Leave Request is passed to HR");
                HR h = new HR();
                nextHandler = h;
                nextHandler.HandleRequest(leave);
            }
        }
    }
}

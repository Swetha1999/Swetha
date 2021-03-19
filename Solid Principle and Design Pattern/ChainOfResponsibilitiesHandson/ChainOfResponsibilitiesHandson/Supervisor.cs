using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilitiesHandson
{
    public class Supervisor:ILeaveRequestHandlercs
    {
        private ILeaveRequestHandlercs nextHandler;
        public  ILeaveRequestHandlercs NextHandler {
            get
            {
                return nextHandler;
            }
            set {
                nextHandler = value;
            }
        }
        public void HandleRequest(int leave)
        {
            if(leave>=1 && leave <3)
            {
                Console.WriteLine("Leave Request is Approved by Supervisor");
            }
            else
            {
                Console.WriteLine("Leave Request is passed to Project Manager");
                ProjectManager p = new ProjectManager();
                nextHandler = p;
                nextHandler.HandleRequest(leave);
            }
        }

        
    }
}

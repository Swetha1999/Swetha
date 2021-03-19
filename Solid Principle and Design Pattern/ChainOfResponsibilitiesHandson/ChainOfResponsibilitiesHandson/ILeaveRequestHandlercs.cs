using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilitiesHandson
{
   public  interface ILeaveRequestHandlercs
    {
        public ILeaveRequestHandlercs NextHandler { get; set; }

        public void HandleRequest(int leave);
    }
}

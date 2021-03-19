using System;

namespace ChainOfResponsibilitiesHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            string EmployeeName = "Swetha";
            int leave = 6;
            ILeaveRequestHandlercs request= new Supervisor();
            request.HandleRequest(leave);
            Console.ReadLine();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    class Supervisor : ILeaveRequestHandler
    {
        private ILeaveRequestHandler nextHandler;
        public ILeaveRequestHandler NextHandler { get { return nextHandler; } set { nextHandler = value; } }
        public void HandleRequest(LeaveRequest obj)
        {
            if (obj.LeaveDays < 3 && obj.LeaveDays>1)
                Console.WriteLine("Leave approved by SuperVisor");
            else
            {
                Console.WriteLine("Leave request rejected by Supervisor and  passed to ProjectManager\n");

                NextHandler = new ProjectManager();
                NextHandler.HandleRequest(obj);

            }
        }
    }
}

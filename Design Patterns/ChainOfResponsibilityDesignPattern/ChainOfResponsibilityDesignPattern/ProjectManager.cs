using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    class ProjectManager : ILeaveRequestHandler
    {
        private ILeaveRequestHandler nextHandler;
        public ILeaveRequestHandler NextHandler { get { return nextHandler; } set { nextHandler = value; } }
        public void HandleRequest(LeaveRequest obj)
        {
            if (obj.LeaveDays < 5 && obj.LeaveDays>3)
                Console.WriteLine("Leave approved by ProjectManager");
            else
            {
                Console.WriteLine("Leave request rejected by ProjectManager and  passed to HR\n");
                NextHandler = new HR();
                NextHandler.HandleRequest(obj);

            }
        }
    }
}

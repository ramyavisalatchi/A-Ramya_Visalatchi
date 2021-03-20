using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    class HR : ILeaveRequestHandler
    {
        private ILeaveRequestHandler nextHandler;
        public ILeaveRequestHandler NextHandler { get { return nextHandler; } set { nextHandler = value; } }
        public void HandleRequest(LeaveRequest obj)
        {
            if (obj.LeaveDays > 5)
            {
                Console.WriteLine("Leaves approved by HR");
            }
            else
            {
                Console.WriteLine("Leaves rejected by HR\n");

            }
        }
    }
}

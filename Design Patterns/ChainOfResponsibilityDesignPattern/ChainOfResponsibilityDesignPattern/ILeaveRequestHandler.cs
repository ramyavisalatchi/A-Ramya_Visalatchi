using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityDesignPattern
{
    interface ILeaveRequestHandler
    {
        ILeaveRequestHandler NextHandler { get; set; }

        void HandleRequest(LeaveRequest obj);
    }
}

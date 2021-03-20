using System;

namespace ChainOfResponsibilityDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            LeaveRequest obj1 = new LeaveRequest() { Employee = "Ramya",LeaveDays = 10 };
            LeaveRequest obj2 = new LeaveRequest() { Employee = "Ramya", LeaveDays = 4};
            ILeaveRequestHandler leave = new Supervisor();
            leave.HandleRequest(obj1);
            //leave.HandleRequest(obj2);

            Console.ReadLine();
        }
    }
}

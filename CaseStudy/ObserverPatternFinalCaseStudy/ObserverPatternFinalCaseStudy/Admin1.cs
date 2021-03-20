using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternFinalCaseStudy
{
    public class Admin1:INotificationObserver
    {
        public string Name = "Admin 1";
        public string name { get { return this.Name; } set { this.name = value; } }

        public int TicketCount;
        public int ticket { get { return this.TicketCount; } set { this.TicketCount = value; } }

        public void Notify()
        {
            
                Console.WriteLine("\nNOTIFICATION ! \nMore than 100 is Booked");
            
        }
    }
}

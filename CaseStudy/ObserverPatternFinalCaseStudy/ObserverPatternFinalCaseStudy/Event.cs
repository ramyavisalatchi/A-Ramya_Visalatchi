using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternFinalCaseStudy
{
    public class Event
    {
        
        string eventName;


        public Event(string eventName)
        {
            
            this.eventName = eventName;
            Console.WriteLine(this.eventName);
        }
    }
}

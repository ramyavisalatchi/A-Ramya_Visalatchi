using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternCaseStudy
{
    class SteveObserver : INotificationObserver
    {
        public string Name="Steve";
        public string name { get { return this.Name; } set { this.name = value; } }

        public void OnServerDown()
        {
            Console.WriteLine("NOTIFICATION ! \n"+name + " server is down");
        }
    }
}

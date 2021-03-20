using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternCaseStudy
{
    public interface INotificationObserver
    {
        string name { get; set; }
        void OnServerDown();
    }
}

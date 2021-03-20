using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternFinalCaseStudy
{
    public interface INotificationObserver
    {
        string name { get; set; }
        int ticket { get; set; }
        void Notify();
    }
}

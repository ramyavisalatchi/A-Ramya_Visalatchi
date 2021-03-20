using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternFinalCaseStudy
{
    public interface INotificationService
    {
        void AddSubscriber(INotificationObserver notificationObserver);
        void RemoveSubscriber(INotificationObserver notificationObserver);
        void NotifySubscriber();

    }
}

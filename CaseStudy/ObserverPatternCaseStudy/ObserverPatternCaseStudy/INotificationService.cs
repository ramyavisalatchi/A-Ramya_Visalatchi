using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternCaseStudy
{
    public interface INotificationService
    {
        void AddSubscriber(INotificationObserver notificationObserver);
        void RemoveSubscriber(INotificationObserver notificationObserver);
        void NotifySubscriber();

    }
}

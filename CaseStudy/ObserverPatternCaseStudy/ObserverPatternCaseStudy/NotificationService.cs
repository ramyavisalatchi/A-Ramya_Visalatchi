using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternCaseStudy
{
    public class NotificationService : INotificationService
    {
        List<INotificationObserver> observers = new List<INotificationObserver>();
        public void AddSubscriber(INotificationObserver notificationObserver)
        {
            observers.Add(notificationObserver);
            Console.WriteLine(notificationObserver.name+ " is being added");
            Console.WriteLine("SUBSCRIBER LIST");
            foreach (var obj in observers)
            {
                Console.WriteLine(obj.name);
            }
        }

        public void NotifySubscriber()
        {
            foreach (var obj in observers)
            {
                obj.OnServerDown();
            }

        }

        public void RemoveSubscriber(INotificationObserver notificationObserver)
        {
            observers.Remove(notificationObserver);
            Console.WriteLine(notificationObserver.name + " is being removed");
            Console.WriteLine("SUBSCRIBER LIST");
            foreach (var obj in observers)
            {
                Console.WriteLine(obj.name);
            }
        }
    }
}

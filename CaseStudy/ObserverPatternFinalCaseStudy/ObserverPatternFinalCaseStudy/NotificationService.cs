using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternFinalCaseStudy
{
    public class NotificationService : INotificationService
    {
        List<INotificationObserver> observers = new List<INotificationObserver>();
        public void EventList()
        {
         List<Event> events = new List<Event>()
        {
            new Event("c#"),
            new Event("Java")
        };
    }     
        public void AddSubscriber(INotificationObserver notificationObserver)
        {
            observers.Add(notificationObserver);
            Console.WriteLine("\n"+notificationObserver.name + " is being added");
            Console.WriteLine("SUBSCRIBER LIST\n***************");
            foreach (var obj in observers)
            {
                Console.WriteLine(obj.name);
            }
        }
        
        public void NotifySubscriber()
        {
            foreach (var obj in observers)
            {
                obj.Notify();
            }

        }

        public void RemoveSubscriber(INotificationObserver notificationObserver)
        {
            observers.Remove(notificationObserver);
            Console.WriteLine("\n"+notificationObserver.name + " is being removed");
            Console.WriteLine("SUBSCRIBER LIST");
            foreach (var obj in observers)
            {
                Console.WriteLine(obj.name);
            }
        }
    }
    }

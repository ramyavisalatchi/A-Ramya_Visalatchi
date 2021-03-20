using System;

namespace ObserverPatternCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            JohnObserver john = new JohnObserver();
            SteveObserver steve = new SteveObserver();

            NotificationService service = new NotificationService();
            service.AddSubscriber(john);
            service.AddSubscriber(steve);
            service.NotifySubscriber();
            service.RemoveSubscriber(john);
            Console.Read();
        }
    }
}

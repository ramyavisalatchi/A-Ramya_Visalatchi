using System;

namespace ObserverPatternFinalCaseStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin1 admin1 = new Admin1();
            Admin2 admin2 = new Admin2();

            NotificationService service = new NotificationService();


            Console.WriteLine("List Of Events\n");
            service.EventList();
            

            Console.WriteLine("Enter the number of tickets need to be booked");
            int ip = Convert.ToInt32(Console.ReadLine());

            admin1.ticket = ip;
            service.AddSubscriber(admin1);
            if (admin1.ticket > 100)
            {
                service.NotifySubscriber();
            }

            service.AddSubscriber(admin2);
            if (admin1.ticket > 100)
            {
                service.NotifySubscriber();
            }
            service.RemoveSubscriber(admin2);

            Console.Read();
        }
    }
}

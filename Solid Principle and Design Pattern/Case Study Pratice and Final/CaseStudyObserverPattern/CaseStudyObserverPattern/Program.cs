using System;

namespace CaseStudyObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            JohnObserver john = new JohnObserver("John");
            SteveObserver steve = new SteveObserver("Steve");
            NotificationService notificationService = new NotificationService();
            notificationService.AddSubscribe(john);

            notificationService.AddSubscribe(steve);
            notificationService.NotifySubscribe();
            notificationService.RemoveSubscribe(john);
            Console.WriteLine("----After Removing a user----");
            notificationService.NotifySubscribe();
            Console.ReadLine();
        }
    }
}

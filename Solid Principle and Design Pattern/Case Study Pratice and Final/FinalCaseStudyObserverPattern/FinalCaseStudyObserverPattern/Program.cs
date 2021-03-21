using System;

namespace FinalCaseStudyObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of tickets booked");
            int t;
            t= Convert.ToInt32(Console.ReadLine());
            Admin1Observer admin1 = new Admin1Observer("Admin1",t);
            Admin2Observer admin2 = new Admin2Observer("Admin2",t);
            NotificationService notificationService = new NotificationService();
            notificationService.AddSubscribe(admin1);

            notificationService.AddSubscribe(admin2);
            notificationService.NotifySubscribe();
            notificationService.RemoveSubscribe(admin2);
            Console.WriteLine("----After Removing admin----");
            notificationService.NotifySubscribe();
            Console.ReadLine();
        }
    }
}

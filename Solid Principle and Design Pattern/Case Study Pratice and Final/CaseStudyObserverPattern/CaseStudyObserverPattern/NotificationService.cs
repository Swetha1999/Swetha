using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyObserverPattern
{
    public class NotificationService:INotificationServer
    {

        private List<INotificationObserver> subscriber = new List<INotificationObserver>();
        public void AddSubscribe(INotificationObserver notificationObserver)
        {
            subscriber.Add(notificationObserver);
        }
        public void RemoveSubscribe(INotificationObserver notificationObserver)
        {
            subscriber.Remove(notificationObserver);
        }
        public void NotifySubscribe()
        {
            foreach(INotificationObserver sub in subscriber)
            {
                sub.OnServerDown();
            }
        }
    }
}

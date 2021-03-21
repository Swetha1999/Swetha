using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyObserverPattern
{
   public  interface INotificationServer
    {
        public void AddSubscribe(INotificationObserver notificationObserver);
        public void RemoveSubscribe(INotificationObserver notificationObserver);
        public void NotifySubscribe();
    }
}

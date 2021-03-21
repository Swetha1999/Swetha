using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCaseStudyObserverPattern
{
    public interface INotificationObserver
    {
        public string Name { get; set; }
        public void OnServerDown();
    }
}

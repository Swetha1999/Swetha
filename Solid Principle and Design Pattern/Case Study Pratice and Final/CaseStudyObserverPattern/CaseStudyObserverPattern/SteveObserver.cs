using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyObserverPattern
{
    public class SteveObserver : INotificationObserver
    {
        private string names;

        public string Name { get => names; set => value = names; }
        public SteveObserver(string name)
        {
            this.names = name;
        }

        public void OnServerDown()
        {
            Console.WriteLine(names + " has received a message");
        }
    }
}

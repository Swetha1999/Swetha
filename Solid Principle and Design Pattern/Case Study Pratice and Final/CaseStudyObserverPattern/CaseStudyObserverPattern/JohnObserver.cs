﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CaseStudyObserverPattern
{
    public class JohnObserver:INotificationObserver
    {

        private string names;
        public string Name { get => names; set => value=names;}
        public JohnObserver(string name)
        {
            this.names = name;
        }

        public void OnServerDown()
        {
            Console.WriteLine(names + " has received a message");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FinalCaseStudyObserverPattern
{
    public class Admin1Observer : INotificationObserver
    {

        private string names;
        public int tickets;
        public string Name { get => names; set => value = names; }
        public Admin1Observer(string name,int ticket)
        {
            this.names = name;
            this.tickets = ticket;
        }

        public void OnServerDown()
        {
            if (tickets > 100)
            {
                Console.WriteLine(names + ":\n Received a notification regarding Cultural Event list \n Most Populat Event:\n 1.Tennis\n 2.Badminton");
            }
            else
            {
                Console.WriteLine(names+":\n No Specific Events to display");
            }
        }
    }
}

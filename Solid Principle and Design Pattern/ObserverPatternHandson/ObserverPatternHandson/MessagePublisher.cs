using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternHandson
{
    public class MessagePublisher: Subject
    {
        private int getState = 1;
        public int GetState { get => getState; set => value = getState; }

        private List<Observer> observers = new List<Observer>();


    public void attach(Observer o)
    {

        observers.Add(o);

    }

    public void detach(Observer o) {
            observers.Remove(o); 
        }
    public void notifyUpdate(Message m) {
            foreach (Observer o in  observers) { 
                o.update(m);
            } 
        }
        public void ChangeState(int value)
        {
            if (value != getState)
            {

                GetState = value;

                notifyUpdate(new Message("Subject State has been changed"));
            }
        }
}
}

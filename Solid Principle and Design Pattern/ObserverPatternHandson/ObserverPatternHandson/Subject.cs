using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPatternHandson
{
    public interface Subject

    {
        int GetState { get; set; }
        public void ChangeState(int value);
        public void attach(Observer o);

        public void detach(Observer o);

        public void notifyUpdate(Message m);

    }
}

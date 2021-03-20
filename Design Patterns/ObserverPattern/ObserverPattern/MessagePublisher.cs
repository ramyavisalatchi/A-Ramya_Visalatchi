using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class MessagePublisher : Subject
    {
        private List<Observer> observers = new List<Observer>();
        private int getState = 1;
        public int GetState { get => getState; set => value = getState; }

        public void Attach(Observer o)
        {
            observers.Add(o);
        }
        public void ChangeState(int val)
        {
            if (val != getState)
            {

                GetState = val;

                notifyUpdate(new Message("Subject State has been changed"));
            }
        }
        public void Detach(Observer o)
        {
            observers.Remove(o);
        }
        public void notifyUpdate(Message m)
        {
            foreach (Observer o in observers) { o.update(m); }
        }
    }
}
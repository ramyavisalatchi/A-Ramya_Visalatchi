using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface Subject

    {
        int GetState { get; set; }

        void ChangeState(int val);
        void Attach(Observer o);

        void Detach(Observer o);

        void notifyUpdate(Message m);

    }
}

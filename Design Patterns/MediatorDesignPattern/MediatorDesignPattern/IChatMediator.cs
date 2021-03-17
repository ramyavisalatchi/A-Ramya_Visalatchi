using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public interface IChatMediator
    {
        void AddUser(IUser user);
        void SendMessage(string msg, IUser user);
    }
}

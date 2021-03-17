using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public interface IUser
    {
        
        void ReceiveMessage(string msg);
        void SendMessage(string msg);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    class PremiumUser:IUser
    {
        private IChatMediator chatMediator;
        private string name;


        public PremiumUser(IChatMediator chatMediator, string name)
        {
            this.chatMediator = chatMediator;
            this.name = name;
        }
        public void ReceiveMessage(string msg)
        {
            Console.WriteLine(this.name + ": Received Message:" + msg);
        }

        public void SendMessage(string msg)
        {
            Console.WriteLine(this.name + ": Sending Message=" + msg + "\n");
            chatMediator.SendMessage(msg, this);
        }
    }
}

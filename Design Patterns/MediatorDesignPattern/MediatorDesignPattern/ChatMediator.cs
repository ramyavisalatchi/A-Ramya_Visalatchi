using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorDesignPattern
{
    public class ChatMediator:IChatMediator
    {
        private List<IUser> users = new List<IUser>();
        public void AddUser(IUser user)
        {
            users.Add(user);
        }

        public ChatMediator()
        {

        }

        public void SendMessage(string msg, IUser user)
        {
            foreach (var u in users)
            {
                // message should not be received by the user sending it
                if (u != user)
                {
                    u.ReceiveMessage(msg);
                }
            }
        }
    }
}

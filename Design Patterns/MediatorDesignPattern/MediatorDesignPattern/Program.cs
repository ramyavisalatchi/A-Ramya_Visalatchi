using System;

namespace MediatorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();

            IUser Ram = new BasicUser(chatMediator, "Ram");
            IUser Raj = new BasicUser(chatMediator, "Raj");

            chatMediator.AddUser(Ram);
            chatMediator.AddUser(Raj);
            
            IUser Radha = new PremiumUser(chatMediator, "Radha");
            IUser Raju = new PremiumUser(chatMediator, "Raju");
            
            chatMediator.AddUser(Radha);
            chatMediator.AddUser(Raju);

            Console.WriteLine("Basic user sending message");
            Ram.SendMessage("\nHai Everyone...I am a Basic User");
            Console.WriteLine("\nPremium user sending message");
            Raju.SendMessage("\nHai Everyone...I am a Premium User");

            Console.Read();
        }
    }
}

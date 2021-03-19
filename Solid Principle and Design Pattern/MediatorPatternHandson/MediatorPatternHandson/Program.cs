using System;

namespace MediatorPatternHandson
{
    class Program
    {
        static void Main(string[] args)
        {
            IChatMediator chatMediator = new ChatMediator();
            IUser basicUser = new BasicUser(chatMediator,"Pavithra");
            IUser premiumUser = new PremiumUser(chatMediator,"Bhama");
            chatMediator.AddUser(basicUser);
            chatMediator.AddUser(premiumUser);
            
            IUser priya = new BasicUser(chatMediator, "Priya");
            IUser ram = new PremiumUser(chatMediator, "Ram");
            chatMediator.AddUser(priya);
            chatMediator.AddUser(ram);

            Console.WriteLine("Basic user is sending the message");
            basicUser.SendMessage("\nHi Everyone...I am  Basic User");
            Console.WriteLine("\nPremium user is sending the message");
            premiumUser.SendMessage("\nHi Everyone...I am  Premium User");
        }
    }
}

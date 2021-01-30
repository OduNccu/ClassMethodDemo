using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            User user0 = new User();
            user0.Id = 001;
            user0.FirstName = "Hamza";
            user0.SecondName = "Erdal";
            user0.CreditScore = 20;

            User user1 = new User();
            user1.Id = 002;
            user1.FirstName = "Emre";
            user1.SecondName = "Çadır";
            user1.CreditScore = 12;

            User user2 = new User();
            user2.Id = 003;
            user2.FirstName = "Melisa";
            user2.SecondName = "Pamuk";
            user2.CreditScore = 8;

            User user3 = new User();
            user3.Id = 004;
            user3.FirstName = "Sahil";
            user3.SecondName = "Kaçak";
            user3.CreditScore = 0;

            User[] users = new User[] { user0, user1, user2, user3 };

            UserManager userManager = new UserManager();

            userManager.Add(user0);
            userManager.Add(user1);
            userManager.Add(user2);
            userManager.Add(user3);

            userManager.Delete(user0);
            userManager.Delete(user1);
            userManager.Delete(user2);
            userManager.Delete(user3);

            userManager.List(users);
        }
    }
}

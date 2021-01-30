using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class UserManager
    {
        public void Add(User user)
        {
            Console.WriteLine("+++++User Added+++++");
            Console.WriteLine("+User Id : " + user.Id);
            Console.WriteLine("+User First Name : " + user.FirstName);
            Console.WriteLine("+User Second Name : " + user.SecondName);
            Console.WriteLine("+User Credit Score : " + user.CreditScore);
            Console.WriteLine("\n");

        }

        public void Delete(User user)
        {
            Console.WriteLine("-----User Deleted-----");
            Console.WriteLine("-User Id : " + user.Id);
            Console.WriteLine("-User First Name : " + user.FirstName);
            Console.WriteLine("-User Second Name : " + user.SecondName);
            Console.WriteLine("-User Credit Score : " + user.CreditScore);
            Console.WriteLine("\n");

        }

        public void List(User[] users)
        {
            foreach (var user in users)
            {
                Console.WriteLine("****Users****");
                Console.WriteLine("User Id : " + user.Id);
                Console.WriteLine("User First Name : " + user.FirstName);
                Console.WriteLine("User Second Name : " + user.SecondName);
                Console.WriteLine("User Credit Score : " + user.CreditScore);
                Console.WriteLine("____________________________________________");
            }
        }
    }
}
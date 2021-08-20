﻿using System;

namespace UserRegisteration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------This is User Registration Problem--------------------");
            Registration user = new Registration();

            Console.Write("Enter your first name:");
            string firstName = Console.ReadLine();
            user.Check(firstName);
            
            Console.Write("Enter your last name:");
            string lastName = Console.ReadLine();
            user.Check(lastName);
            
            Console.Write("Enter your Email id:");
            string email = Console.ReadLine();
            user.CheckMail(email);
            
            Console.Write("Enter your Mobile Number:");
            string num = Console.ReadLine();
            user.PhoneNumberCheck(num);
            
            Console.Write("Enter your Password:");
            string psw = Console.ReadLine();
            user.PasswordCheck(psw);
        }
    }
}

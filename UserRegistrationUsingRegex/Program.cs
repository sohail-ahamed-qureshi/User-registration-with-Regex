﻿using System;

namespace UserRegistrationUsingRegex
{
    class Program
    {   /// <summary>
    /// UC5- Rule 1- Password validation
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            RegexValidation regex = new RegexValidation();
            Console.WriteLine("User registration Problem statement");
            Console.WriteLine("*First letter should be capital.");
            Console.WriteLine("*length should be Minimum three characters.");
            Console.WriteLine("Enter First name :");
            string fname = Console.ReadLine();
            regex.CheckName(fname);
            Console.WriteLine("Enter Last name :");
            string lname = Console.ReadLine();
            regex.CheckName(lname);
            Console.WriteLine("Enter Email id :");
            string email = Console.ReadLine();
            regex.CheckEmail(email);
            Console.WriteLine("Enter Mobile no. :");
            string mobile = Console.ReadLine();
            regex.CheckMobileNo(mobile);
            Console.WriteLine("Enter Password :");
            string password = Console.ReadLine();
            regex.CheckPassword(password);
        }
    }
}

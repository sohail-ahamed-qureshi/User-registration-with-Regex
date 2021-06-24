using System;

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
            regex.LambdaNameValidation(fname);
            Console.WriteLine("Enter Last name :");
            string lname = Console.ReadLine();
            regex.LambdaNameValidation(lname);
            Console.WriteLine("Enter Email id :");
            string email = Console.ReadLine();
            regex.LambdaEmailValidation(email);
            Console.WriteLine("Enter Mobile no. :");
            string mobile = Console.ReadLine();
            regex.LambdaMobileNumberValidation(mobile);
            Console.WriteLine("Enter Password :");
            string password = Console.ReadLine();
            regex.LambdaPasswordValidation(password);   
        }
    }
}

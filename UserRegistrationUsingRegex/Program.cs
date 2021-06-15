using System;

namespace UserRegistrationUsingRegex
{
    class Program
    {   /// <summary>
    /// UC1-First Name validation
    /// </summary>
    /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("User registration Problem statement");
            Console.WriteLine("*First letter should be capital.");
            Console.WriteLine("*length should be Minimum three characters.");
            Console.WriteLine("Enter First name :");
            string fname = Console.ReadLine();
            RegexValidation regex = new RegexValidation();
            regex.CheckFirstName(fname);
        }
    }
}

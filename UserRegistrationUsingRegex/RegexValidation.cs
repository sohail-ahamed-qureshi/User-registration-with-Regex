using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingRegex
{
    class RegexValidation
    {
        public void CheckName(string name)
        {
            string validateFirstName = "^[A-Z][a-z]{3,20}$";
            try
            {
                if(Regex.IsMatch(name, validateFirstName))
                    Console.WriteLine(" Name saved succesfull");
                else
                    Console.WriteLine("Invalid name!!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

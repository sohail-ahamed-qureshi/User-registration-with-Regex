using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingRegex
{
    class RegexValidation
    {
        internal void CheckName(string name)
        {
            string validateFirstName = "^[A-Z][a-z]{3,20}$";
            try
            {
                if(Regex.IsMatch(name, validateFirstName))
                    Console.WriteLine(" Name validate succesfull");
                else
                    Console.WriteLine("Invalid name!!");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        internal void CheckEmail(string email)
        {
            string validateEmail = "^[a-z][a-zA-Z0-9._-]{3,20}@[a-z]{3,10}.(com)$";
            try
            {
                if (Regex.IsMatch(email, validateEmail))
                    Console.WriteLine(" email validate succesfull");
                else
                    Console.WriteLine("Invalid email!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        internal void CheckMobileNo(string mobile)
        {
            string validateMobile = "^[0-9]{1,4}\\s[0-9]{10,12}$";
            try
            {
                if (Regex.IsMatch(mobile, validateMobile))
                    Console.WriteLine(" mobile no validate succesfull");
                else
                    Console.WriteLine("Invalid mobile no.!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        internal void CheckPassword(string password)
        {
            string validatepassword = "^(?=.*[A-Z])(?=.*[a-z]{8,}).*$";
            try
            {
                if (Regex.IsMatch(password, validatepassword))
                    Console.WriteLine("password validate succesfull");
                else
                    Console.WriteLine("Invalid password!!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingRegex
{
   public class RegexValidation
    {
        public bool CheckName(string name)
        {
            string validateFirstName = "^[A-Z][a-z]{3,20}$";
            try
            {
                if (Regex.IsMatch(name, validateFirstName))
                    //Console.WriteLine(" Name validate succesfull");
                    return true;
                else
                    //Console.WriteLine("Invalid name!!");
                    throw new RegexValidationExceptions(RegexValidationExceptions.InvalidUserDetails.INVALID_NAME);
            }
            catch(RegexValidationExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public bool CheckEmail(string email)
        {
            string validateEmail = "^[a-zA-Z0-9]+[._+-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
            try
            {
                if (Regex.IsMatch(email, validateEmail))
                    //Console.WriteLine(" email validate succesfull");
                    return true;
                else
                    // Console.WriteLine("Invalid email!!");
                    throw new RegexValidationExceptions(RegexValidationExceptions.InvalidUserDetails.INVALID_EMAIL);
            }
            catch (RegexValidationExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
        public bool CheckMobileNo(string mobile)
        {
            string validateMobile = "^[0-9]{1,4}\\s[0-9]{10,12}$";
            try
            {
                if (Regex.IsMatch(mobile, validateMobile))
                    // Console.WriteLine(" mobile no validate succesfull");
                    return true;
                else
                    //Console.WriteLine("Invalid mobile no.!!");
                    throw new RegexValidationExceptions(RegexValidationExceptions.InvalidUserDetails.INVALID_MOBILE_NUMBER);
            }
            catch (RegexValidationExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }

        public bool CheckPassword(string password)
        {
            string validatepassword = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@^*!~]).{8,}$";
            try
            {
                if (Regex.IsMatch(password, validatepassword))
                    //Console.WriteLine("password validate succesfull");
                    return true;
                else
                    //Console.WriteLine("Invalid password!!");
                    throw new RegexValidationExceptions(RegexValidationExceptions.InvalidUserDetails.INVALID_PASSWORD);
            }
            catch (RegexValidationExceptions ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return false;
        }
    }
}

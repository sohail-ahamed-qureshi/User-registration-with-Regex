using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingRegex
{
    public class RegexValidation
    {
        string validateFirstName = "^[A-Z][a-z]{3,20}$";
        string validateEmail = "^[a-zA-Z0-9]+[._+-]{0,1}[0-9a-zA-Z]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";
        string validateMobile = "^[0-9]{1,4}\\s[0-9]{10,12}$";
        string validatepassword = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[&%$#@^*!~]).{8,}$";
        public bool CheckName(string name)
        {
            try
            {
                if (string.IsNullOrEmpty(name))
                    throw new RegexValidationExceptions(RegexValidationExceptions.InvalidUserDetails.EMPTY_NAME);
                if (Regex.IsMatch(name, validateFirstName))
                    return true;
                else
                    throw new RegexValidationExceptions(RegexValidationExceptions.InvalidUserDetails.INVALID_NAME);
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
        public bool CheckEmail(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                    throw new RegexValidationExceptions(RegexValidationExceptions.InvalidUserDetails.EMPTY_EMAIL);
                if (Regex.IsMatch(email, validateEmail))
                    return true;
                else
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

            try
            {
                if (string.IsNullOrEmpty(mobile))
                    throw new RegexValidationExceptions(RegexValidationExceptions.InvalidUserDetails.EMPTY_MOBILE_NUMBER);
                if (Regex.IsMatch(mobile, validateMobile))
                    return true;
                else
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
            try
            {
                if (string.IsNullOrEmpty(password))
                    throw new RegexValidationExceptions(RegexValidationExceptions.InvalidUserDetails.EMPTY_PASSWORD);
                if (Regex.IsMatch(password, validatepassword))
                    return true;
                else
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
        public bool LambdaNameValidation(string name) => Regex.IsMatch(name, validateFirstName) ? true : throw new RegexValidationExceptions(RegexValidationExceptions.InvalidUserDetails.INVALID_NAME);
        public bool LambdaEmailValidation(string email) => Regex.IsMatch(email, validateEmail) ? true : throw new RegexValidationExceptions(RegexValidationExceptions.InvalidUserDetails.INVALID_EMAIL);
        public bool LambdaMobileNumberValidation(string mobile) => Regex.IsMatch(mobile, validateMobile) ? true : throw new RegexValidationExceptions(RegexValidationExceptions.InvalidUserDetails.INVALID_MOBILE_NUMBER);
        public bool LambdaPasswordValidation(string password) => Regex.IsMatch(password, validatepassword) ? true : throw new RegexValidationExceptions(RegexValidationExceptions.InvalidUserDetails.INVALID_PASSWORD);
    }
}

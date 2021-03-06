using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationUsingRegex
{
    /// <summary>
    /// Regex Validations Custom exceptions class derived from Exception class
    /// </summary>
    public class RegexValidationExceptions : Exception
    {
        /// <summary>
        /// Contains types of Exceptions that can occur during user validations. 
        /// </summary>
        public enum InvalidUserDetails
        {
            EMPTY_NAME,
            EMPTY_EMAIL,
            EMPTY_MOBILE_NUMBER,
            EMPTY_PASSWORD,
            INVALID_NAME,
            INVALID_EMAIL,
            INVALID_MOBILE_NUMBER,
            INVALID_PASSWORD
        }
        /// <summary>
        /// Custom Exceptions for User Validations, returns the message to Console.
        /// </summary>
        /// <param name="error">Defines the type of Exception</param>
        public RegexValidationExceptions(InvalidUserDetails error)
        {
            if (error == InvalidUserDetails.EMPTY_NAME)
                Console.WriteLine(error + ": Name cannot be empty or null");
            if (error == InvalidUserDetails.EMPTY_EMAIL)
                Console.WriteLine(error + ": Email cannot be empty or null");
            if (error == InvalidUserDetails.EMPTY_MOBILE_NUMBER)
                Console.WriteLine(error + ": Mobile Number cannot be empty or null");
            if (error == InvalidUserDetails.EMPTY_PASSWORD)
                Console.WriteLine(error + ": Password cannot be empty or null");
            if (error == InvalidUserDetails.INVALID_EMAIL)
                Console.WriteLine(error + ": Email Validation Error!!");
            if (error == InvalidUserDetails.INVALID_MOBILE_NUMBER)
                Console.WriteLine(error + ": Mobile Number Validation Error!!");
            if (error == InvalidUserDetails.INVALID_NAME)
                Console.WriteLine(error + ": Name Validation Error!!");
            if (error == InvalidUserDetails.INVALID_PASSWORD)
                Console.WriteLine(error + ": Password Validation Error!!");
        }
    }
}

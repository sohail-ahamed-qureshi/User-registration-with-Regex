using NUnit.Framework;
using UserRegistrationUsingRegex;

namespace NUnitUserValidation
{
    public class Tests
    {
        bool firstName;
        bool lastName;
        bool mobile;
        bool email;
        bool password;
        [SetUp]
        public void Setup()
        {
           RegexValidation regex = new RegexValidation();
            firstName = regex.CheckName("Sohail");
            lastName = regex.CheckName("Ahamed");
            mobile = regex.CheckMobileNo("91 9663552136");
            email = regex.CheckEmail("sohailqureshi82@gmail.com");
            password = regex.CheckPassword("S@k215600");
        }

        [Test]
        public void GivenUserDetails_ReturnsValidationResult()
        {    
            if (firstName && lastName && mobile && email && password)
                Assert.Pass("Entry SuccessFull");
            else
                Assert.Fail("Entry Failed");
        }
    }
}
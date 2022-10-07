using Sample.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Sample.Test.Extensions
{
    public class StringExtensionsTest
    {
        public StringExtensionsTest() { }

        [Theory]
        [InlineData("sasdellegabs")]
        [InlineData("sasdellegabs@gmail")]
        public void IsValidMail_ReturnFalse(string expectedEmail)
        {
            var email = expectedEmail;

            var emailValid = email.IsValidMail();
            
            Assert.False(emailValid);
        }

        [Theory]
        [InlineData("sasdellegabs@gmail.com")]
        [InlineData("sasdellegabs@yahoo.com")]
        public void IsValidMail_ReturnTrue(string expectedEmail)
        {
            var email = expectedEmail;

            var emailValid = email.IsValidMail();

            Assert.True(emailValid);
        }

    }
}

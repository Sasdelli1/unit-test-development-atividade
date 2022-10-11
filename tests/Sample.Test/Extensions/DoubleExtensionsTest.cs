using Newtonsoft.Json.Linq;
using Sample.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Sample.Test.Extensions
{
    public class DoubleExtensionsTest
    {
        public DoubleExtensionsTest()
        { 
        }

        [Theory]
        [InlineData(5.99)]
        [InlineData(2.99)]
        [InlineData(5000.00)]
        [InlineData(45.80)]
        public void ToStringMoneyPtBR(double value)
        {

            string actualResult;

            //double doubleAmt = double.Parse(value.ToStringMoneyPtBR());
            actualResult = value.ToStringMoneyPtBR();

            Assert.Contains("R$", actualResult);
        }
    }
}

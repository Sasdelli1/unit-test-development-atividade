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
        [InlineData(0.99)]
        [InlineData(2.99)]
        [InlineData(5000.00)]
        [InlineData(-45.80)]
        public void Should_ToStringMoneyPtBR_ReturnSucess(double value)
        {

            string actualResult;

            //double doubleAmt = double.Parse(value.ToStringMoneyPtBR());
            actualResult = value.ToStringMoneyPtBR();

            Assert.Contains("R$", actualResult);
        }

        [Theory]
        [InlineData(0000000000000000000000000000000000000000000000000000000000000.9999999)]
        public void Should_ToStringMoneyPtBR_ReturnFalse(double value)
        {


            Assert.Throws<OverflowException>(() => value.ToStringMoneyPtBR());

        }    
    }

}

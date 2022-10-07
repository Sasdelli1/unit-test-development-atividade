using Xunit;

namespace Sample.Test
{
    public class SampleServiceTest
    {
        private readonly SampleService _sampleService;

        public SampleServiceTest()
        {
            //arrange (qualque tipo de variável necessária para montar o teste)
            _sampleService = new SampleService();
        }

        [Fact]
        public void Subtract_MultipleValues_ReturnSuccess()
        {
            //arrange
            var value1 = 80;
            var value2 = 1;
            var value3 = 1;
            var value4 = 1;
            var value5 = 1;
            var total = 100;
            var withTotal = 16;
            var withoutTotal = 76;

            //act
            var resultWithTotal = _sampleService.Subtract(total, value1, value2, value3, value4, value5);
            var resultWithoutTotal = _sampleService.Subtract(value1, value2, value3, value4, value5);

            //Assert
            Assert.Equal(withTotal, resultWithTotal);
            Assert.Equal(withoutTotal, resultWithoutTotal);
        }

        [Theory]
        [InlineData(2, 4, 6, 8, 12, 2, 34)]
        [InlineData(4,8,12,16,24,4,68)]
        [InlineData(-10,10,-5,20,-1,10,24)]
        [InlineData(10, 25,-100, -50, -2, -30, -147)]
        public void Sum_MultipleValues_ReturnSuccess(decimal value1, decimal value2, decimal value3, decimal value4, decimal value5,
            decimal total, decimal expectedTotal)
        { 
            var resultWithTotal = _sampleService.Sum(value1, value2, value3, value4, value5, total); 
            
            Assert.Equal(expectedTotal, resultWithTotal);   
        }

        [Theory]
        [InlineData(2, 4, 6, 8, 12, 2, 28)]
        [InlineData(4, 8, 12, 16, 24, 4, 64)]
        [InlineData(-10, 10, -5, 20, -1, 10, 28)]
        [InlineData(10, 25, -100, -50, -2, -30, -180)]
        public void Sum_MultipleValues_ReturnFail(decimal value1, decimal value2, decimal value3, decimal value4, decimal value5,
            decimal total, decimal expectedTotal)
        {
            var resultWithTotal = _sampleService.Sum(value1, value2, value3, value4, value5, total);

            Assert.NotEqual(expectedTotal, resultWithTotal);
        }
        //[Fact]
        //public void Sum_MultipleValues_ReturnSuccess()
        //{
        //    //arrange
        //    var value1 = 2;
        //    var value2 = 4;
        //    var value3 = 6;
        //    var value4 = 8;
        //    var value5 = 12;
        //    var total = 2;
        //    var withTotal = 34;
        //    var withoutTotal = 32;

        //    //act
        //    var resultWithTotal = _sampleService.Sum(total, value1, value2, value3, value4, value5);
        //    var resultWithoutTotal = _sampleService.Sum(value1, value2, value3, value4, value5);

        //    //Assert
        //    Assert.Equal(withTotal, resultWithTotal);
        //    Assert.Equal(withoutTotal, resultWithoutTotal);
        //}

        [Theory]
        [InlineData(-4)]
        [InlineData(-2)]
        [InlineData(0)]
        [InlineData(2)]
        public void IsEven_ValuesLessThan3_ReturnTrue(int value)
        {
            //act (chamada do método a ser testado, logo a unidade)
            var result = _sampleService.IsEven(value);

            //assert (o cenário proposto no resultado do teste)
            Assert.True(result);
        }

        [Theory]
        [InlineData(-5)]
        [InlineData(-3)]
        [InlineData(-1)]
        [InlineData(1)]
        public void IsEven_ValuesLessThan3_ReturnFalse(int value)
        {
            //act (chamada do método a ser testado, logo a unidade)
            var result = _sampleService.IsEven(value);

            //assert (o cenário proposto no resultado do teste)
            Assert.False(result);
        }

        [Theory]
        [InlineData(-5)]
        [InlineData(-3)]
        [InlineData(-1)]
        [InlineData(1)]
        public void IsOdd_ValuesLessThan3_ReturnTrue(int value)
        {
            //act (chamada do método a ser testado, logo a unidade)
            var result = _sampleService.IsOdd(value);

            //assert (o cenário proposto no resultado do teste)
            Assert.True(result);
        }

        [Theory]
        [InlineData(-4)]
        [InlineData(-2)]
        [InlineData(0)]
        [InlineData(2)]
        public void IsOdd_ValuesLessThan3_ReturnFalse(int value)
        {
            //act (chamada do método a ser testado, logo a unidade)
            var result = _sampleService.IsOdd(value);

            //assert (o cenário proposto no resultado do teste)
            Assert.False(result);
        }

        [Theory]
        [InlineData(-1)]
        [InlineData(0)]
        [InlineData(1)]
        public void IsPrime_ValuesLessThan2_ReturnFalse(int value)
        {
            var result = _sampleService.IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(7)]
        public void IsPrime_PrimesLessThan10_ReturnTrue(int value)
        {
            var result = _sampleService.IsPrime(value);

            Assert.True(result, $"{value} should be prime");
        }

    }
}

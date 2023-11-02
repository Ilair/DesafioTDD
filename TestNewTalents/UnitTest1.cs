using NewTalents;
using System;
using Xunit;

namespace TestNewTalents
{
    public class UnitTest1
    {

        public Calculator ClassConsructor()
        {
            string data = "30/10/2023";
            Calculator calculator = new Calculator(data);

            return calculator;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void SumTest(int valOne, int valTwo, int result)
        {
            Calculator calculadora = ClassConsructor();
            int resultCalculator = calculadora.Somar(valOne, valTwo);

            Assert.Equal(result, resultCalculator);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(4, 5, 20)]
        public void MultiplyTest(int valOne, int valTwo, int result)
        {
            Calculator calculadora = ClassConsructor();
            int resultCalculator = calculadora.Multiplicar(valOne, valTwo);

            Assert.Equal(result, resultCalculator);
        }

        [Theory]
        [InlineData(3, 2, 1)]
        [InlineData(9, 5, 4)]
        public void MinusTest(int valOne, int valTwo, int result)
        {
            Calculator calculadora = ClassConsructor();
            int resultCalculator = calculadora.Diminuir(valOne, valTwo);

            Assert.Equal(result, resultCalculator);
        }

        [Theory]
        [InlineData(2, 2, 1)]
        [InlineData(10, 5, 2)]
        public void DividirTest(int valOne, int valTwo, int result)
        {
            Calculator calculadora = ClassConsructor();
            int resultCalculator = calculadora.Dividir(valOne, valTwo);

            Assert.Equal(result, resultCalculator);
        }

        [Fact]
        public void TestDividedByZero()
        {
            Calculator calc = ClassConsructor();

            Assert.Throws<DivideByZeroException>(
                () => calc.Dividir(3, 0)
            );
        }

        [Fact]
        public void TestHistory()
        {
            Calculator calc = ClassConsructor();

            calc.Somar(1, 2);
            calc.Somar(3, 8);
            calc.Somar(3, 7);
            calc.Somar(4, 2);

            var calcList = calc.History();

            Assert.NotEmpty(calc.History());
            Assert.Equal(3,calcList.Count);
        }
    }
}

namespace Demo.Test
{
    using Demo.Lib;
    using Xunit;

    public class CalculationTest
    {
        [Fact]
        public void Test1()
        {
            var response = new Calculation();

            var result = response.Add(1, 2);

            Assert.Equal(3, result);
        }
    }
}
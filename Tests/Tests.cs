using StockMax;

namespace Tests
{
    public class Tests
    {
        
        [Test]
        public void Test_For_Loss()
        {
            //Arrange
            List<int> prices = new() { 5, 3, 2 };
            long expectedResult = 0;

            //Act
            long result = Program.StockMax(prices);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [Test]
        public void Test_For_Profit()
        {
            //Arrange
            List<int> prices = new() { 1, 2, 100 };
            long expectedResult = 197;

            //Act
            long result = Program.StockMax(prices);

            //Assert
            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}
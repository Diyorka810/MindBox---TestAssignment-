using FirstTask;

namespace FirstTaskTests
{
    [TestClass]
    public class CircleTests
    {
        [TestMethod]
        [DataRow(2, 12.5663706)]
        [DataRow(1, 6.2831853)]
        [DataRow(0.5, 3.1415927)]
        public void TryFindArea_Success(double radius, double expectedResult)
        {
            //Arrange
            var circle = new Circle(radius);

            //Act
            var result = circle.Area;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void TryFindArea_RadiusLessThanZero_ArgumentException()
        {
            // Arrange
            var invalidRadius = -1;

            // Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Circle(invalidRadius));
        }
    }
}
using FirstTask;

namespace FirstTaskTests
{
    [TestClass]
    public class TriangleTests
    {
        [TestMethod]
        [DataRow(-1, -1, -1)]
        [DataRow(0, 0, -1)]
        public void TryFindArea_LinesLessThanZero_ArgumentException(double firstLine, double secondLine, double thirdLine)
        {
            //Arrange & Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(firstLine, secondLine, thirdLine));
        }

        [TestMethod]
        [DataRow(10, 1, 1)]
        [DataRow(1, 6, 4)]
        [DataRow(2, 3, 7)]
        public void TryFindArea_NonExistentTriangle_ArgumentException(double firstLine, double secondLine, double thirdLine)
        {
            //Arrange & Act & Assert
            Assert.ThrowsException<ArgumentException>(() => new Triangle(firstLine, secondLine, thirdLine));
        }

        [TestMethod]
        [DataRow(3, 4, 5, 6)]
        [DataRow(15, 20, 25, 150)]
        public void TryFindArea_RightTriangle_Success(double firstLine, double secondLine, double thirdLine, double expectedResult)
        {
            //Arrange
            var triangle = new Triangle(firstLine, secondLine, thirdLine);

            //Act
            var result = triangle.Area;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result, expectedResult);
            Assert.IsTrue(triangle.IsRightTriangle);
        }

        [TestMethod]
        [DataRow(6, 7, 8, 20.3331626)]
        [DataRow(2, 2, 3, 1.9843135)]
        [DataRow(1, 1, 1, 0.4330127)]
        public void TryFindArea_Success(double firstLine, double secondLine, double thirdLine, double expectedResult)
        {
            //Arrange
            var triangle = new Triangle(firstLine, secondLine, thirdLine);

            //Act
            var result = triangle.Area;

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result, expectedResult);
            Assert.IsFalse(triangle.IsRightTriangle);
        }
    }
}
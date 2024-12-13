using AreaCalculating.Contrascts;
using AreaCalculating.Figure;

namespace AreaCalculatingTests.Figure
{
    public class TriangleTests
    {
        private readonly ITriangle _iTriangle;

        public TriangleTests()
        {
            _iTriangle = new Triangle();
        }

        [Fact]
        public async Task TriangleArea_Calculating_PositiveNumbers()
        {
            //Arrange
            var sideA = 4.3;
            var sideB = 2.4;
            var sideC = 2.1;
            var perimeter = sideA + sideB + sideC;
            var halfMeter = perimeter / 2;
            var expected = Math.Sqrt(halfMeter * (halfMeter - sideA) * (halfMeter - sideB) * (halfMeter - sideC));

            //Act
            var actual = await _iTriangle.Area(sideA, sideB, sideC);


            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public async Task TriangleArea_Calculating_Iintegers()
        {
            //Arrange
            var sideA = 4;
            var sideB = 2;
            var sideC = 2;
            var perimeter = sideA + sideB + sideC;
            var halfMeter = perimeter / 2;
            var expected = Math.Sqrt(halfMeter * (halfMeter - sideA) * (halfMeter - sideB) * (halfMeter - sideC));

            //Act
            var actual = await _iTriangle.Area(sideA, sideB, sideC);


            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

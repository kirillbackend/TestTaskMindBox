using AreaCalculating.Contrascts;
using AreaCalculating.Figure;

namespace AreaCalculatingTests.Figure
{
    public class CircleTest
    {
        private readonly ICircle _iCircle;

        public CircleTest()
        {
            _iCircle = new Circle();
        }

        [Fact]
        public async Task CircleArea_Calculating_PositiveNumber()
        {
            //Arrange
            var radius = 22.34;
            var expected = Math.Pow(radius, 2) * Math.PI;

            //Act
            var actual = await _iCircle.Area(radius);


            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public async Task CircleArea_Calculating_Iinteger()
        {
            //Arrange
            var radius = 12;
            var expected = Math.Pow(radius, 2) * Math.PI;

            //Act
            var actual = await _iCircle.Area(radius);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

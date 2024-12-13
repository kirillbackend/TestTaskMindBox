using AreaCalculating.Contrascts;

namespace AreaCalculating.Figure
{
    public class Triangle : ITriangle
    {
        public async Task<double> Area(double sideA, double sideB, double sideC)
        {
            var perimeter = await TrianglePerimeter(sideA, sideB, sideC);
            var halfMeter = await TriangleHalfMeter(perimeter);

            var area = Math.Sqrt(halfMeter * (halfMeter - sideA) * (halfMeter - sideB) * (halfMeter - sideC));
            return area;
        }

        #region private metods

        private async Task<double> TrianglePerimeter(double sideA, double sideB, double sideC)
        {
            var perimeter = sideA + sideB + sideC;

            return perimeter;
        }

        private async Task<double> TriangleHalfMeter(double perimeter)
        {
            var halfMeter = perimeter / 2;

            return halfMeter;
        }

        #endregion
    }
}

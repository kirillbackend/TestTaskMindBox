using AreaCalculating.Contrascts;

namespace AreaCalculating.Figure
{
    public class Circle : ICircle
    {
        public async Task<double> Area(double radius)
        {
            var area = Math.PI * Math.Pow(radius, 2);

            return area;
        }
    }
}

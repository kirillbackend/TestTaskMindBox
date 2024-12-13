namespace AreaCalculating.Contrascts
{
    public interface ITriangle
    {
        Task<double> Area(double sideA, double sideB, double sideC);
    }
}

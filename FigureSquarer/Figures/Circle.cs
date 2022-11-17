namespace FigureSquarer.Figures
{
    public class Circle : Figure
    {
        private double radius;

        public double Radius
        {
            get => radius; set
            {
                radius = value;
            }
        }

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.Pow(Radius, 2) * Math.PI;
        }
    }
}
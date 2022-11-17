using FigureSquarer.Exceptions;
using FigureSquarer.Figures;

namespace FigureSquarer.Factory
{
    public class TriangleFactory : FigureFactory
    {
        public override Figure CreateFigure(params double[] figureParams)
        {
            if (figureParams.Length != 3)
                throw new FigureCreationException<Triangle>(figureParams);
            return new Triangle(figureParams.ToArray());
        }
    }
}
using FigureSquarer.Exceptions;
using FigureSquarer.Figures;

namespace FigureSquarer.Factory
{
    public class CircleFactory : FigureFactory
    {
        public override Figure CreateFigure(params double[] figureParams)
        {
            if (figureParams.Length != 1)
                throw new FigureCreationException<Circle>(figureParams);
            return new Circle(figureParams[0]);
        }
    }
}
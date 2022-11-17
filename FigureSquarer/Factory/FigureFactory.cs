using FigureSquarer.Figures;

namespace FigureSquarer.Factory
{
    public abstract class FigureFactory
    {
        public abstract Figure CreateFigure(params double[] figureParams);
    }
}
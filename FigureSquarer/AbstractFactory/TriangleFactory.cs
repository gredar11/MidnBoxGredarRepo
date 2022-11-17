using FigureSquarer.Exceptions;
using FigureSquarer.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquarer.AbstractFactory
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

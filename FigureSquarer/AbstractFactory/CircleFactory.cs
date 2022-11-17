using FigureSquarer.Exceptions;
using FigureSquarer.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquarer.AbstractFactory
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

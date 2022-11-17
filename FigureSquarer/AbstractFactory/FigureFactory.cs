using FigureSquarer.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquarer.AbstractFactory
{
    public abstract class FigureFactory
    {
        abstract public Figure CreateFigure(params double[] figureParams);
    }
}

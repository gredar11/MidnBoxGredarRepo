using FigureSquarer.AbstractFactory;
using FigureSquarer.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquarer
{
    public class Calculator
    {
        public static double CalculateArea(params double[] incomingValues)
        {
            FigureFactory figureFactory = GetFigureFactory(incomingValues);
            Figure figure = figureFactory.CreateFigure(incomingValues);
            return figure.GetArea();
        }
        public static FigureFactory GetFigureFactory(params double[] doubles)
        {
            if (doubles.Length == 1)
            {
                return new CircleFactory();
            }
            if (doubles.Length == 3)
            {
                return new TriangleFactory();
            }
            throw new Exception($"Неверные входные данные [{string.Join(", ", doubles)}]");
        }
        public static double CalculateAreaOfFigure(Figure calculableFigure)
        {
            return calculableFigure.GetArea();
        }
    }
}

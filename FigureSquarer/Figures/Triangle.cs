using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquarer.Figures
{
    public class Triangle : Figure
    {
        private double[] edgesLengths;
        [Required]
        public double[] EdgesLengths
        {
            get => edgesLengths;
            set
            {
                if (value.Length != 3)
                    throw new Exception($"Неверный формат данных {string.Concat(value)}");
                edgesLengths = value;
            }
        }
        public Triangle(double[] edges) => EdgesLengths = edges;
        public override double GetArea()
        {
            double halfOfPerimeter = (EdgesLengths.Sum() / 2.0);
            double area = Math.Sqrt(halfOfPerimeter * (halfOfPerimeter - EdgesLengths[0]) * (halfOfPerimeter - EdgesLengths[1]) * (halfOfPerimeter - EdgesLengths[2]));
            return area;
        }
        public bool IsTriangeRight()
        {
            var listOfLengts = EdgesLengths.ToList();
            listOfLengts.Sort();
            var biggerEdgeSquared = Math.Pow(listOfLengts[2], 2);
            var lowerEdgesSquared = Math.Pow(listOfLengts[0], 2) + Math.Pow(listOfLengts[1], 2);
            return biggerEdgeSquared == lowerEdgesSquared;
        }
    }
}

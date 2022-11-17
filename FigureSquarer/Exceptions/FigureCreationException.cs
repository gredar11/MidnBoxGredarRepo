using FigureSquarer.Figures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureSquarer.Exceptions
{
    public class FigureCreationException<T>: Exception where T : Figure
    {
        public FigureCreationException(params double[] doubles):base($"Ошибка при создании объекта типа ({typeof(T)}) с параметрами {string.Join(", ", doubles)}")
        {

        }
    }
}

using FigureSquarer.Figures;

namespace FigureSquarer.Exceptions
{
    public class FigureCreationException<T> : Exception where T : Figure
    {
        public FigureCreationException(params double[] doubles) : base($"Ошибка при создании объекта типа ({typeof(T)}) с параметрами {string.Join(", ", doubles)}")
        {
        }
    }
}
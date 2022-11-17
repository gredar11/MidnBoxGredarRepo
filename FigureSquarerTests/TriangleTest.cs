using FigureSquarer.Exceptions;
using FigureSquarer.Factory;
using FigureSquarer.Figures;

namespace FigureSquarerTests
{
    public class TriangleTest
    {
        [Fact]
        public void TriangleCreationIsRight()
        {
            FigureFactory triangleFactory = new TriangleFactory();
            var triangle = triangleFactory.CreateFigure(1, 2, 3);
            Assert.True(triangle is Triangle);
        }
        [Fact]
        public void TriangleCreationFailed()
        {
            FigureFactory triangleFactory = new TriangleFactory();
            try
            {
                var triangle = triangleFactory.CreateFigure(1, 2);
            }
            catch (FigureCreationException<Triangle> ex)
            {
                Assert.True(true);
            }
            catch (Exception)
            {
                Assert.True(false);
            }
        }

        [Fact]
        public void TriangleIsRightSucces()
        {
            FigureFactory triangleFactory = new TriangleFactory();
            double firstEdge = 3;
            double secondEdge = 4;
            double thirdEdge = 5;
            Triangle triangle = (Triangle)triangleFactory.CreateFigure(firstEdge, secondEdge, thirdEdge);
            Assert.True(triangle.IsTriangeRight());
        }
        [Fact]
        public void TriangleIsRightFailure()
        {
            FigureFactory triangleFactory = new TriangleFactory();
            double firstEdge = 1.0;
            double secondEdge = 1.0;
            double thirdEdge = Math.Sqrt(2.2);
            Triangle triangle = (Triangle)triangleFactory.CreateFigure(firstEdge, secondEdge, thirdEdge);
            Assert.False(triangle.IsTriangeRight());
        }
        [Fact]
        public void AreaIsRight()
        {
            FigureFactory triangleFactory = new TriangleFactory();
            double firstEdge = 3;
            double secondEdge = 4;
            double thirdEdge = 5;
            Triangle triangle = (Triangle)triangleFactory.CreateFigure(firstEdge, secondEdge, thirdEdge);
            var area = triangle.GetArea();
            Assert.Equal(6.0, area);
        }
        [Fact]
        public void AreaFromCalculatorIsRight()
        {
            var area = Calculator.CalculateArea(3, 4, 5); 
            Assert.Equal(6.0, area);
        }
    }
}

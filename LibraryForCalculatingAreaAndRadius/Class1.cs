namespace LibraryForCalculatingAreaAndRadius
{
    
    public interface IShape
    {
        double CalculateArea();
    }


    public class Circle : IShape
    {
        private readonly double radius;

        public Circle(double radius)
        {
            if (radius < 0)
                throw new ArgumentException("Радиус не может быть отрицательным.", nameof(radius));

            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }


    public class Triangle : IShape
    {
        private readonly double sideA;
        private readonly double sideB;
        private readonly double sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                throw new ArgumentException("Длины сторон треугольника должны быть положительными числами.");

            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }

        public double CalculateArea()
        {
            double s = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
            return area;
        }

        public bool IsRightTriangle()
        {
            
            return Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2) ||
                   Math.Pow(sideB, 2) + Math.Pow(sideC, 2) == Math.Pow(sideA, 2) ||
                   Math.Pow(sideA, 2) + Math.Pow(sideC, 2) == Math.Pow(sideB, 2);
        }
    }
}

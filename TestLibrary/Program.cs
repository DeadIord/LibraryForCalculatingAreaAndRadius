using LibraryForCalculatingAreaAndRadius;

namespace TestLibrary
{
    internal class Program
    {
        static void Main()
        {
            bool continueCircle = true;

            do
            {
                Console.Write("Введите площадь круга: ");
                string radiusString = Console.ReadLine()!;

                if (double.TryParse(radiusString, out double radius))
                {
                    Console.WriteLine($"Площадь круга: {new Circle(radius).CalculateArea()}");
                    continueCircle = false; 
                }
                else
                {
                    Console.WriteLine("Некорректный ввод радиуса. Пожалуйста, введите число.");
                }
            } while (continueCircle);

          
            bool continueTriangle = true;

            do
            {
               
                Console.Write("Введите длину стороны A треугольника: ");
                string sideAString = Console.ReadLine()!;

                Console.Write("Введите длину стороны B треугольника: ");
                string sideBString = Console.ReadLine()!;

                Console.Write("Введите длину стороны C треугольника: ");
                string sideCString = Console.ReadLine()!;

            
                if (double.TryParse(sideAString, out double sideA) &&
                    double.TryParse(sideBString, out double sideB) &&
                    double.TryParse(sideCString, out double sideC))
                {
                    IShape triangle = new Triangle(sideA, sideB, sideC);
                    Console.WriteLine($"Площадь треугольника: {triangle.CalculateArea()}");
                    Console.WriteLine($"Прямоугольный треугольник: {((Triangle)triangle).IsRightTriangle()}");

                    
                    continueTriangle = false; 
                }
                else
                {
                    Console.WriteLine("Некорректный ввод сторон треугольника. Пожалуйста, введите числа.");
                }
            } while (continueTriangle);

        }
    }
}
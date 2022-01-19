using System;

namespace Les6Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            Circle circle = new Circle();
            Rectangle rectangle = new Rectangle();

            point.Color = ColorEnum.Red;
            point.IsVisible = false;
            point.X = 10;
            point.Y = 0;
            Console.WriteLine(point.ToString());
            point.ChangeVisible();
            point.Move(-10, Direction.Horizontal);
            point.Move(-10, Direction.Vertical);
            point.ChangeColor(ColorEnum.Black);
            Console.WriteLine(point.ToString());
            Console.WriteLine("--------------------------------------------------------------------------------------");
            
            circle.Color = ColorEnum.Red;
            circle.IsVisible = false;
            circle.X = 10;
            circle.Y = 0;
            circle.Diametr = 5;
            Console.WriteLine(circle.ToString());
            circle.ChangeVisible();
            circle.Move(-10, Direction.Horizontal);
            circle.Move(-10, Direction.Vertical);
            circle.ChangeColor(ColorEnum.Black);
            Console.WriteLine($"Площадь круга: {circle.GetSquare()};");
            Console.WriteLine(circle.ToString());
            Console.WriteLine("--------------------------------------------------------------------------------------");

            rectangle.Color = ColorEnum.Red;
            rectangle.IsVisible = false;
            rectangle.X = 10;
            rectangle.Y = 0;
            rectangle.Width = 5;
            rectangle.Height = 5;
            Console.WriteLine(rectangle.ToString());
            rectangle.ChangeVisible();
            rectangle.Move(-10, Direction.Horizontal);
            rectangle.Move(-10, Direction.Vertical);
            rectangle.ChangeColor(ColorEnum.Black);
            Console.WriteLine($"Площадь прямоугольника: {rectangle.GetSquare()};");
            Console.WriteLine(rectangle.ToString());
            Console.WriteLine("--------------------------------------------------------------------------------------");
        }
    }
}

namespace Les6Ex2
{
    internal class Point : IFigure
    {
        double _x;
        double _y;
        ColorEnum _color;
        bool _isVisible;

        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }
        public ColorEnum Color { get => _color; set => _color = value; }
        public bool IsVisible { get => _isVisible; set => _isVisible = value; }

        public void ChangeColor(ColorEnum color)
        {
            _color = color;
        }

        public void ChangeVisible()
        {
            _isVisible = !_isVisible;
        }

        public void Move(int step, Direction direction)
        {
            if (direction == Direction.Horizontal)
            {
                _x += step;
            }
            else
            {
                _y += step;
            }
        }

        public override string ToString()
        {
            string isVisibleText = (_isVisible? "Нев" : "В") + "идимый";
            return $"Координаты фигуры: {_x}:{_y};\nЦвет: {_color};\n{isVisibleText}.";
        }
    }
}

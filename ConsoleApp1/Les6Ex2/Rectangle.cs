namespace Les6Ex2
{
    internal class Rectangle : Point
    {
        int _width;
        int _height;
        public int Width { get => _width; set => _width = value; }
        public int Height { get => _height; set => _height = value; }
        public double GetSquare()
        {
            return _width * _height;
        }
    }
}

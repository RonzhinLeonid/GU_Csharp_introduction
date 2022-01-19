namespace Les6Ex2
{
    internal interface IFigure
    {
        double X { get; set; }
        double Y { get; set; }
        ColorEnum Color { get; set; }
        bool IsVisible { get; set; }
        void Move(int step, Direction direction);
        void ChangeColor(ColorEnum color);
        void ChangeVisible();
    }
}

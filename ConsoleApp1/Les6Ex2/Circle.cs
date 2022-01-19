using System;

namespace Les6Ex2
{
    internal class Circle : Point
    {
        double _diametr;
        public double Diametr { get => _diametr; set => _diametr = value; }
        public double GetSquare()
        {
            return Math.PI * Math.Pow(_diametr/2, 2);
        }
    }
}

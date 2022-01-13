using System;

namespace Les5
{
    public class Complex
    {
        double _re;
        double _im;

        public double Re
        {
            get
            {
                return _re;
            }
        }
        public double Im
        {
            get 
            { 
                return _im;
            }
        }

        public Complex(double re, double im)
        {
            _re = re;
            _im = im;
        }
        public static Complex Sum(Complex x, Complex y)
        {
            return new Complex( 
                x.Re + y.Re,
                x.Im + y.Im);
        }

        public static Complex operator +(Complex x, Complex y)
        {
            return new Complex(
                x.Re + y.Re,
                x.Im + y.Im);
        }

        public static Complex Subtraction(Complex x, Complex y)
        {
            return new Complex(
                x.Re - y.Re,
                x.Im - y.Im);
        }

        public static Complex operator -(Complex x, Complex y)
        {
            return new Complex(
                x.Re - y.Re,
                x.Im - y.Im);
        }

        public static Complex Multi(Complex x, Complex y)
        {
            return new Complex(
                x.Re * y.Re - x.Im * y.Im,
                x.Im * y.Re + x.Re * y.Im);
        }
        public static Complex operator *(Complex x, Complex y)
        {
            return new Complex(
                x.Re * y.Re - x.Im * y.Im,
                x.Im * y.Re + x.Re * y.Im);
        }
        public static bool operator ==(Complex x, Complex y)
        {
            return !(x is null) && !(y is null) && x.Im == y.Im && x.Re == y.Re;
        }
        public static bool operator !=(Complex x, Complex y)
        {
            return !(x == y);
        }
        public override bool Equals(object? obj)
        {
            return obj is Complex complex && complex.Im == _im && complex.Re == _re;
        }
        protected bool Equals(Complex other)
        {
            return _im == other.Im && _re == other.Re;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Im, Re);
        }

        public override string ToString()
        {
            if (_im == 0) return $"{_re}";
            else if (_re == 0) return $"{_im}i";
            else return (_im < 0) ? $"{_re} - {-_im}i" : $"{_re} + {_im}i";
        }

    }
}

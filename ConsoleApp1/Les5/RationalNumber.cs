using System;

namespace Les5
{
    public class RationalNumber
    {
        int _numerator;
        int _denominator;

        /// <summary>
        /// Числитель
        /// </summary>
        public int Numerator 
        { 
            get
            {
                return _numerator;
            }
        }

        /// <summary>
        /// Знаменатель
        /// </summary>
        public int Denominator 
        { 
            get
            {
                return _denominator;
            }
        }

        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="numerator">Числитель</param>
        /// <param name="denominator">Знаменатель</param>
        public RationalNumber(int numerator, int denominator)
        {
            if (denominator == 0) throw new Exception("Деление числа на ноль не допускается");
            _numerator = numerator;
            _denominator = denominator;
            //перенос минуса в числитель из знаменателя
            if (_denominator < 0)
            {
                _numerator *= -1;
                _denominator *= -1;
            }
            ReductionRationalNumber();
        }

        public static bool operator ==(RationalNumber r1, RationalNumber r2)
        {
            return !(r1 is null) && !(r2 is null) && r1.Numerator == r2.Numerator && r1.Denominator == r2.Denominator;
        }

        public static bool operator !=(RationalNumber r1, RationalNumber r2)
        {
            return !(r1 == r2);
        }

        public static bool operator >(RationalNumber r1, RationalNumber r2)
        {
            return r1.Numerator * r2.Denominator > r1.Denominator * r2.Numerator;
        }

        public static bool operator <(RationalNumber r1, RationalNumber r2)
        {
            return r1.Numerator * r2.Denominator < r1.Denominator * r2.Numerator;
        }

        public static bool operator >=(RationalNumber r1, RationalNumber r2)
        {
            return !(r1 < r2);
        }

        public static bool operator <=(RationalNumber r1, RationalNumber r2)
        {
            return !(r1 > r2);
        }

        public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber(r1.Numerator * r2.Denominator + r2.Numerator * r1.Denominator, r1.Denominator * r2.Denominator);
        }

        public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber(r1.Numerator * r2.Denominator - r2.Numerator * r1.Denominator, r1.Denominator * r2.Denominator);
        }

        public static RationalNumber operator -(RationalNumber r)
        {
            return new RationalNumber(-r.Numerator, r.Denominator);
        }

        public static RationalNumber operator ++(RationalNumber r)
        {
            return new RationalNumber(r.Numerator + r.Denominator, r.Denominator);
        }

        public static RationalNumber operator --(RationalNumber r)
        {
            return new RationalNumber(r.Numerator - r.Denominator, r.Denominator);
        }

        public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber(r1.Numerator * r2.Numerator, r1.Denominator * r2.Denominator);
        }

        public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber(r1.Numerator * r2.Denominator, r1.Denominator * r2.Numerator);
        }

        public static RationalNumber operator %(RationalNumber r1, RationalNumber r2)
        {
            return new RationalNumber((r1.Numerator * r2.Denominator) % (r1.Denominator * r2.Numerator), r1.Denominator * r2.Denominator);
        }

        public static implicit operator float(RationalNumber r)
        {
            return (float)r.Numerator / r.Denominator;
        }

        public static implicit operator int(RationalNumber r)
        {
            return r.Numerator / r.Denominator;
        }

        public static explicit operator RationalNumber(int numerator)
        {
            return new RationalNumber(numerator, 1);
        }

        public override bool Equals(object? obj)
        {
            return obj is RationalNumber rationalNumber && rationalNumber.Numerator == _numerator && rationalNumber.Denominator == _denominator;
        }

        protected bool Equals(RationalNumber other)
        {
            return _numerator == other.Numerator && _denominator == other.Denominator;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Numerator, Denominator);
        }

        public override string ToString()
        {
            return $"{_numerator}/{_denominator}";
        }

        /// <summary>
        /// Наибольший общий делитель
        /// </summary>
        /// <param name="numerator"> Числитель</param>
        /// <param name="denominator">Знаменатель</param>
        /// <returns>Наибольший общий делитель</returns>
        private int Nod(int numerator, int denominator)
        {
            int temp = 0;

            numerator = Math.Abs(numerator);
            denominator = Math.Abs(denominator);

            if (denominator > numerator)
            {
                temp = numerator;
                numerator = denominator;
                denominator = temp;
            }
            do
            {
                temp = numerator % denominator;
                numerator = denominator;
                denominator = temp;
            } while (denominator != 0);

            return numerator;
        }
        /// <summary>
        /// Сокращение дроби 
        /// </summary>
        private void ReductionRationalNumber()
        {
            int nod = Nod(_numerator, _denominator);
            _numerator = _numerator / nod;
            _denominator = _denominator / nod;
        }
    }
}

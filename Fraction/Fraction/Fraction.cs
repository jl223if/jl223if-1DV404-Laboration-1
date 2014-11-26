using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    class Fraction
    {
        private int _numerator;
        private int _denominator;
        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public int GetNumerator()
        {
            return _numerator;
        }

        public int GetDenominator()
        {
            try
            {
                return _denominator;
            }
            catch (Exception ex)
            {
                Console.WriteLine("FEL");
            }
            
        }

        public bool IsNegative()
        {

            if (_numerator / _denominator < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Add(Fraction a, Fraction b)
        {
            _numerator = a.GetNumerator() * b.GetDenominator() + b.GetNumerator() * a.GetDenominator();
            _denominator = a.GetDenominator() * b.GetDenominator();
        }

        public void Multiply(Fraction a, Fraction b)
        {
            _numerator = a.GetNumerator() * b.GetNumerator();
            _denominator = a.GetDenominator() * b.GetDenominator();
        }

        public bool IsEqualTo(Fraction a, Fraction b)
        {
            if ((double)a._numerator / a._denominator == (double)b._numerator / b._denominator)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return (string.Format("{0} / {1} = {2:F2}", _numerator, _denominator , (double)_numerator / _denominator));
        }
    }
}

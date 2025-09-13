using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.WORK_2.Core
{
    public class Kite : Rhombus
    {
          private double _b;

        public Kite(string v, double a, double b, double d1, double d2) : base(v, a, d1, d2)
        {
            _b = ValidateB(b);

        }

        public double B

        {
            get
            {
                return _b;
            }

            set
            {
                _b = ValidateB(value);
            }
        }

        public double GetArea()

        {
            return D1 * D2 / 2;
        }

        public double GetPerimeter()
        {
            return 2 * (A + B);
        }

        private double ValidateB(double b)
        {
            if (b < 0)
            {
                throw new ArgumentException("El lado no puede ser negativo");
            }
            return b;
        }

        public override string ToString()
        {
            return ($"Kite        =>  Area.....: {GetArea():F5}     Perimeter: {GetPerimeter():F5}");
        }
    }
}

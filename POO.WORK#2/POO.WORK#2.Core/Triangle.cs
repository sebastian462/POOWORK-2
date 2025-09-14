using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.WORK_2.Core
{
    public class Triangle : Rectangle
    {
         private double _c;
         private double _h;

        public Triangle(string name, double c, double h, double b, double a ) : base(name, a, b)

        {    
            _c = ValidateC(c);
            _h = ValidateH(h);
        }

        public double C

        {
            get
            {
                return _c;
            }

            set
            {
                _c = ValidateC(value);
            }
        }

        public double H
        {
            get
            {
                return _h;
            }

            set
            {
                _h = ValidateH(value);
            }
        }

        public override double GetArea()
        {
            return (B * _h) / 2;
        }

        public override double GetPerimeter()
        {
            return A + B + _c;
        }

        private double ValidateC(double c)
        {
            if (c < 0)
            {
                throw new Exception("El lado no puede ser negativo");
            }
            return c;
        }

        private double ValidateH(double h)
        {
            if (h < 0)
            {
                throw new Exception("El lado no puede ser negativo");
            }
            return h;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.WORK_2.Core
{
    public class Trapeze : Triangle
    {
        private double _d;

        public Trapeze(string name, double a, double b, double c, double d, double h) : base(name, a, b, c, h)
        {
            _d = ValidateD(d);
         
           
        }

        public double D
        {

            get
            {
                return _d;
            }
            set
            {
                _d = ValidateD(value);
            }
        }

        public override double GetArea()
        {
            return ((B + _d) * H) / 2;
        }

        public override double GetPerimeter()
        {   
            
            return A + B + C + D;
        }

        private double ValidateD(double d)
        {
            if (d < 0)
            {
                throw new Exception("El lado d no puede ser negativo");
            }
            return d;
        }

    }
}

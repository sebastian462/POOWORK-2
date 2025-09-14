using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace POO.WORK_2.Core
{
    public class Rectangle : Square
    {

        private double _b;

        public Rectangle (String name, double a, double b) : base(name, a)
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
            
        public override double GetArea()
        {
            return A * _b;
        }

        public override double GetPerimeter()
        {
          return  2 * (A + _b);
        }

        private double ValidateB(double b)
        {
            if (b < 0)
            {
                throw new ArgumentException("El lado no puede ser negativo");
            }
            return b;
        }



    }
}

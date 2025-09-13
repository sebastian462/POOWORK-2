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

        public Rectangle (String v, double a, double b) : base(v, a)
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
            return A * _b;
        }

        public double GetPerimeter()
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

        public override string ToString()
        {
            return ($"Rectangle   =>  Area.....: {GetArea():F5}    Perimeter: {GetPerimeter():F5}");
        }
        



    }
}

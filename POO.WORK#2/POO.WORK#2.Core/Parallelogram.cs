using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.WORK_2.Core
{
    public class Parallelogram : Rectangle
    {

        private double _h;

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            _h = ValidateH(h);
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

            return B * _h;
        }

        public override double GetPerimeter()
        {
            return 2 * (A + B);
        }

        private double ValidateH(double h)
        {
            if (h < 0)
            {
                throw new Exception("La altura no puede ser negativa");
            }
            return h;
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.WORK_2.Core
{
    public class Circle : GeometricFigure
    {
        private double _r;

        public Circle(string name, double r) : base(name)
        {
            Name = name;
            _r = ValidateR(r);
        }

        private double R
        {
            get
            {
                return _r;
            }
            set
            {
                _r = ValidateR(value);
            }
        }
       
        public override double GetArea()
        {
            return Math.PI * _r * _r;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * _r;
        }

        private double ValidateR(double r)
        {
            if (r < 0)
            {
                throw new Exception("El radio no puede ser negativo");
            }
            return r;
        }
    }
}

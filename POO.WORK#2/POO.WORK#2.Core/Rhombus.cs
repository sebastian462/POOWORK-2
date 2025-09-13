using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace POO.WORK_2.Core
{
    public class Rhombus : Square
    {
            private double _d1;
            private double _d2;

        public Rhombus(string v, double a, double d1, double d2) : base(v, a)
        {
            _d1 = ValidateD1(d1);
            _d2 = ValidateD2(d2);
        }

        public double D1
        {
            get
            {
                return _d1;
            }

            set
            {
                _d1 = ValidateD1(value);
            }
        }

        public double D2
        {

            get
            {
                return _d2;
            }

            set
            {
                _d2 = ValidateD2(value);
            }        

        }

        public double GetArea()

        {
            return (_d1 * _d2) / 2;
        }

        public double GetPerimeter()

        {
            return 4 * A;
        }

        private double ValidateD1(double d1)
        {
            if (d1 < 0)
            {
                throw new Exception("La Diagonal D1, no puede ser negativa");
            }
            return d1;
        }

        private double ValidateD2(double d2)
        {
            if (d2 < 0)
            {
                throw new Exception("La Diagonal D2, no puede ser negativa");
            }
            return d2;
        }

        public override string ToString()

        {
            return ($"Rhombus     =>  Area.....: {GetArea():F5}     Perimeter: {GetPerimeter():F5}");
        }




    }
}


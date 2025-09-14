using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.WORK_2.Core
{
    public abstract class GeometricFigure
    {
        protected GeometricFigure(string name)
        {
            Name = name;
        }

        public string Name { get; set; } = null!; 

        public abstract double GetArea();
        public abstract double GetPerimeter();

        public override string ToString()
        {
            return ($"{Name,-14}   =>   Area.....: {GetArea(),20:N5}     Perimeter: {GetPerimeter(),20:N5}");
        }

    }
}



namespace POO.WORK_2.Core;

public class Square : GeometricFigure
{    
    private double _a;

    public Square(string name, double a)  : base(name)
    {    
        Name = name;
        _a = ValidateA(a); 
    }
    public double A
    {
        get
        {
            return _a;
        }
        set
        {
            _a = ValidateA(value);
        }
    }


    public override double GetArea()
    {
        return _a * _a;
    }


    public override double GetPerimeter()
    {
        return 4 * _a;
    }


    private double ValidateA(double a)
    {
        if (a < 0)
        {
            throw new Exception("El lado no puede ser negativo");
        }
        return a;

    }
}



namespace POO.WORK_2.Core;

public class Square
{
    private double _a;


    public  Square(string v, double a)
    {
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


    public double GetArea()
    {
        return _a * _a;
    }


    public double GetPerimeter()
    {
        return 4 * _a;
    }


    private double ValidateA(double a)
    {
        if (a < 0)
        {
            throw new ArgumentException("El lado no puede ser negativo");
        }
        return a;

    }

    public override string ToString()
    {
        return $"Square      =>  Área.....: {GetArea():F5}    Perímetro: {GetPerimeter():F5}";
    }




}



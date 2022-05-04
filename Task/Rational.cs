namespace Task;

public class Rational
{
    private int _up, _down;
    public int Up
    {
        get => _up;
        set => _up = value;
    }
    public int Down {
        get => _down;
        set => _down = value==0?1:value;
    }
    public Rational(int up, int down=1)
    {
        Up = up;
        Down = down;

    }
    

    public string toString()
    {
        return this? (Up + " / " + Down):"FALSE";
    }

    public int GetGcd()
    {
        int rem,a=Up,b=Down;
    
        while( b != 0 )
        {
            rem = a % b;
            a = b;
            b = rem;
        }
      
        return a;
    }

    public bool Normalize()
    {
        int rem = GetGcd();
        if (rem != 1)
        {
           _up /= rem;
           _down /= rem;
           return true;
        }

        return false;

    }

    
    //перегрузки операторов
    public static Rational operator+(Rational lhs,Rational rhs)
    {
        Rational a = new Rational(lhs._up*rhs._down + rhs._up*lhs._down, lhs._down * rhs._down);
        return a;
    }
    public static Rational operator+(Rational lhs,int rhs)
    {
        Rational a = new Rational(lhs._up + rhs, lhs._down);
        return a;
    }
    public static Rational operator-(Rational lhs,Rational rhs)
    {
        Rational a = new Rational(lhs._up*rhs._down - rhs._up*lhs._down, lhs._down * rhs._down);
        return a;
    }
    public static Rational operator-(Rational lhs,int rhs)
    {
        Rational a = new Rational(lhs._up - rhs, lhs._down);
        return a;
    }

    public static Rational operator *(Rational lhs, Rational rhs)
    {
        Rational a = new Rational(lhs._up * rhs._up, lhs._down * rhs._down);
        return a;
    }
    public static Rational operator *(Rational lhs, int rhs)
    {
        Rational a = new Rational(lhs._up * rhs, lhs._down );
        return a;
    }
    public static Rational operator /(Rational lhs, Rational rhs)
    {
        Rational a = new Rational(lhs._up * rhs._down, lhs._down * rhs._up);
        return a;
    }
    public static Rational operator /(Rational lhs, int rhs)
    {
        Rational a = new Rational(lhs._up, lhs._down *rhs);
        return a;
    }

    public static Rational operator ++(Rational a)
    {
        a._up++;
        a._down++;
        a.Normalize();
        return a;
    }
    public static Rational operator --(Rational a)
    {
        a._up--;
        a._down--;
        a.Normalize();
        return a;
    }

    public static bool operator ==(Rational lhs, Rational rhs)
    {

        return (lhs._up == rhs._up) && (lhs._down == rhs._down);
    }
    public static bool operator !=(Rational lhs, Rational rhs)
    {

        return (lhs._up != rhs._up) || (lhs._down != rhs._down);
    }

    public static bool operator >(Rational lhs, Rational rhs)
    {
        double l = 1.0*lhs._up / lhs._down;
        double r = 1.0*rhs._up / rhs._down;
        return l > r;
    }
    public static bool operator <(Rational lhs, Rational rhs)
    {
        double l = 1.0*lhs._up / lhs._down;
        double r = 1.0*rhs._up / rhs._down;
        return l < r;
    }
    public static bool operator true(Rational r)
    {
        return r._up != 0;
    }
    public static bool operator false(Rational r)
    {
        return r._up == 0;
    }

    //перегрузка преобразований типов
    public static implicit operator Rational(int a)
    {
        return new Rational(a);
    }
    public static explicit operator int(Rational a)
    {
        return a._up / a._down;
    }
    
}
class Fraction
{
    private double _topNumber;
    private double _bottomNumber;

    public Fraction()
    {
        _topNumber = 1;
        _bottomNumber = 1;
    }

    public Fraction(double topNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = 1;
    }

    public Fraction(double topNumber, double bottomNumber)
    {
        _topNumber = topNumber;
        _bottomNumber = bottomNumber;
    }

    public double GetTopNumber()
    {
        return _topNumber;
    }

    public double GetBottomNumber()
    {
        return _bottomNumber;
    }

    public void SetTopNumber(double newNumber)
    {
        _topNumber = newNumber;
    }
    public void SetBottomNumber(double newNumber)
    {
        _bottomNumber = newNumber;
    }

    public string GetFractionString()
    {
        string fractionString = _topNumber + "/" + _bottomNumber;
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double decimalValue = _topNumber / _bottomNumber;
        return decimalValue;
    }
}
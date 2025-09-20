using System;
using System.Numerics;

public class Fractions
{
    private int _numerator;
    private int _denominator;

    public Fractions()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fractions(int numerator)
    {
        _numerator = numerator;
        _denominator = 1;
    }

    public Fractions(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }
    public int getNumerator()
    {
        return _numerator;
    }
    public void setNumerator(int numerator)
    {
        _numerator = numerator;
    }

    public int getDenominator()
    {
        return _denominator;
    }

    public void setDenominator(int denominator)
    {
        _denominator = denominator;
    }
    public string GetFractionString()
    {
        return $"{_numerator}/{_denominator}";
    }
    public double GetDecimalValue()
    {
        return (double)_numerator / _denominator;
    }
}

using Desafio.Exceptions;

namespace Desafio.Inputs.Math;

public class Calculator
{
    private double value1, value2;

    public Calculator() { }
    public Calculator(double _value1, double _value2)
    {
        value1 = _value1;
        value2 = _value2;
    }
    public double Sum(double n1, double n2)
    {
        return n1 + n2;
    }
    public double Subtraction(double n1, double n2)
    {
        return n1 - n2;
    }
    public double Multiply(double n1, double n2)
    {
        return n1 * n2;
    }
    public double Divide(double n1, double n2)
    {
        MultiplyValidation(n2);
        return n1 / n2;
    }
    public double Average(double n1, double n2)
    {
        MultiplyValidation(n2);
        var sum = n1 + n2;
        double average = sum / 2;
        return average;


    }

    public void MultiplyValidation(double number)
    {
        if (number == 0)
        {
            throw new CalculatorException("-----ERRO AO DIVIDIR! DENOMINADOR NAO PODE SER ZERO!-----");
        }
    }

}
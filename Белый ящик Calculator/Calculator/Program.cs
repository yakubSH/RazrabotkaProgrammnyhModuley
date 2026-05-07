using System;

class Program
{
    static void Main(string[] args)
    {
    }
}
public class Calculator
{
    // Делит два числа
    public int Divide(int a, int b)
    {
        if (b == 0)
        {
            throw new DivideByZeroException("Нельзя делить на ноль");
        }
        return a / b;
    }

    // Проверяет, положительное ли число
    public string CheckNumber(int number)
    {
        if (number > 0)
        {
            return "Положительное";
        }
        else if (number < 0)
        {
            return "Отрицательное";
        }
        else
        {
            return "Ноль";
        }
    }
}
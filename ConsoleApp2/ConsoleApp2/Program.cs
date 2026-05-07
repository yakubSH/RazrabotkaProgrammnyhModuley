using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Calculator
    {
        public int Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Нельзя делить на ноль");
            }
            return a / b;
        }
        public string CheckNumber(int number)
        {
            if(number > 0)
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
}

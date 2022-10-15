using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsClassLibrary
{
    public class Operations
    {
        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        public static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        public static double Divide(double number1, double number2)
        {
            double answer;

            if (number2 == 0)
            {
                answer = -1;
            }
            else
            {
                answer = number1 / number2;
            }
            return answer;
        }
    }
}

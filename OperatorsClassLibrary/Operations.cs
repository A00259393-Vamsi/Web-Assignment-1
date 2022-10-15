using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsClassLibrary
{
    public class Operations
    {
        /*
         * Below static method is used to add two numbers based on the given input parameters
         * @param number1 double, number 2 double
         * @return result double 
         */
        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }

        /*
         * Below static method is used to subtract two numbers based on the given input parameters
         * @param number1 double, number 2 double
         * @return result double 
         */
        public static double Subtract(double number1, double number2)
        {
            return number1 - number2;
        }

        /*
         * Below static method is used to multiply two numbers based on the given input parameters
         * @param number1 double, number 2 double
         * @return result double 
         */
        public static double Multiply(double number1, double number2)
        {
            return number1 * number2;
        }

        /*
         * Below static method is used to divide two numbers based on the given input parameters
         * @param number1 double, number 2 double
         * @return result double 
         */
        public static double Divide(double number1, double number2)
        {
            double answer;

            // if second number is zero, division is not possible so sending the response as -1
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

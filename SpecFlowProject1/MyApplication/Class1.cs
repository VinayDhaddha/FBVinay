using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication
{
    public class Calculator
    {
        public int AddNumber(int num1,int num2)
        {
            return num1 + num2;
        }
        public int Substract(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Divide(int num1, int num2)
        {
            if (num1 == 0 || num2 == 0)
                return 0;
            return num1 / num2;
        }
    }
}

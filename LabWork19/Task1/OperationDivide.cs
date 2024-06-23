using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task1
{
    public class OperationDivide : IStrategy
    {
        public int DoOperation(int number1, int number2) => number1 / number2;
    }
}
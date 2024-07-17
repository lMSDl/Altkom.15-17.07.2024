using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Calculator
    {
        private double _initialValue;

        public Calculator() : this(0)
        {
        }

        public Calculator(double initialValue)
        {
            Result = _initialValue = initialValue;
        }

        public double Result { get; private set; }
        public int OperationCounter { get; private set; }

        public void Add(double value)
        {
            Result += value;
            IncreaseOperationCounter();
        }

        public void Substract(double value)
        {
            Result -= value;
            IncreaseOperationCounter();
        }
        public void Multiply(double value)
        {
            Result = Result * value;
            IncreaseOperationCounter();
        }
        public void Divide(double value)
        {
            Result = Result / value;
            IncreaseOperationCounter();
        }

        private void IncreaseOperationCounter()
        {
            OperationCounter++;
        }

        public void Clear()
        {
            Result = _initialValue;
            OperationCounter = 0;
        }
    }
}

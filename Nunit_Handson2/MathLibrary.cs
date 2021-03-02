using System;

namespace CalcLibrary
{
    interface IMathLibrary
    {
        int Addition(int a, int b);
        int Subtraction(int a, int b);
        int Multiplication(int a, int b);
        int Division(int a, int b);
    }

    public class SimpleCalculator : IMathLibrary
    {
        int result = 0;
        public int Addition(int a, int b)
        {
            result = a + b;
            return result;
        }

        public int Subtraction(int a, int b)
        {
            result = a - b;
            return result;
        }

        public int Multiplication(int a, int b)
        {
            result = a * b;
            return result;
        }

        public int Division(int a, int b)
        {
            if (b == 0)
                throw new ArgumentException("Second Parameter Can't be Zero");
            result = a / b;
            return result;
        }

        public void AllClear()
        {
            result = 0;
        }

        public int GetResult
        {
            get { return result; }            
        }
    }
}

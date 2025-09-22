using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L15Work
{
    interface ISeries
    {
        void SetStart(int x);
        int GetNext();
        void Reset();
    }
    class ArithProgression : ISeries
    {
        int coef;
        int firstNumber;
        int currentNumber;

        public int GetNext()
        {
            return currentNumber += coef;
        }

        public void Reset()
        {
            currentNumber = firstNumber;
        }

        public void SetStart(int x)
        {
            firstNumber = x;
            currentNumber = firstNumber;
        }
        public void SetStep(int c)
        {
            coef = c;
        }
    }
    class GeomProgression : ISeries
    {
        int coef;
        int firstNumber;
        int currentNumber;

        public int GetNext()
        {
            return currentNumber *= coef;
        }

        public void Reset()
        {
            currentNumber = firstNumber;
        }

        public void SetStart(int x)
        {
            firstNumber = x;
            currentNumber = firstNumber;
        }
        public void SetStep(int c)
        {
            coef = c;
        }
    }
}

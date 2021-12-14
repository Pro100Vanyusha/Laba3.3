using System;

namespace Laba3._3
{
    class TrueFraction
    {
        public int numerator;
        public int Numerator
        {
            get { return numerator; }
            set { numerator = value; }
        }
        public int denominator;
        public int Denominator
        {
            get { return denominator; }
            set { denominator = value; }
        }
        public TrueFraction(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }
        
        public void Percent(int numerator, int denominator)
        {

        }
        
        
    }


    class MixedFraction : TrueFraction
    {
        public int wholepart;
        public int WholePart
        {
            get { return wholepart; }
            set { wholepart = value; }
              
        }

        
        public MixedFraction(int wholepart,int mfnumerator, int mfdenominator)
        {
            this.wholepart = wholepart;
            this.mfnumerator = mfnumerator;
            this.mfdenominator = mfdenominator;
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
        }
    }
}

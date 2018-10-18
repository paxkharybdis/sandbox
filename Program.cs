using System;
using System.Text;


namespace Sandbox
{
    class Program
    {


        public delegate int TheMagicNumber(int _magicNumber);
        public int _magicNumber { get; set; }

        static void Main(string[] args)
        {
            DelegateSample();
        }


        private static int DelegateSample()
        {

            DelegateExample delegateExample = new DelegateExample();
            DelegateExample.TheMagicNumber theMagicNumber = new DelegateExample.TheMagicNumber(delegateExample.TheLuckyNumber());
            int result = theMagicNumber(7777);
            Console.WriteLine("Your Lucky Number is " + result + ".");
            return result;
        }





    }


}


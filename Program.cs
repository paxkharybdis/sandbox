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
            Console.WriteLine("Enter your favorite number, and I'll tell you what your lucky number is:");
            var userInput = Console.ReadLine();
            if (int.TryParse(userInput, out int number1))
            {

                DelegateExample delegateExample = new DelegateExample();
                DelegateExample.TheMagicNumber theMagicNumber = new DelegateExample.TheMagicNumber(delegateExample.TheLuckyNumber());
                int result = theMagicNumber(number1);
                Console.WriteLine("Your Lucky Number is " + result + ".");
                return result;
            }
            else
            {
                Console.WriteLine("Sorry, {0} is not a number,  I guess you are just unlucky.", userInput);
                return number1;
            }
        }


    }

}


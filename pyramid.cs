using System;

namespace Sandbox
{
    public class pyramid
    {
        public int inputNum;
        static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }

            // static void Main(string[] args)
            public void PyramidInput()
            {
            int inputNum;
            Console.WriteLine("Please enter a number.");
            String numInput = Console.ReadLine();

            while(!Int32.TryParse(numInput, out inputNum))
            {
                Console.WriteLine("Not a valid number, try again.");

                numInput = Console.ReadLine();
            } 

            DrawPyramid(inputNum);
            }
    } 
}
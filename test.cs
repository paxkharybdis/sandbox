using System;
using System.Text;

/*namespace Sandbox
{
    public class test
    {
        static void Main(string[] args)
        {
       

        #region Joining Strings

        

        public void JoinStringsWithBuilder()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(_testString)
            .Append(_testString2)
            .Append(" and super cool.");

            // In order to use the builder, you have to call the ToString method so it converts.
            Console.WriteLine(builder.ToString());
        }

        #endregion

        #region Placeholders and compare strings
        public void PlaceholderString()
        {
            string sampleFour = "forth";
            // This is a third Test String
            Console.WriteLine("This is a third {0}", _testString);
            Console.WriteLine("This {0} is {2} the {1}", _testString, sampleFour, 35);
        }

        public void CompareStrings()
        {
            string ab = "Test String";
            Console.WriteLine(_testString == ab);

        }

        #endregion

        #region Char
        public void CharType()
        {
            char ab = 'A';
            char de = 'B';
            char copyWriteSymbol = '\u00A9';

            Console.WriteLine(ab == de); // False
            Console.WriteLine("The copywrite symbol looks like {0}", copyWriteSymbol);
        }

        #endregion

        #region Arrays

        public void ArraySingleSample()
        {
            string[] cars = new string[3];
            cars[0] = "camaro";
            cars[1] = "mustang";
            cars[2] = "chevelle";

            //or

            string[] names = { "Tom", "Roger", "Matt" };

            Console.WriteLine(cars[1]);
            Console.WriteLine(names[1]);
        }

        public void ArrayRectangularSample()
        {
            int[,] sampleInt = new int[2, 2];
            sampleInt[0, 0] = 5;
            sampleInt[0, 1] = 10;
            sampleInt[1, 0] = 2;
            sampleInt[1, 1] = 4;

            Console.WriteLine(sampleInt[1, 0]);
        }

        public void ArrayJaggedSample()
        {
            int[][] sampleJagged = new int[2][];
            sampleJagged[0] = new int[] { 2, 3, 4 };
            sampleJagged[1] = new int[] { 5, 6 };

            //or

            int[][] secondSample = new int[][]
            {
                    new int[] { 1, 2, 3, 4, 5 },
                    new int[] { 6, 7, 8, 9 },
                    new int[] { 10, 11, 12 }
            };
        }

        #endregion

        #region Enums

        // Enum declaration with default values
        private enum Position { Left, Right, Top, Bottom };

        // Enum declaration with defined values
        private enum MovieType { Action = 100, Comedy = 200, Drama = 200 };

        // Enum declaration with mixed defined and non-defined values
        private enum Days { Sun, Mon = 8, Tue = 9, Wed = 10, Thur, Fri, Sat };

        
        public void EnumSample()
        {
            Console.WriteLine("Value for days not set is {0}", Days.Thur);
            Console.WriteLine("Favorite type of movie value is {0}", MovieType.Action);
        }
        #endregion
        } 
    } */

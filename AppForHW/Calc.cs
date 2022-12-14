using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppForHW
{
    internal class Calc : ISum, INumberInput
    {
        public int Result;
        public Calc()
        {
            var color = new Logger();
            Result = Sum(Input(color), Input(color));
            Print();

        }

        public int Input(Logger color)
        {
            color.Blue();
            Console.WriteLine("\nEnter a number for sum :");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > 0) { return number; }
                else if (number <= 0) { throw new FormatException("do not enter 0"); }
            }
            catch (Exception e) { color.Red(); Console.WriteLine(e.Message); }
            return Input(color);
        }

        public int Sum(int a, int b) => a + b;

        private void Print() => Console.WriteLine("\nSum is :" + Result);

    }
}

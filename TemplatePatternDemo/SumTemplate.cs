using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternDemo
{
    public class SumTemplate : AbstractTemplate
    {
        private int firstNumber, secondNumber, result;
        protected override void DoCalculations()
        {
            result = firstNumber + secondNumber;
        }

        protected override void GetData()
        {
            Console.WriteLine("Enter first number");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            secondNumber = int.Parse(Console.ReadLine());

        }

        protected override void PrintResults()
        {
            Console.WriteLine("Sum is {0}", result);
        }
    }
}

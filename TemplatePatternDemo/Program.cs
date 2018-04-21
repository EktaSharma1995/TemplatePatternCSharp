using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractTemplate s = new SumTemplate();
            s.TemplateMethod();

            s = new ProductTemplate();
            s.TemplateMethod();

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
        }
    }
}

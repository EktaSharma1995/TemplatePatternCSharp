using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplatePatternDemo
{
    public abstract class AbstractTemplate
    {
        public void TemplateMethod()
        {
            GetData();
            DoCalculations();
            PrintResults();
        }

        protected abstract void GetData();
        protected abstract void DoCalculations();
        protected abstract void PrintResults();

    }
}

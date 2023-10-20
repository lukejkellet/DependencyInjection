using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal interface ICalculator
    {
        void Add(int a, int b);
        void Subtract(int a, int b);
    }
}

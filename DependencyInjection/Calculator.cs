using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Calculator : ICalculator
    {
        private readonly ILog _log;
        private readonly IMessage _mess;

        public Calculator() { }
        public Calculator(ILog log, IMessage message)
        {
            _log = log;
            _mess = message;
        }
        void ICalculator.Add(int a, int b)
        {
            int sum = (a + b);
            string str = _mess.SendMessage($"{a} and {b} have been added successfully to {sum}");
            _log.LogMess($"{str}");
        }
        void ICalculator.Subtract(int a, int b)
        {
            int diff = (a - b);
            string str = _mess.SendMessage($"{a} and {b} have been subtracted successfully to {diff}");
            _log.LogMess($"{str}");
        }
    }
}

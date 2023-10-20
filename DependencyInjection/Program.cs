using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dependency injection example");
            Console.WriteLine("----------------------------");

            //Create the container
            var containerBuilder = new ContainerBuilder();

            //Register Services offered by the container
            containerBuilder.RegisterType<Message>().As<IMessage>().SingleInstance();
            containerBuilder.RegisterType<Log>().As<ILog>().SingleInstance();
            containerBuilder.RegisterType<Calculator>().As<ICalculator>().SingleInstance();

            //Build the container
            var container = containerBuilder.Build();

            Console.WriteLine("Container has been built");

            //Resolve services
            var calc = container.Resolve<ICalculator>();

            //Start Program
            int a = 0, b = 0;
            Console.WriteLine("Enter two numbers to add and subtract");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            calc.Add(a, b);
            calc.Subtract(a, b);
            Console.WriteLine("done");
            Console.ReadLine();
        }
    }
}

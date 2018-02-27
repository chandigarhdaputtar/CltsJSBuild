using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CltsJsBuild
{
    class Program
    {
        static void Main(string[] args)
        {
            var argument = Console.ReadLine();
            while (!string.IsNullOrEmpty(argument) || string.Compare("exit", argument, StringComparison.InvariantCultureIgnoreCase) != 0)
            {
                Func<string> Runner = () =>
                {
                    //Run();
                    return null;
                };
            }
        }
    }
}

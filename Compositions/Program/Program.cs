using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compositions;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Creator.CreateAssembly();
            Printer.Print(assembly);
        }
    }
}

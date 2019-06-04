using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compositions;

namespace Program
{
    public class Printer
    {
        public static void Print(Assembly assembly)
        {
            for (int i = 0; i < assembly.GetCompositionsCount(); i++)
            {
                Console.WriteLine((i + 1).ToString() + ". " + assembly.GetCurrentComposition(i).GetName() + " – " + assembly.GetCurrentComposition(i).LengthToMinutes());
            }
            Console.WriteLine("Overall Length – " + assembly.LengthToMinutes());
        }
    }
}

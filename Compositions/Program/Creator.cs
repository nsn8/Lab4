using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Compositions;

namespace Program
{
    class Creator
    {
        public static Assembly CreateAssembly()
        {
            OnePartComposition firstComposition = new OnePartComposition("Beautiful composition name");
            firstComposition.SetLength(200);
            MultiPartComposition secondComposition = new MultiPartComposition("Awesome name of composition");
            secondComposition.SetPartsCount(3);
            secondComposition.SetPartLength(60);
            secondComposition.SetLength(0);
            DiffMultiPartComposition thirdComposition = new DiffMultiPartComposition("Another magnificent one");
            thirdComposition.SetPartsCount(2);
            thirdComposition.SetPartLength(0, 100);
            thirdComposition.SetPartLength(1, 40);
            thirdComposition.SetLength(0);
            Assembly assembly = new Assembly("The best Assembly ever");
            assembly.PushComposition(firstComposition);
            assembly.PushComposition(secondComposition);
            assembly.PushComposition(thirdComposition);
            return assembly;
        }
    }
}

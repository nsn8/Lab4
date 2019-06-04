using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositions
{
    public class OnePartComposition : AbstractComposition
    {
        public OnePartComposition() : base() { }

        public OnePartComposition(string name) : base(name)
        {
            SetName(name);
        }

        public override void SetLength(int length)
        {
            _length = length;
        }
    }
}

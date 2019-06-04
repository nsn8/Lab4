using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositions
{
    public class DiffMultiPartComposition : MultiPartComposition
    {
        private int[] _partsLengths;

        public DiffMultiPartComposition() : base() { }

        public DiffMultiPartComposition(string name) : base(name)
        {
            SetName(name);
        }

        public void SetPartsLengths(int[] partsLengths)
        {
            _partsLengths = partsLengths;
        }

        public void SetPartLength(int index, int length)
        {
            _partsLengths[index] = length;
        }

        public int[] GetPartsLengths()
        {
            return _partsLengths;
        }

        public int GetPartLength(int index)
        {
            return _partsLengths[index]; 
        }

        public override void SetLength(int length)
        {
            _length = 0;
            for (int i = 0; i < GetPartsCount(); i++)
                _length += GetPartLength(i);
        }
    }
}

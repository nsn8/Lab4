using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositions
{
    public class MultiPartComposition : AbstractComposition
    {
        private int _partsCount;
        private int _partLength;

        public MultiPartComposition() : base() { }

        public MultiPartComposition(string name) : base(name)
        {
            SetName(name);
        }

        public void SetPartsCount(int partsCount)
        {
            _partsCount = partsCount;
        }

        public int GetPartsCount()
        {
            return _partsCount;
        }

        public void SetPartLength(int partLength)
        {
            _partLength = partLength;
        }

        public int GetPartLength()
        {
            return _partLength;
        }

        public override void SetLength(int length)
        {
            _length = _partsCount * _partLength;
        }
    }
}

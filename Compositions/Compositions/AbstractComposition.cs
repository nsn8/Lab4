using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositions
{
    public abstract class AbstractComposition
    {
        protected int _length;
        private string _name;

        public AbstractComposition() { }

        public AbstractComposition(string name)
        {
            _name = name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public abstract void SetLength(int length = 0);

        public int GetLength()
        {
            return _length;
        }

        public string LengthToMinutes()
        {
            int minutes = 0;
            int bufferLength = _length;
            while (bufferLength > 60)
            {
                bufferLength -= 60;
                minutes++;
            }
            string length = minutes.ToString() + ":" + bufferLength.ToString();
            return length;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compositions
{
    public class Assembly
    {
        private int _overallLength;
        private string _name;
        private List<AbstractComposition> _compositionsList;
        private int _compositionsCount = 0;

        public Assembly() { }

        public Assembly(string name)
        {
            SetName(name);
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            return _name;
        }

        public void SetCompositionsCount(int compositionsCount)
        {
            _compositionsCount = compositionsCount;
        }

        public int GetCompositionsCount()
        {
            return _compositionsCount;
        }

        public void CountOverallLength()
        {
            for (int i = 0; i < GetCompositionsCount(); i++)
                _overallLength += _compositionsList[i].GetLength();
        }

        public int GetOverallLength()
        {
            return _overallLength;
        }

        public void PushComposition(AbstractComposition composition)
        {
            _compositionsList.Add(composition);
            _compositionsCount++;
            CountOverallLength();
        }

        public void PushComposition(int index, AbstractComposition composition)
        {
            _compositionsList.Insert(index, composition);
            _compositionsCount++;
            CountOverallLength();
        }

        public void PopComposition()
        {
            _compositionsList.RemoveAt(GetCompositionsCount() - 1);
            _compositionsCount--;
            CountOverallLength();
        }

        public void PopComposition(int index)
        {
            _compositionsList.RemoveAt(index);
            _compositionsCount--;
            CountOverallLength();
        }

        public AbstractComposition GetCurrentComposition(int index)
        {
            return _compositionsList[index];
        }

        public string LengthToMinutes()
        {
            int minutes = 0;
            int bufferLength = _overallLength;
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

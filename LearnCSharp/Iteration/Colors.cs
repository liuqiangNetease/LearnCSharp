using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iteration
{
    class Colors: IEnumerable
    {
        class ColorEnumerator : IEnumerator
        {
            string[] _colors;
            int _pos = -1;

            public ColorEnumerator(string[] theColors)
            {
                _colors = new string[theColors.Length];
                for (int i = 0; i < theColors.Length; i++)
                    _colors[i] = theColors[i];
            }
            public object Current
            {
                get
                {
                    if (_pos == -1 || _pos >= _colors.Length)
                        throw new InvalidOperationException();

                    return _colors[_pos];

                }
            }
            public bool MoveNext()
            {
                if(_pos < _colors.Length -1)
                {
                    _pos++;
                    return true;
                }
                return false;
            }
            public void Reset()
            {
                _pos = -1;
            }
        }


        string[] colors = { "Red", "green", "blue" };
        public IEnumerator GetEnumerator()
        {
            return new ColorEnumerator(colors);
        }
    }
}

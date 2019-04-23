using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iteration
{
    class ColorSet
    {
        public IEnumerator<string> ColorIteration()
        {
            string[] theColors = { "red", "green", "blue" };
            for (int i = 0; i < theColors.Length; i++)
                yield return theColors[i];
        }

        public IEnumerator<string> GetEnumerator()
        {
            return ColorIteration();
        }
    }
}

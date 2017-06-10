using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Analyzer_of_Keystroke_Dynamics
{
    class Analysis
    {
        private readonly List<KeyStroke> _ks;
        public Analysis(List<KeyStroke> _ks)
        {
            this._ks = _ks;
        }
        public List<TimeSpan> CalculateIntervals()
        {
            List<TimeSpan> Intervals = new List<TimeSpan>();
            for (int i = 0; i < _ks.Count-1; i++)
            {
                Intervals.Add(_ks[i + 1].Pressed - _ks[i].Released);
            }
            return Intervals;
        }

       /* private bool IsCorrect(string input)
        {
            if (Main.Input_richTextBox)
            {

            }
        }*/

        public void Compare() //void?
        {
          //  for (int i = 0; i < length; i++)
            {

            }
        }
    }
}

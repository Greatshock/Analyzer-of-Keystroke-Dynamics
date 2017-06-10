using System;
using System.Windows.Forms;

namespace CSharp_Analyzer_of_Keystroke_Dynamics
{
    /// <summary>
    /// Performs the information about pressing and releasing time of the key
    /// </summary>
    class KeyStroke
    {
        public Keys Key;
        public TimeSpan Pressed; //Time when the key was pressed
        public TimeSpan Released; //Time when the key was released
        public TimeSpan PressTime //Duration of pressing the key
        {
            get { return Released - Pressed; }
        }
    }
}

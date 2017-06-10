using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace CSharp_Analyzer_of_Keystroke_Dynamics
{
    /// <summary>
    /// Records keys being pressed and released
    /// </summary>
    class KeyStrokeRecorder
    {
        /// <summary>
        /// Tracks the time
        /// </summary>
        private readonly Stopwatch _sw = new Stopwatch();
        /// <summary>
        /// Contains user pressed keys and corresponding press (release) time
        /// </summary>
        private readonly Dictionary<Keys, KeyStroke> _dict = new Dictionary<Keys, KeyStroke>();
        public List<KeyStroke> KeyStrokes { get; set; }
        public KeyStrokeRecorder()
        {
            KeyStrokes = new List<KeyStroke>();
        }

        /// <summary>
        /// Returns true if the key hase been already pressed. Returns false if the key has not been pressed yet.
        /// </summary>
        /// <param name="k">Key</param>
        /// <returns></returns>
        public bool IsKeyPressed(Keys k)
        {
            return _dict.ContainsKey(k);
        }

        /// <summary>
        /// Adds pressed key in dictionary of the pressed keys
        /// </summary>
        /// <param name="k">Key</param>
        public void KeyPressed(Keys k)
        {
            _dict.Add(k, new KeyStroke { Pressed = _sw.Elapsed, Key = k });
        }

        /// <summary>
        /// Removes released key from the dictionary of the pressed keys
        /// </summary>
        /// <param name="k"></param>
        public void KeyReleased(Keys k)
        {
            var ks = _dict[k];
            _dict.Remove(k);
            ks.Released = _sw.Elapsed;
            KeyStrokes.Add(ks);
        }

        /// <summary>
        /// Starts the stopwatch
        /// </summary>
        public void Start()
        {
            _sw.Restart();
        }

        /// <summary>
        /// Stops the stopwatch
        /// </summary>
        public void Stop()
        {
            _sw.Stop();
        }
    }
}

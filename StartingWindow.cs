using System.Windows.Forms;
using System.Collections.Generic;
using System;

namespace CSharp_Analyzer_of_Keystroke_Dynamics
{
    public partial class StartingWindow : Form
    {
        private readonly KeyStrokeRecorder _ksr = new KeyStrokeRecorder();
        private readonly Analysis _analyzer;
        public StartingWindow()
        {
            InitializeComponent();
            _ksr.Start();
        }
        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Filter keys
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                if (_ksr.IsKeyPressed(e.KeyCode))
                {
                    e.SuppressKeyPress = true;
                }
                else
                {
                    _ksr.KeyPressed(e.KeyCode);
                }
            }
        }
        private void richTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (char.IsLetterOrDigit((char)e.KeyCode))
            {
                _ksr.KeyReleased(e.KeyCode);
                var ks = _ksr.KeyStrokes[_ksr.KeyStrokes.Count - 1];
                richTextBox2.Text += ks.Key + " Dur.: " + ks.PressTime.Milliseconds + " Rel.:";
            }
        }

        private void newUser_button_Click(object sender, EventArgs e)
        {
            NewUserWindow newUser = new NewUserWindow(this);
            //Popup user creation window
            newUser.Show();
            //Block working with the previous form
            Hide();
        }
    }
}

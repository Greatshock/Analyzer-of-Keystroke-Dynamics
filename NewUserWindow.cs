using System;
using System.Windows.Forms;

namespace CSharp_Analyzer_of_Keystroke_Dynamics
{
    public partial class NewUserWindow : Form
    {
        StartingWindow startingWindow;
        public NewUserWindow(StartingWindow sw)
        {
            InitializeComponent();
            startingWindow = sw;
        }

        private void Back_button1_Click(object sender, EventArgs e)
        {
            startingWindow.Show();
            Close();
        }

        private void Next_button1_Click(object sender, EventArgs e)
        {
            tablessControl.SelectedTab = DynamicsRecord_tabPage;
        }

        private void Next_button2_Click(object sender, EventArgs e)
        {

        }

        private void Back_button2_Click(object sender, EventArgs e)
        {
            tablessControl.SelectedTab = passwordSet_tabPage;
        }
    }
}

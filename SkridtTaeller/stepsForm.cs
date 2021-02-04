using System;
using System.Windows.Forms;

namespace SkridtTaeller
{
    public partial class steps : Form
    {
        public steps()
        {
            InitializeComponent();
        }

        private void button1k_Click(object sender, EventArgs e)
        {
            stepsLabel.Text = "1000";
        }

        private void button2k_Click(object sender, EventArgs e)
        {
            stepsLabel.Text = "2000";
        }

        private void button3k_Click(object sender, EventArgs e)
        {
            stepsLabel.Text = "3000";
        }
    }
}

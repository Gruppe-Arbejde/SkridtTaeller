using System;
using System.Windows.Forms;

namespace SkridtTaeller
{
    public partial class guide : Form
    {
        public guide()
        {
            InitializeComponent();
            for (int i = 0; i < 100000; i++)
            {
                if (i == 10000)
                {
                    pictureBox.Image = SkridtTaeller.Properties.Resources.Guide_2;
                }
                else if (i == 20000)
                {
                    pictureBox.Image = SkridtTaeller.Properties.Resources.Guide_3;
                }
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace SkridtTaeller
{
    public partial class guide : Form
    {
        public guide()
        {
            InitializeComponent();
        }

        int pic = -1;
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                if (pic > 0)
                {
                    pic--;
                }

                pictureBox.Image = imageList1.Images[pic];

            }
            catch (Exception) { }
        }



        private void buttonNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (pic < 3)
                {
                    pic++;
                }

                pictureBox.Image = imageList1.Images[pic];
            }
            catch (Exception) { }
        }
    }
}



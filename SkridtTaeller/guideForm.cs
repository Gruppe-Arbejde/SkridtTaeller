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

        int pic = 1; //creates the variable which will be used to swicth between pictures
        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            try //error handling so that the user can't crash the application
            {
                if (pic > 0) //prevents the user from going under the specified interval of 0-3
                {
                    pic--; //reduces the variables value by 1 so that you can go back to the previous picture
                }
                switch (pic) //uses the variable "pic" to determine which picture gets displayed
                {
                    case 1:
                        pictureBox.Image = SkridtTaeller.Properties.Resources.Guide_1; //takes the specified picture from the resources folder
                        break;
                    case 2:
                        pictureBox.Image = SkridtTaeller.Properties.Resources.Guide_2; //takes the specified picture from the resources folder
                        break;
                    case 3:
                        pictureBox.Image = SkridtTaeller.Properties.Resources.Guide_3; //takes the specified picture from the resources folder
                        break;
                }

            }
            catch (Exception) { } //errorhandling
        }



        private void buttonNext_Click(object sender, EventArgs e) //the rest of the code is as above
        {
            try
            {
                if (pic < 3) //prevents the user from going under the specified interval of 0-3
                {
                    pic++; //increases the variables value by 1 so that you can go to the next picture
                }
                switch (pic)
                {
                    case 1:
                        pictureBox.Image = SkridtTaeller.Properties.Resources.Guide_1;
                        break;
                    case 2:
                        pictureBox.Image = SkridtTaeller.Properties.Resources.Guide_2;
                        break;
                    case 3:
                        pictureBox.Image = SkridtTaeller.Properties.Resources.Guide_3;
                        break;
                }

            }
            catch (Exception) { }
        }
    }
}



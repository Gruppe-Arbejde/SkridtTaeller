using System;
using System.Windows.Forms;

namespace SkridtTaeller
{
    public partial class steps : Form
    {
        public steps()
        {
            InitializeComponent();
            devPanel.Visible = false; //Makes the subpanel not visible on boot/run

        }

        private void hideSubMenu()
        {
            if (devPanel.Visible == true)
                devPanel.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else subMenu.Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(devPanel); //callback to method showSubMenu upon click which makes the subpanel appear
        }
        private void button1k_Click(object sender, EventArgs e)
        {
            stepsLabel.Text = "93";
            pictureBox1.Image = SkridtTaeller.Properties.Resources._1st_milestone;

        }

        private void button2k_Click(object sender, EventArgs e)
        {
            stepsLabel.Text = "8849";
            pictureBox1.Image = SkridtTaeller.Properties.Resources._2nd_milestone;

        }

        private void button3k_Click(object sender, EventArgs e)
        {
            stepsLabel.Text = "10000";
        }

        //private void milestone()
        //{
        //    bool x = true;
        //    while (x == true)
        //    {
        //        if (stepsLabel.Text == "93")
        //        {
        //            pictureBox1.Image = SkridtTaeller.Properties.Resources._1st_milestone;
        //        }
        //        else if (stepsLabel.Text == "8849")
        //        {
        //            pictureBox1.Image = SkridtTaeller.Properties.Resources._2nd_milestone;
        //        }
        //    } 
        //}
    }
}

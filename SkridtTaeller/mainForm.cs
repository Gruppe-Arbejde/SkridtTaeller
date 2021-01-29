using System;
using System.Windows.Forms;

namespace SkridtTaeller
{
    public partial class homepageForm : Form
    {
        public homepageForm()
        {
            InitializeComponent();
            customizeDesign();
        }

        private void customizeDesign()
        {
            subMenuPanel.Visible = false; //Makes the subpanel not visible on boot/run
        }
        private void hideSubMenu()
        {
            if (subMenuPanel.Visible == true)
                subMenuPanel.Visible = false;
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

        private void dropDown_Click(object sender, EventArgs e)
        {
            showSubMenu(subMenuPanel); //callback to method showSubMenu upon click which makes the subpanel appear
        }

        private void guideButton_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear(); //clears if there is already something displayed in the main panel
            guide a = new guide() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true }; //creates new instance of the winForms guide and sets the settings to the variable a
            a.FormBorderStyle = FormBorderStyle.None; //no border for cleaner look
            this.mainPanel.Controls.Add(a); //adds the variable a to the main subpanel
            a.Show(); //show the added variable on the subpanel
            hideSubMenu();
            stepsyPicture.Visible = false; //disables the stepzy logo in main winForm
        }

        private void rewardsButton_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            rewardsPanel b = new rewardsPanel() {Dock = DockStyle.Fill, TopLevel = false, TopMost = true};
            b.FormBorderStyle = FormBorderStyle.None;
            this.mainPanel.Controls.Add(b);
            b.Show();
            hideSubMenu();
            stepsyPicture.Visible = false;

        }

        private void stepsButton_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            steps c = new steps() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            c.FormBorderStyle = FormBorderStyle.None;
            this.mainPanel.Controls.Add(c);
            c.Show();
            hideSubMenu();
            stepsyPicture.Visible = false;

        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            homepageForm d = new homepageForm();
            d.Show();
            this.Hide();
            hideSubMenu();
            stepsyPicture.Visible = true;
        }

        //private Form activeForm = null;
        //private void openHomepageForm(Form homepageForm)
        //{
        //    if (activeForm != null)
        //        activeForm.Close();
        //    activeForm = homepageForm;
        //    homepageForm.TopLevel = false;
        //    homepageForm.FormBorderStyle = FormBorderStyle.None;
        //    homepageForm.Dock = DockStyle.Fill;
        //    mainPanel.Controls.Add(homepageForm);
        //    mainPanel.Tag = homepageForm;
        //    homepageForm.BringToFront();
        //    homepageForm.Show();
        //}
    }
}

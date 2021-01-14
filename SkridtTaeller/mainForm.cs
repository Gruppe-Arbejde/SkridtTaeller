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
            subMenuPanel.Visible = false;
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
            showSubMenu(subMenuPanel);
        }

        private void guideButton_Click(object sender, EventArgs e)
        {
            this.mainPanel.Controls.Clear();
            guide a = new guide() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            a.FormBorderStyle = FormBorderStyle.None;
            this.mainPanel.Controls.Add(a);
            a.Show();
            hideSubMenu();
            stepsyPicture.Visible = false;
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

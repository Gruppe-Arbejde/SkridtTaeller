using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private Form activeForm = null;
        private void openHomepageForm(Form homepageForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = homepageForm;
            homepageForm.TopLevel = false;
            homepageForm.FormBorderStyle = FormBorderStyle.None;
            homepageForm.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(homepageForm);
            mainPanel.Tag = homepageForm;
            homepageForm.BringToFront();
            homepageForm.Show();
        }
    }
}

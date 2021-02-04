
namespace SkridtTaeller
{
    partial class homepageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homepageForm));
            this.panelTopMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.dropDown = new System.Windows.Forms.Button();
            this.subMenuPanel = new System.Windows.Forms.Panel();
            this.stepsButton = new System.Windows.Forms.Button();
            this.rewardsButton = new System.Windows.Forms.Button();
            this.guideButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.stepsyPicture = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panelTopMenu.SuspendLayout();
            this.subMenuPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepsyPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(226)))));
            this.panelTopMenu.Controls.Add(this.panelLogo);
            this.panelTopMenu.Controls.Add(this.dropDown);
            this.panelTopMenu.Controls.Add(this.subMenuPanel);
            this.panelTopMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.panelTopMenu, "panelTopMenu");
            this.panelTopMenu.Name = "panelTopMenu";
            // 
            // panelLogo
            // 
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click);
            // 
            // dropDown
            // 
            this.dropDown.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.dropDown, "dropDown");
            this.dropDown.ForeColor = System.Drawing.Color.White;
            this.dropDown.Name = "dropDown";
            this.dropDown.UseVisualStyleBackColor = true;
            this.dropDown.Click += new System.EventHandler(this.dropDown_Click);
            // 
            // subMenuPanel
            // 
            this.subMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(226)))));
            this.subMenuPanel.Controls.Add(this.stepsButton);
            this.subMenuPanel.Controls.Add(this.rewardsButton);
            this.subMenuPanel.Controls.Add(this.guideButton);
            resources.ApplyResources(this.subMenuPanel, "subMenuPanel");
            this.subMenuPanel.Name = "subMenuPanel";
            // 
            // stepsButton
            // 
            this.stepsButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.stepsButton, "stepsButton");
            this.stepsButton.ForeColor = System.Drawing.Color.White;
            this.stepsButton.Name = "stepsButton";
            this.stepsButton.UseVisualStyleBackColor = true;
            this.stepsButton.Click += new System.EventHandler(this.stepsButton_Click);
            // 
            // rewardsButton
            // 
            this.rewardsButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.rewardsButton, "rewardsButton");
            this.rewardsButton.ForeColor = System.Drawing.Color.White;
            this.rewardsButton.Name = "rewardsButton";
            this.rewardsButton.UseVisualStyleBackColor = true;
            this.rewardsButton.Click += new System.EventHandler(this.rewardsButton_Click);
            // 
            // guideButton
            // 
            this.guideButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.guideButton, "guideButton");
            this.guideButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guideButton.Name = "guideButton";
            this.guideButton.UseVisualStyleBackColor = true;
            this.guideButton.Click += new System.EventHandler(this.guideButton_Click);
            // 
            // mainPanel
            // 
            resources.ApplyResources(this.mainPanel, "mainPanel");
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainPanel.Controls.Add(this.stepsyPicture);
            this.mainPanel.Name = "mainPanel";
            // 
            // stepsyPicture
            // 
            resources.ApplyResources(this.stepsyPicture, "stepsyPicture");
            this.stepsyPicture.Name = "stepsyPicture";
            this.stepsyPicture.TabStop = false;
            // 
            // homepageForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelTopMenu);
            this.MaximizeBox = false;
            this.Name = "homepageForm";
            this.panelTopMenu.ResumeLayout(false);
            this.subMenuPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stepsyPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panelTopMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button dropDown;
        private System.Windows.Forms.Panel subMenuPanel;
        private System.Windows.Forms.Button stepsButton;
        private System.Windows.Forms.Button rewardsButton;
        private System.Windows.Forms.Button guideButton;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox stepsyPicture;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
    }
}


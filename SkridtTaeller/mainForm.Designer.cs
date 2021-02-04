
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
            this.dropDown = new System.Windows.Forms.Button();
            this.subMenuPanel = new System.Windows.Forms.Panel();
            this.stepsButton = new System.Windows.Forms.Button();
            this.rewardsButton = new System.Windows.Forms.Button();
            this.guideButton = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.pBMilestone = new System.Windows.Forms.PictureBox();
            this.pBRewards = new System.Windows.Forms.PictureBox();
            this.pBSteps = new System.Windows.Forms.PictureBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTopMenu.SuspendLayout();
            this.subMenuPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBMilestone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBRewards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSteps)).BeginInit();
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
            this.mainPanel.Controls.Add(this.pBMilestone);
            this.mainPanel.Controls.Add(this.pBRewards);
            this.mainPanel.Controls.Add(this.pBSteps);
            this.mainPanel.Name = "mainPanel";
            // 
            // pBMilestone
            // 
            this.pBMilestone.Image = global::SkridtTaeller.Properties.Resources.Front_icon_large___Stepzy;
            resources.ApplyResources(this.pBMilestone, "pBMilestone");
            this.pBMilestone.Name = "pBMilestone";
            this.pBMilestone.TabStop = false;
            // 
            // pBRewards
            // 
            this.pBRewards.Image = global::SkridtTaeller.Properties.Resources.Rewards___Stepzy;
            resources.ApplyResources(this.pBRewards, "pBRewards");
            this.pBRewards.Name = "pBRewards";
            this.pBRewards.TabStop = false;
            this.pBRewards.Click += new System.EventHandler(this.pBRewards_Click);
            // 
            // pBSteps
            // 
            this.pBSteps.Image = global::SkridtTaeller.Properties.Resources.Steps___Stepzy;
            resources.ApplyResources(this.pBSteps, "pBSteps");
            this.pBSteps.Name = "pBSteps";
            this.pBSteps.TabStop = false;
            this.pBSteps.Click += new System.EventHandler(this.pBSteps_Click);
            // 
            // panelLogo
            // 
            resources.ApplyResources(this.panelLogo, "panelLogo");
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.pBMilestone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBRewards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBSteps)).EndInit();
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
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.PictureBox pBSteps;
        private System.Windows.Forms.PictureBox pBRewards;
        private System.Windows.Forms.PictureBox pBMilestone;
    }
}


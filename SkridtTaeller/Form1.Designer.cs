
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTopMenu.SuspendLayout();
            this.subMenuPanel.SuspendLayout();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopMenu
            // 
            this.panelTopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(166)))), ((int)(((byte)(243)))));
            this.panelTopMenu.Controls.Add(this.panelLogo);
            this.panelTopMenu.Controls.Add(this.dropDown);
            this.panelTopMenu.Controls.Add(this.subMenuPanel);
            this.panelTopMenu.Location = new System.Drawing.Point(-1, -1);
            this.panelTopMenu.Name = "panelTopMenu";
            this.panelTopMenu.Size = new System.Drawing.Size(756, 100);
            this.panelTopMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(106, 95);
            this.panelLogo.TabIndex = 1;
            // 
            // dropDown
            // 
            this.dropDown.FlatAppearance.BorderSize = 0;
            this.dropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropDown.ForeColor = System.Drawing.Color.Black;
            this.dropDown.Location = new System.Drawing.Point(115, 3);
            this.dropDown.Name = "dropDown";
            this.dropDown.Size = new System.Drawing.Size(115, 95);
            this.dropDown.TabIndex = 1;
            this.dropDown.Text = "=";
            this.dropDown.UseVisualStyleBackColor = true;
            this.dropDown.Click += new System.EventHandler(this.dropDown_Click);
            // 
            // subMenuPanel
            // 
            this.subMenuPanel.BackColor = System.Drawing.Color.RoyalBlue;
            this.subMenuPanel.Controls.Add(this.stepsButton);
            this.subMenuPanel.Controls.Add(this.rewardsButton);
            this.subMenuPanel.Controls.Add(this.guideButton);
            this.subMenuPanel.Location = new System.Drawing.Point(236, 3);
            this.subMenuPanel.Name = "subMenuPanel";
            this.subMenuPanel.Size = new System.Drawing.Size(366, 95);
            this.subMenuPanel.TabIndex = 2;
            // 
            // stepsButton
            // 
            this.stepsButton.FlatAppearance.BorderSize = 0;
            this.stepsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stepsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepsButton.ForeColor = System.Drawing.Color.White;
            this.stepsButton.Location = new System.Drawing.Point(239, 25);
            this.stepsButton.Name = "stepsButton";
            this.stepsButton.Size = new System.Drawing.Size(112, 43);
            this.stepsButton.TabIndex = 3;
            this.stepsButton.Text = "Steps";
            this.stepsButton.UseVisualStyleBackColor = true;
            // 
            // rewardsButton
            // 
            this.rewardsButton.FlatAppearance.BorderSize = 0;
            this.rewardsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rewardsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rewardsButton.ForeColor = System.Drawing.Color.White;
            this.rewardsButton.Location = new System.Drawing.Point(121, 25);
            this.rewardsButton.Name = "rewardsButton";
            this.rewardsButton.Size = new System.Drawing.Size(112, 43);
            this.rewardsButton.TabIndex = 2;
            this.rewardsButton.Text = "Rewards";
            this.rewardsButton.UseVisualStyleBackColor = true;
            // 
            // guideButton
            // 
            this.guideButton.FlatAppearance.BorderSize = 0;
            this.guideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.guideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guideButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.guideButton.Location = new System.Drawing.Point(3, 25);
            this.guideButton.Name = "guideButton";
            this.guideButton.Size = new System.Drawing.Size(112, 43);
            this.guideButton.TabIndex = 1;
            this.guideButton.Text = "Guide";
            this.guideButton.UseVisualStyleBackColor = true;
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPanel.Controls.Add(this.pictureBox1);
            this.mainPanel.Location = new System.Drawing.Point(-1, 99);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(756, 784);
            this.mainPanel.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(98, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(552, 676);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // homepageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(752, 885);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panelTopMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "homepageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STEPZY";
            this.panelTopMenu.ResumeLayout(false);
            this.subMenuPanel.ResumeLayout(false);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


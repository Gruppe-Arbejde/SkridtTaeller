
using System.Drawing;

namespace SkridtTaeller
{
    partial class steps
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
            this.stepsPanal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stepsLabel = new System.Windows.Forms.Label();
            this.button3k = new System.Windows.Forms.Button();
            this.button2k = new System.Windows.Forms.Button();
            this.button1k = new System.Windows.Forms.Button();
            this.devPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.devPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // stepsPanal
            // 
            this.stepsPanal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.stepsPanal.Dock = System.Windows.Forms.DockStyle.Top;
            this.stepsPanal.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepsPanal.Location = new System.Drawing.Point(0, 0);
            this.stepsPanal.Name = "stepsPanal";
            this.stepsPanal.Size = new System.Drawing.Size(756, 51);
            this.stepsPanal.TabIndex = 0;
            this.stepsPanal.Text = "STEPS";
            this.stepsPanal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stepsLabel);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 733);
            this.panel1.TabIndex = 1;
            // 
            // stepsLabel
            // 
            this.stepsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stepsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stepsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stepsLabel.Location = new System.Drawing.Point(329, 12);
            this.stepsLabel.Name = "stepsLabel";
            this.stepsLabel.Size = new System.Drawing.Size(98, 28);
            this.stepsLabel.TabIndex = 2;
            this.stepsLabel.Text = "[STEPS]";
            // 
            // button3k
            // 
            this.button3k.AutoSize = true;
            this.button3k.Location = new System.Drawing.Point(3, 169);
            this.button3k.Name = "button3k";
            this.button3k.Size = new System.Drawing.Size(88, 80);
            this.button3k.TabIndex = 6;
            this.button3k.Text = "40.075";
            this.button3k.UseVisualStyleBackColor = true;
            this.button3k.Click += new System.EventHandler(this.button3k_Click);
            // 
            // button2k
            // 
            this.button2k.AutoSize = true;
            this.button2k.Location = new System.Drawing.Point(3, 86);
            this.button2k.Name = "button2k";
            this.button2k.Size = new System.Drawing.Size(88, 80);
            this.button2k.TabIndex = 5;
            this.button2k.Text = "8849";
            this.button2k.UseVisualStyleBackColor = true;
            this.button2k.Click += new System.EventHandler(this.button2k_Click);
            // 
            // button1k
            // 
            this.button1k.AutoSize = true;
            this.button1k.Location = new System.Drawing.Point(3, 3);
            this.button1k.Name = "button1k";
            this.button1k.Size = new System.Drawing.Size(88, 80);
            this.button1k.TabIndex = 4;
            this.button1k.Text = "93";
            this.button1k.UseVisualStyleBackColor = true;
            this.button1k.Click += new System.EventHandler(this.button1k_Click);
            // 
            // devPanel
            // 
            this.devPanel.Controls.Add(this.buttonDefault);
            this.devPanel.Controls.Add(this.button3k);
            this.devPanel.Controls.Add(this.button1k);
            this.devPanel.Controls.Add(this.button2k);
            this.devPanel.Location = new System.Drawing.Point(660, 51);
            this.devPanel.Name = "devPanel";
            this.devPanel.Size = new System.Drawing.Size(96, 335);
            this.devPanel.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(663, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 39);
            this.button1.TabIndex = 8;
            this.button1.Text = "=";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SkridtTaeller.Properties.Resources.begining_picture_in_steps_2_0;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(756, 733);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDefault
            // 
            this.buttonDefault.AutoSize = true;
            this.buttonDefault.Location = new System.Drawing.Point(3, 252);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(88, 80);
            this.buttonDefault.TabIndex = 7;
            this.buttonDefault.Text = "Default";
            this.buttonDefault.UseVisualStyleBackColor = true;
            this.buttonDefault.Click += new System.EventHandler(this.buttonDefault_Click);
            // 
            // steps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 784);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.devPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.stepsPanal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "steps";
            this.Text = "Form4";
            this.panel1.ResumeLayout(false);
            this.devPanel.ResumeLayout(false);
            this.devPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label stepsPanal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label stepsLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1k;
        private System.Windows.Forms.Button button3k;
        private System.Windows.Forms.Button button2k;
        private System.Windows.Forms.Panel devPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonDefault;
    }
}
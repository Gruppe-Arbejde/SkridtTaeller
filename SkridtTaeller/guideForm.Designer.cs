
namespace SkridtTaeller
{
    partial class guide
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
            this.guidePanel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guidePanel
            // 
            this.guidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guidePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.guidePanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guidePanel.Location = new System.Drawing.Point(0, 0);
            this.guidePanel.Name = "guidePanel";
            this.guidePanel.Size = new System.Drawing.Size(756, 51);
            this.guidePanel.TabIndex = 0;
            this.guidePanel.Text = "GUIDE";
            this.guidePanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(756, 784);
            this.Controls.Add(this.guidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "guide";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label guidePanel;
    }
}
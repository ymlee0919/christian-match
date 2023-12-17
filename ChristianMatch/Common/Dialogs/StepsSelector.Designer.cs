namespace ChristianMatch.Common
{
    partial class StepsSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StepsSelector));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.thirdStepBtn = new System.Windows.Forms.Button();
            this.secondStepBtn = new System.Windows.Forms.Button();
            this.firstStepBtn = new System.Windows.Forms.Button();
            this.topLabel = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Ivory;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.thirdStepBtn);
            this.mainPanel.Controls.Add(this.secondStepBtn);
            this.mainPanel.Controls.Add(this.firstStepBtn);
            this.mainPanel.Controls.Add(this.topLabel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(743, 361);
            this.mainPanel.TabIndex = 0;
            // 
            // thirdStepBtn
            // 
            this.thirdStepBtn.BackColor = System.Drawing.Color.Lavender;
            this.thirdStepBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("thirdStepBtn.BackgroundImage")));
            this.thirdStepBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.thirdStepBtn.FlatAppearance.BorderSize = 0;
            this.thirdStepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.thirdStepBtn.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.thirdStepBtn.Location = new System.Drawing.Point(515, 129);
            this.thirdStepBtn.Name = "thirdStepBtn";
            this.thirdStepBtn.Size = new System.Drawing.Size(180, 180);
            this.thirdStepBtn.TabIndex = 18;
            this.thirdStepBtn.Tag = "3";
            this.thirdStepBtn.Text = "3 pasos";
            this.thirdStepBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.thirdStepBtn.UseVisualStyleBackColor = false;
            this.thirdStepBtn.Click += new System.EventHandler(this.stepsSelected);
            // 
            // secondStepBtn
            // 
            this.secondStepBtn.BackColor = System.Drawing.Color.Lavender;
            this.secondStepBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("secondStepBtn.BackgroundImage")));
            this.secondStepBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.secondStepBtn.FlatAppearance.BorderSize = 0;
            this.secondStepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.secondStepBtn.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.secondStepBtn.Location = new System.Drawing.Point(280, 129);
            this.secondStepBtn.Name = "secondStepBtn";
            this.secondStepBtn.Size = new System.Drawing.Size(180, 180);
            this.secondStepBtn.TabIndex = 18;
            this.secondStepBtn.Tag = "2";
            this.secondStepBtn.Text = "2 pasos";
            this.secondStepBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.secondStepBtn.UseVisualStyleBackColor = false;
            this.secondStepBtn.Click += new System.EventHandler(this.stepsSelected);
            // 
            // firstStepBtn
            // 
            this.firstStepBtn.BackColor = System.Drawing.Color.Lavender;
            this.firstStepBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("firstStepBtn.BackgroundImage")));
            this.firstStepBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstStepBtn.FlatAppearance.BorderSize = 0;
            this.firstStepBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstStepBtn.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.firstStepBtn.Location = new System.Drawing.Point(48, 129);
            this.firstStepBtn.Name = "firstStepBtn";
            this.firstStepBtn.Size = new System.Drawing.Size(180, 180);
            this.firstStepBtn.TabIndex = 18;
            this.firstStepBtn.Tag = "1";
            this.firstStepBtn.Text = "1 paso";
            this.firstStepBtn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.firstStepBtn.UseVisualStyleBackColor = false;
            this.firstStepBtn.Click += new System.EventHandler(this.stepsSelected);
            // 
            // topLabel
            // 
            this.topLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.topLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLabel.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.topLabel.Location = new System.Drawing.Point(0, 0);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(741, 81);
            this.topLabel.TabIndex = 17;
            this.topLabel.Text = "Team, ¿cuántos pasos vas a dar?";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StepsSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 361);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StepsSelector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StepsSelector";
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button thirdStepBtn;
        private System.Windows.Forms.Button secondStepBtn;
        private System.Windows.Forms.Button firstStepBtn;
    }
}
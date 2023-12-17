namespace ChristianMatch.Common
{
    partial class TeamReadyDialog
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
            this.characterImg = new System.Windows.Forms.PictureBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.continueBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.characterImg)).BeginInit();
            this.SuspendLayout();
            // 
            // characterImg
            // 
            this.characterImg.Location = new System.Drawing.Point(36, 32);
            this.characterImg.Name = "characterImg";
            this.characterImg.Size = new System.Drawing.Size(220, 220);
            this.characterImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.characterImg.TabIndex = 0;
            this.characterImg.TabStop = false;
            this.characterImg.Paint += new System.Windows.Forms.PaintEventHandler(this.characterImg_Paint);
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Font = new System.Drawing.Font("Comic Sans MS", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionLabel.Location = new System.Drawing.Point(298, 68);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(249, 39);
            this.questionLabel.TabIndex = 1;
            this.questionLabel.Text = "Character, ¿listo?";
            // 
            // continueBtn
            // 
            this.continueBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.continueBtn.FlatAppearance.BorderSize = 0;
            this.continueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueBtn.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.continueBtn.Image = global::ChristianMatch.Properties.Resources.ok;
            this.continueBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.continueBtn.Location = new System.Drawing.Point(305, 153);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(190, 66);
            this.continueBtn.TabIndex = 5;
            this.continueBtn.Text = "Listo !!!";
            this.continueBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(585, 296);
            this.panel1.TabIndex = 6;
            // 
            // TeamReadyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(585, 296);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.characterImg);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TeamReadyDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TeamReadyDialog";
            this.Shown += new System.EventHandler(this.TeamReadyDialog_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.characterImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox characterImg;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Panel panel1;
    }
}
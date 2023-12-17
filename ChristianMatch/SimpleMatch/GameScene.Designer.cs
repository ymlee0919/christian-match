namespace ChristianMatch.SimpleMatch
{
    partial class GameScene
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
            this.components = new System.ComponentModel.Container();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.endGameBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.mainScene = new System.Windows.Forms.PictureBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.FlashTimer = new System.Windows.Forms.Timer(this.components);
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainScene)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.Bisque;
            this.bottomPanel.Controls.Add(this.endGameBtn);
            this.bottomPanel.Controls.Add(this.startBtn);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 496);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(871, 117);
            this.bottomPanel.TabIndex = 0;
            // 
            // endGameBtn
            // 
            this.endGameBtn.FlatAppearance.BorderSize = 0;
            this.endGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endGameBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endGameBtn.Image = global::ChristianMatch.Properties.Resources.cancel;
            this.endGameBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.endGameBtn.Location = new System.Drawing.Point(569, 18);
            this.endGameBtn.Name = "endGameBtn";
            this.endGameBtn.Size = new System.Drawing.Size(269, 76);
            this.endGameBtn.TabIndex = 1;
            this.endGameBtn.Text = "Terminar juego";
            this.endGameBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.endGameBtn.UseVisualStyleBackColor = true;
            this.endGameBtn.Click += new System.EventHandler(this.endGameBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.startBtn.FlatAppearance.BorderSize = 0;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Image = global::ChristianMatch.Properties.Resources.love;
            this.startBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.startBtn.Location = new System.Drawing.Point(146, 19);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(245, 76);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Nueva ronda";
            this.startBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // mainScene
            // 
            this.mainScene.BackColor = System.Drawing.Color.White;
            this.mainScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainScene.Location = new System.Drawing.Point(0, 0);
            this.mainScene.Name = "mainScene";
            this.mainScene.Size = new System.Drawing.Size(871, 496);
            this.mainScene.TabIndex = 1;
            this.mainScene.TabStop = false;
            this.mainScene.Paint += new System.Windows.Forms.PaintEventHandler(this.mainScene_Paint);
            // 
            // topLabel
            // 
            this.topLabel.BackColor = System.Drawing.Color.Transparent;
            this.topLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLabel.Font = new System.Drawing.Font("Kristen ITC", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(0, 0);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(871, 88);
            this.topLabel.TabIndex = 2;
            this.topLabel.Text = "Combate cara a cara";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FlashTimer
            // 
            this.FlashTimer.Interval = 300;
            this.FlashTimer.Tick += new System.EventHandler(this.FlashTimer_Tick);
            // 
            // GameScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 613);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.mainScene);
            this.Controls.Add(this.bottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameScene";
            this.Text = "GameScene";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.GameScene_Shown);
            this.Resize += new System.EventHandler(this.GameScene_Resize);
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainScene)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button endGameBtn;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.PictureBox mainScene;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Timer FlashTimer;
    }
}
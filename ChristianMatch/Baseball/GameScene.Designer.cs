namespace ChristianMatch.Baseball
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
            this.mainScene = new System.Windows.Forms.PictureBox();
            this.startBtn = new System.Windows.Forms.Button();
            this.endBtn = new System.Windows.Forms.Button();
            this.startTimer = new System.Windows.Forms.Timer(this.components);
            this.FlashTimer = new System.Windows.Forms.Timer(this.components);
            this.raceLabel = new System.Windows.Forms.Label();
            this.raceTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainScene)).BeginInit();
            this.SuspendLayout();
            // 
            // mainScene
            // 
            this.mainScene.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainScene.Location = new System.Drawing.Point(0, 0);
            this.mainScene.Name = "mainScene";
            this.mainScene.Size = new System.Drawing.Size(868, 650);
            this.mainScene.TabIndex = 0;
            this.mainScene.TabStop = false;
            this.mainScene.Paint += new System.Windows.Forms.PaintEventHandler(this.mainScene_Paint);
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.startBtn.FlatAppearance.BorderColor = System.Drawing.Color.OliveDrab;
            this.startBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(63, 437);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(189, 76);
            this.startBtn.TabIndex = 1;
            this.startBtn.Text = "Batear";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // endBtn
            // 
            this.endBtn.BackColor = System.Drawing.Color.LightSalmon;
            this.endBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F);
            this.endBtn.Location = new System.Drawing.Point(304, 437);
            this.endBtn.Name = "endBtn";
            this.endBtn.Size = new System.Drawing.Size(189, 76);
            this.endBtn.TabIndex = 2;
            this.endBtn.Text = "Terminar";
            this.endBtn.UseVisualStyleBackColor = false;
            this.endBtn.Click += new System.EventHandler(this.endBtn_Click);
            // 
            // startTimer
            // 
            this.startTimer.Interval = 500;
            this.startTimer.Tick += new System.EventHandler(this.startTimer_Tick);
            // 
            // FlashTimer
            // 
            this.FlashTimer.Interval = 250;
            this.FlashTimer.Tick += new System.EventHandler(this.FlashTimer_Tick);
            // 
            // raceLabel
            // 
            this.raceLabel.AutoSize = true;
            this.raceLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.raceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.raceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.raceLabel.Font = new System.Drawing.Font("Comic Sans MS", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceLabel.ForeColor = System.Drawing.Color.White;
            this.raceLabel.Location = new System.Drawing.Point(187, 209);
            this.raceLabel.Name = "raceLabel";
            this.raceLabel.Size = new System.Drawing.Size(315, 86);
            this.raceLabel.TabIndex = 3;
            this.raceLabel.Text = "Carrera !!!";
            this.raceLabel.Visible = false;
            // 
            // raceTimer
            // 
            this.raceTimer.Interval = 600;
            this.raceTimer.Tick += new System.EventHandler(this.raceTimer_Tick);
            // 
            // GameScene
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 650);
            this.Controls.Add(this.raceLabel);
            this.Controls.Add(this.endBtn);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.mainScene);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameScene";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameScene";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.GameScene_Shown);
            this.Resize += new System.EventHandler(this.GameScene_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.mainScene)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox mainScene;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button endBtn;
        private System.Windows.Forms.Timer startTimer;
        private System.Windows.Forms.Timer FlashTimer;
        private System.Windows.Forms.Label raceLabel;
        private System.Windows.Forms.Timer raceTimer;
    }
}
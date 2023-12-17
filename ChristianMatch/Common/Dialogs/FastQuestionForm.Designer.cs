namespace ChristianMatch.Common
{
    partial class FastQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastQuestionForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.team1Btn = new System.Windows.Forms.Button();
            this.team2Btn = new System.Windows.Forms.Button();
            this.counterPanel = new System.Windows.Forms.Panel();
            this.timeCounter = new System.Windows.Forms.Label();
            this.equalBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.starsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            this.counterPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.team1Btn);
            this.panel2.Controls.Add(this.team2Btn);
            this.panel2.Controls.Add(this.counterPanel);
            this.panel2.Controls.Add(this.equalBtn);
            this.panel2.Controls.Add(this.cancelBtn);
            this.panel2.Controls.Add(this.answerLabel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(830, 441);
            this.panel2.TabIndex = 10;
            // 
            // team1Btn
            // 
            this.team1Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.team1Btn.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.team1Btn.Location = new System.Drawing.Point(37, 250);
            this.team1Btn.Name = "team1Btn";
            this.team1Btn.Size = new System.Drawing.Size(170, 170);
            this.team1Btn.TabIndex = 12;
            this.team1Btn.Text = "Team1";
            this.team1Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.team1Btn.UseVisualStyleBackColor = true;
            this.team1Btn.Visible = false;
            this.team1Btn.Click += new System.EventHandler(this.team1Btn_Click);
            // 
            // team2Btn
            // 
            this.team2Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.team2Btn.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.team2Btn.Location = new System.Drawing.Point(620, 250);
            this.team2Btn.Name = "team2Btn";
            this.team2Btn.Size = new System.Drawing.Size(170, 170);
            this.team2Btn.TabIndex = 12;
            this.team2Btn.Text = "Team2";
            this.team2Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.team2Btn.UseVisualStyleBackColor = true;
            this.team2Btn.Visible = false;
            this.team2Btn.Click += new System.EventHandler(this.team2Btn_Click);
            // 
            // counterPanel
            // 
            this.counterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.counterPanel.Controls.Add(this.timeCounter);
            this.counterPanel.Location = new System.Drawing.Point(349, 307);
            this.counterPanel.Name = "counterPanel";
            this.counterPanel.Size = new System.Drawing.Size(128, 44);
            this.counterPanel.TabIndex = 11;
            // 
            // timeCounter
            // 
            this.timeCounter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeCounter.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeCounter.ForeColor = System.Drawing.Color.Firebrick;
            this.timeCounter.Location = new System.Drawing.Point(0, 0);
            this.timeCounter.Name = "timeCounter";
            this.timeCounter.Size = new System.Drawing.Size(126, 42);
            this.timeCounter.TabIndex = 0;
            this.timeCounter.Text = "00:00";
            this.timeCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // equalBtn
            // 
            this.equalBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.equalBtn.FlatAppearance.BorderSize = 0;
            this.equalBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalBtn.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalBtn.Image = global::ChristianMatch.Properties.Resources.ok;
            this.equalBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.equalBtn.Location = new System.Drawing.Point(292, 235);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(228, 66);
            this.equalBtn.TabIndex = 10;
            this.equalBtn.Text = "Empatados";
            this.equalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Visible = false;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelBtn.Image")));
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(292, 348);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(228, 66);
            this.cancelBtn.TabIndex = 10;
            this.cancelBtn.Text = "Incorrecta";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Visible = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // answerLabel
            // 
            this.answerLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.answerLabel.Font = new System.Drawing.Font("Pristina", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerLabel.ForeColor = System.Drawing.Color.MediumBlue;
            this.answerLabel.Location = new System.Drawing.Point(11, 137);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(806, 89);
            this.answerLabel.TabIndex = 8;
            this.answerLabel.Text = "Respuesta ...";
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answerLabel.Click += new System.EventHandler(this.answerLabel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.starsLabel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Question);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 126);
            this.panel1.TabIndex = 2;
            // 
            // starsLabel
            // 
            this.starsLabel.BackColor = System.Drawing.Color.Transparent;
            this.starsLabel.Font = new System.Drawing.Font("Baskerville Old Face", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starsLabel.ForeColor = System.Drawing.Color.Yellow;
            this.starsLabel.Location = new System.Drawing.Point(671, 91);
            this.starsLabel.Name = "starsLabel";
            this.starsLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.starsLabel.Size = new System.Drawing.Size(157, 33);
            this.starsLabel.TabIndex = 9;
            this.starsLabel.Text = "*****";
            // 
            // label1
            // 
            this.label1.Image = global::ChristianMatch.Properties.Resources.question;
            this.label1.Location = new System.Drawing.Point(14, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 90);
            this.label1.TabIndex = 6;
            // 
            // Question
            // 
            this.Question.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Question.Font = new System.Drawing.Font("Pristina", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.ForeColor = System.Drawing.Color.Lavender;
            this.Question.Location = new System.Drawing.Point(92, 9);
            this.Question.Margin = new System.Windows.Forms.Padding(0);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(727, 109);
            this.Question.TabIndex = 0;
            this.Question.Text = "Esta es la pregunta que tengo que hacerte";
            this.Question.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // FastQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 441);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FastQuestionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FastQuestionForm";
            this.Shown += new System.EventHandler(this.FastQuestionForm_Shown);
            this.panel2.ResumeLayout(false);
            this.counterPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label starsLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Panel counterPanel;
        private System.Windows.Forms.Label timeCounter;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button team1Btn;
        private System.Windows.Forms.Button team2Btn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button equalBtn;

    }
}
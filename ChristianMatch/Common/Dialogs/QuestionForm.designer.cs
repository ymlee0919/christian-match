namespace ChristianMatch.Common
{
    partial class QuestionForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.starsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.Answer1 = new System.Windows.Forms.Label();
            this.Answer2 = new System.Windows.Forms.Label();
            this.Answer3 = new System.Windows.Forms.Label();
            this.Answer4 = new System.Windows.Forms.Label();
            this.Answer5 = new System.Windows.Forms.Label();
            this.Option5Btn = new System.Windows.Forms.Button();
            this.Option4Btn = new System.Windows.Forms.Button();
            this.Option3Btn = new System.Windows.Forms.Button();
            this.Option2Btn = new System.Windows.Forms.Button();
            this.Option1Btn = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.counterPanel = new System.Windows.Forms.Panel();
            this.timeCounter = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.counterPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1159, 126);
            this.panel1.TabIndex = 0;
            // 
            // starsLabel
            // 
            this.starsLabel.Font = new System.Drawing.Font("Baskerville Old Face", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starsLabel.ForeColor = System.Drawing.Color.Yellow;
            this.starsLabel.Location = new System.Drawing.Point(1000, 92);
            this.starsLabel.Name = "starsLabel";
            this.starsLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.starsLabel.Size = new System.Drawing.Size(157, 33);
            this.starsLabel.TabIndex = 10;
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
            this.Question.Location = new System.Drawing.Point(92, 11);
            this.Question.Margin = new System.Windows.Forms.Padding(0);
            this.Question.Name = "Question";
            this.Question.Size = new System.Drawing.Size(1056, 109);
            this.Question.TabIndex = 0;
            this.Question.Text = "Esta es la pregunta que tengo que hacerte";
            this.Question.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Answer1
            // 
            this.Answer1.AutoSize = true;
            this.Answer1.Font = new System.Drawing.Font("Pristina", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer1.ForeColor = System.Drawing.Color.MediumBlue;
            this.Answer1.Location = new System.Drawing.Point(84, 162);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(168, 44);
            this.Answer1.TabIndex = 2;
            this.Answer1.Text = "Respuesta uno";
            this.Answer1.Click += new System.EventHandler(this.Answer1_Click);
            // 
            // Answer2
            // 
            this.Answer2.AutoSize = true;
            this.Answer2.Font = new System.Drawing.Font("Pristina", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer2.ForeColor = System.Drawing.Color.MediumBlue;
            this.Answer2.Location = new System.Drawing.Point(84, 245);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(168, 44);
            this.Answer2.TabIndex = 2;
            this.Answer2.Text = "Respuesta uno";
            this.Answer2.Click += new System.EventHandler(this.Answer2_Click);
            // 
            // Answer3
            // 
            this.Answer3.AutoSize = true;
            this.Answer3.Font = new System.Drawing.Font("Pristina", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer3.ForeColor = System.Drawing.Color.MediumBlue;
            this.Answer3.Location = new System.Drawing.Point(84, 328);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(168, 44);
            this.Answer3.TabIndex = 2;
            this.Answer3.Text = "Respuesta uno";
            this.Answer3.Click += new System.EventHandler(this.Answer3_Click);
            // 
            // Answer4
            // 
            this.Answer4.AutoSize = true;
            this.Answer4.Font = new System.Drawing.Font("Pristina", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer4.ForeColor = System.Drawing.Color.MediumBlue;
            this.Answer4.Location = new System.Drawing.Point(84, 410);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(168, 44);
            this.Answer4.TabIndex = 2;
            this.Answer4.Text = "Respuesta uno";
            this.Answer4.Click += new System.EventHandler(this.Answer4_Click);
            // 
            // Answer5
            // 
            this.Answer5.AutoSize = true;
            this.Answer5.Font = new System.Drawing.Font("Pristina", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Answer5.ForeColor = System.Drawing.Color.MediumBlue;
            this.Answer5.Location = new System.Drawing.Point(84, 492);
            this.Answer5.Name = "Answer5";
            this.Answer5.Size = new System.Drawing.Size(168, 44);
            this.Answer5.TabIndex = 2;
            this.Answer5.Text = "Respuesta uno";
            this.Answer5.Click += new System.EventHandler(this.Answer5_Click);
            // 
            // Option5Btn
            // 
            this.Option5Btn.FlatAppearance.BorderSize = 0;
            this.Option5Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option5Btn.Image = global::ChristianMatch.Properties.Resources.OK1;
            this.Option5Btn.Location = new System.Drawing.Point(17, 480);
            this.Option5Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Option5Btn.Name = "Option5Btn";
            this.Option5Btn.Size = new System.Drawing.Size(56, 62);
            this.Option5Btn.TabIndex = 5;
            this.Option5Btn.UseVisualStyleBackColor = true;
            this.Option5Btn.Click += new System.EventHandler(this.Option5Btn_Click);
            // 
            // Option4Btn
            // 
            this.Option4Btn.FlatAppearance.BorderSize = 0;
            this.Option4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option4Btn.Image = global::ChristianMatch.Properties.Resources.OK1;
            this.Option4Btn.Location = new System.Drawing.Point(17, 398);
            this.Option4Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Option4Btn.Name = "Option4Btn";
            this.Option4Btn.Size = new System.Drawing.Size(56, 62);
            this.Option4Btn.TabIndex = 4;
            this.Option4Btn.UseVisualStyleBackColor = true;
            this.Option4Btn.Click += new System.EventHandler(this.Option4Btn_Click);
            // 
            // Option3Btn
            // 
            this.Option3Btn.FlatAppearance.BorderSize = 0;
            this.Option3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option3Btn.Image = global::ChristianMatch.Properties.Resources.OK1;
            this.Option3Btn.Location = new System.Drawing.Point(17, 315);
            this.Option3Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Option3Btn.Name = "Option3Btn";
            this.Option3Btn.Size = new System.Drawing.Size(56, 62);
            this.Option3Btn.TabIndex = 3;
            this.Option3Btn.UseVisualStyleBackColor = true;
            this.Option3Btn.Click += new System.EventHandler(this.Option3Btn_Click);
            // 
            // Option2Btn
            // 
            this.Option2Btn.FlatAppearance.BorderSize = 0;
            this.Option2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option2Btn.Image = global::ChristianMatch.Properties.Resources.OK1;
            this.Option2Btn.Location = new System.Drawing.Point(17, 232);
            this.Option2Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Option2Btn.Name = "Option2Btn";
            this.Option2Btn.Size = new System.Drawing.Size(56, 62);
            this.Option2Btn.TabIndex = 2;
            this.Option2Btn.UseVisualStyleBackColor = true;
            this.Option2Btn.Click += new System.EventHandler(this.Option2Btn_Click);
            // 
            // Option1Btn
            // 
            this.Option1Btn.FlatAppearance.BorderSize = 0;
            this.Option1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Option1Btn.Image = global::ChristianMatch.Properties.Resources.OK1;
            this.Option1Btn.Location = new System.Drawing.Point(17, 150);
            this.Option1Btn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Option1Btn.Name = "Option1Btn";
            this.Option1Btn.Size = new System.Drawing.Size(56, 62);
            this.Option1Btn.TabIndex = 1;
            this.Option1Btn.UseVisualStyleBackColor = true;
            this.Option1Btn.Click += new System.EventHandler(this.Option1Btn_Click);
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Navy;
            this.splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 126);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1159, 3);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // counterPanel
            // 
            this.counterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.counterPanel.Controls.Add(this.timeCounter);
            this.counterPanel.Location = new System.Drawing.Point(518, 552);
            this.counterPanel.Name = "counterPanel";
            this.counterPanel.Size = new System.Drawing.Size(128, 44);
            this.counterPanel.TabIndex = 7;
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
            // timer
            // 
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1159, 608);
            this.panel2.TabIndex = 8;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1159, 608);
            this.Controls.Add(this.counterPanel);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.Answer5);
            this.Controls.Add(this.Answer4);
            this.Controls.Add(this.Answer3);
            this.Controls.Add(this.Answer2);
            this.Controls.Add(this.Answer1);
            this.Controls.Add(this.Option5Btn);
            this.Controls.Add(this.Option4Btn);
            this.Controls.Add(this.Option3Btn);
            this.Controls.Add(this.Option2Btn);
            this.Controls.Add(this.Option1Btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuestionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "QuestionForm";
            this.Shown += new System.EventHandler(this.QuestionForm_Shown);
            this.panel1.ResumeLayout(false);
            this.counterPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Button Option1Btn;
        private System.Windows.Forms.Label Answer1;
        private System.Windows.Forms.Button Option2Btn;
        private System.Windows.Forms.Label Answer2;
        private System.Windows.Forms.Button Option3Btn;
        private System.Windows.Forms.Label Answer3;
        private System.Windows.Forms.Button Option4Btn;
        private System.Windows.Forms.Label Answer4;
        private System.Windows.Forms.Button Option5Btn;
        private System.Windows.Forms.Label Answer5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel counterPanel;
        private System.Windows.Forms.Label timeCounter;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label starsLabel;
        private System.Windows.Forms.Panel panel2;
    }
}
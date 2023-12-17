namespace ChristianMatch.Common
{
    partial class SimpleQuestionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimpleQuestionForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.starsLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Question = new System.Windows.Forms.Label();
            this.continueBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.answerLabel = new System.Windows.Forms.Label();
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
            this.panel1.Size = new System.Drawing.Size(835, 126);
            this.panel1.TabIndex = 1;
            // 
            // starsLabel
            // 
            this.starsLabel.Font = new System.Drawing.Font("Baskerville Old Face", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.starsLabel.ForeColor = System.Drawing.Color.Yellow;
            this.starsLabel.Location = new System.Drawing.Point(674, 91);
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
            this.Question.Size = new System.Drawing.Size(743, 109);
            this.Question.TabIndex = 0;
            this.Question.Text = "Esta es la pregunta que tengo que hacerte";
            this.Question.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // continueBtn
            // 
            this.continueBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.continueBtn.FlatAppearance.BorderSize = 0;
            this.continueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueBtn.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.continueBtn.Image = global::ChristianMatch.Properties.Resources.ok;
            this.continueBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.continueBtn.Location = new System.Drawing.Point(621, 296);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(202, 66);
            this.continueBtn.TabIndex = 5;
            this.continueBtn.Text = "Correcta";
            this.continueBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Visible = false;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelBtn.Image")));
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(18, 296);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(228, 66);
            this.cancelBtn.TabIndex = 6;
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
            this.answerLabel.Location = new System.Drawing.Point(4, 177);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(827, 89);
            this.answerLabel.TabIndex = 7;
            this.answerLabel.Text = "Respuesta ...";
            this.answerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.answerLabel.Click += new System.EventHandler(this.answerLabel_Click);
            // 
            // counterPanel
            // 
            this.counterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.counterPanel.Controls.Add(this.timeCounter);
            this.counterPanel.Location = new System.Drawing.Point(354, 307);
            this.counterPanel.Name = "counterPanel";
            this.counterPanel.Size = new System.Drawing.Size(128, 44);
            this.counterPanel.TabIndex = 8;
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
            this.panel2.Size = new System.Drawing.Size(835, 374);
            this.panel2.TabIndex = 9;
            // 
            // SimpleQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 374);
            this.Controls.Add(this.counterPanel);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SimpleQuestionForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SimpleQuestionForm";
            this.Shown += new System.EventHandler(this.SimpleQuestionForm_Shown);
            this.panel1.ResumeLayout(false);
            this.counterPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Question;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Panel counterPanel;
        private System.Windows.Forms.Label timeCounter;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label starsLabel;
        private System.Windows.Forms.Panel panel2;

    }
}
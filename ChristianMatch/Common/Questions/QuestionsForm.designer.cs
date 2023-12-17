namespace ChristianMatch.Common
{
    partial class QuestionsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionsForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.NewBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.NewQuestionBtn = new System.Windows.Forms.ToolStripButton();
            this.SaveQuestionBtn = new System.Windows.Forms.ToolStripButton();
            this.DeleteQuestionBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.PrevBtn = new System.Windows.Forms.ToolStripButton();
            this.NextBtn = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ItemLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Question = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CenterPanel = new System.Windows.Forms.Panel();
            this.MainContainer = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.levelCBox = new System.Windows.Forms.ComboBox();
            this.RightAnswer = new System.Windows.Forms.TextBox();
            this.Answer4 = new System.Windows.Forms.TextBox();
            this.Answer1 = new System.Windows.Forms.TextBox();
            this.Answer3 = new System.Windows.Forms.TextBox();
            this.Answer2 = new System.Windows.Forms.TextBox();
            this.questionsList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.Reference = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.CenterPanel.SuspendLayout();
            this.MainContainer.Panel1.SuspendLayout();
            this.MainContainer.Panel2.SuspendLayout();
            this.MainContainer.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.NewBtn,
            this.toolStripSeparator1,
            this.OpenBtn,
            this.toolStripSeparator2,
            this.SaveBtn,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.toolStripLabel2,
            this.NewQuestionBtn,
            this.SaveQuestionBtn,
            this.DeleteQuestionBtn,
            this.toolStripSeparator5,
            this.PrevBtn,
            this.NextBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1182, 32);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(119, 29);
            this.toolStripLabel1.Text = "Questionary:";
            // 
            // NewBtn
            // 
            this.NewBtn.Image = ((System.Drawing.Image)(resources.GetObject("NewBtn.Image")));
            this.NewBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewBtn.Name = "NewBtn";
            this.NewBtn.Size = new System.Drawing.Size(67, 29);
            this.NewBtn.Text = "New";
            this.NewBtn.ToolTipText = "Create new questionary";
            this.NewBtn.Click += new System.EventHandler(this.NewBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // OpenBtn
            // 
            this.OpenBtn.Image = ((System.Drawing.Image)(resources.GetObject("OpenBtn.Image")));
            this.OpenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(76, 29);
            this.OpenBtn.Text = "Open";
            this.OpenBtn.ToolTipText = "Open existent questionary";
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Enabled = false;
            this.SaveBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveBtn.Image")));
            this.SaveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(69, 29);
            this.SaveBtn.Text = "Save";
            this.SaveBtn.ToolTipText = "Save active questionary";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 32);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripLabel2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(93, 29);
            this.toolStripLabel2.Text = "Question:";
            // 
            // NewQuestionBtn
            // 
            this.NewQuestionBtn.Enabled = false;
            this.NewQuestionBtn.Image = ((System.Drawing.Image)(resources.GetObject("NewQuestionBtn.Image")));
            this.NewQuestionBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewQuestionBtn.Name = "NewQuestionBtn";
            this.NewQuestionBtn.Size = new System.Drawing.Size(67, 29);
            this.NewQuestionBtn.Text = "New";
            this.NewQuestionBtn.ToolTipText = "New question";
            this.NewQuestionBtn.Click += new System.EventHandler(this.NewQuestionBtn_Click);
            // 
            // SaveQuestionBtn
            // 
            this.SaveQuestionBtn.Enabled = false;
            this.SaveQuestionBtn.Image = ((System.Drawing.Image)(resources.GetObject("SaveQuestionBtn.Image")));
            this.SaveQuestionBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveQuestionBtn.Name = "SaveQuestionBtn";
            this.SaveQuestionBtn.Size = new System.Drawing.Size(69, 29);
            this.SaveQuestionBtn.Text = "Save";
            this.SaveQuestionBtn.ToolTipText = "Save current question";
            this.SaveQuestionBtn.Click += new System.EventHandler(this.SaveQuestionBtn_Click);
            // 
            // DeleteQuestionBtn
            // 
            this.DeleteQuestionBtn.Enabled = false;
            this.DeleteQuestionBtn.Image = ((System.Drawing.Image)(resources.GetObject("DeleteQuestionBtn.Image")));
            this.DeleteQuestionBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteQuestionBtn.Name = "DeleteQuestionBtn";
            this.DeleteQuestionBtn.Size = new System.Drawing.Size(82, 29);
            this.DeleteQuestionBtn.Text = "Delete";
            this.DeleteQuestionBtn.ToolTipText = "Delete current question";
            this.DeleteQuestionBtn.Click += new System.EventHandler(this.DeleteQuestionBtn_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 32);
            // 
            // PrevBtn
            // 
            this.PrevBtn.Enabled = false;
            this.PrevBtn.Image = ((System.Drawing.Image)(resources.GetObject("PrevBtn.Image")));
            this.PrevBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(66, 29);
            this.PrevBtn.Text = "Prev";
            this.PrevBtn.ToolTipText = "Show previous question";
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click);
            // 
            // NextBtn
            // 
            this.NextBtn.Enabled = false;
            this.NextBtn.Image = ((System.Drawing.Image)(resources.GetObject("NextBtn.Image")));
            this.NextBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(68, 29);
            this.NextBtn.Text = "Next";
            this.NextBtn.ToolTipText = "Show next question";
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.ItemLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 818);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1182, 30);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = false;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(550, 25);
            this.StatusLabel.Text = "Ready";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ItemLabel
            // 
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(76, 25);
            this.ItemLabel.Text = "No item";
            // 
            // TopPanel
            // 
            this.TopPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TopPanel.Controls.Add(this.Question);
            this.TopPanel.Controls.Add(this.panel1);
            this.TopPanel.Controls.Add(this.label1);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Enabled = false;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(794, 196);
            this.TopPanel.TabIndex = 2;
            // 
            // Question
            // 
            this.Question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Question.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Question.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Question.Location = new System.Drawing.Point(0, 25);
            this.Question.Margin = new System.Windows.Forms.Padding(10);
            this.Question.Multiline = true;
            this.Question.Name = "Question";
            this.Question.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Question.Size = new System.Drawing.Size(790, 119);
            this.Question.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Question:";
            // 
            // CenterPanel
            // 
            this.CenterPanel.Controls.Add(this.MainContainer);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Enabled = false;
            this.CenterPanel.Location = new System.Drawing.Point(0, 32);
            this.CenterPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CenterPanel.Name = "CenterPanel";
            this.CenterPanel.Size = new System.Drawing.Size(1182, 786);
            this.CenterPanel.TabIndex = 3;
            // 
            // MainContainer
            // 
            this.MainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainContainer.Location = new System.Drawing.Point(0, 0);
            this.MainContainer.Name = "MainContainer";
            // 
            // MainContainer.Panel1
            // 
            this.MainContainer.Panel1.Controls.Add(this.label2);
            this.MainContainer.Panel1.Controls.Add(this.TopPanel);
            this.MainContainer.Panel1.Controls.Add(this.BottomPanel);
            this.MainContainer.Panel1.Controls.Add(this.label3);
            this.MainContainer.Panel1.Controls.Add(this.label4);
            this.MainContainer.Panel1.Controls.Add(this.RightAnswer);
            this.MainContainer.Panel1.Controls.Add(this.Answer4);
            this.MainContainer.Panel1.Controls.Add(this.Answer1);
            this.MainContainer.Panel1.Controls.Add(this.Answer3);
            this.MainContainer.Panel1.Controls.Add(this.Answer2);
            this.MainContainer.Panel1.Resize += new System.EventHandler(this.splitContainer1_Panel1_Resize);
            // 
            // MainContainer.Panel2
            // 
            this.MainContainer.Panel2.Controls.Add(this.questionsList);
            this.MainContainer.Size = new System.Drawing.Size(1182, 786);
            this.MainContainer.SplitterDistance = 794;
            this.MainContainer.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Complexity level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(0, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Answers:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Right answer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Posible answers:";
            // 
            // levelCBox
            // 
            this.levelCBox.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.levelCBox.FormattingEnabled = true;
            this.levelCBox.Items.AddRange(new object[] {
            "Easy",
            "Low",
            "Medium",
            "High",
            "Hard"});
            this.levelCBox.Location = new System.Drawing.Point(147, 5);
            this.levelCBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.levelCBox.Name = "levelCBox";
            this.levelCBox.Size = new System.Drawing.Size(230, 33);
            this.levelCBox.TabIndex = 2;
            // 
            // RightAnswer
            // 
            this.RightAnswer.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.RightAnswer.Location = new System.Drawing.Point(28, 261);
            this.RightAnswer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RightAnswer.Name = "RightAnswer";
            this.RightAnswer.Size = new System.Drawing.Size(520, 33);
            this.RightAnswer.TabIndex = 3;
            // 
            // Answer4
            // 
            this.Answer4.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Answer4.Location = new System.Drawing.Point(28, 511);
            this.Answer4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Answer4.Name = "Answer4";
            this.Answer4.Size = new System.Drawing.Size(520, 33);
            this.Answer4.TabIndex = 7;
            // 
            // Answer1
            // 
            this.Answer1.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Answer1.Location = new System.Drawing.Point(28, 341);
            this.Answer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Answer1.Name = "Answer1";
            this.Answer1.Size = new System.Drawing.Size(520, 33);
            this.Answer1.TabIndex = 4;
            // 
            // Answer3
            // 
            this.Answer3.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Answer3.Location = new System.Drawing.Point(28, 451);
            this.Answer3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Answer3.Name = "Answer3";
            this.Answer3.Size = new System.Drawing.Size(520, 33);
            this.Answer3.TabIndex = 6;
            // 
            // Answer2
            // 
            this.Answer2.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Answer2.Location = new System.Drawing.Point(28, 395);
            this.Answer2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Answer2.Name = "Answer2";
            this.Answer2.Size = new System.Drawing.Size(520, 33);
            this.Answer2.TabIndex = 5;
            // 
            // questionsList
            // 
            this.questionsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.questionsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.questionsList.Enabled = false;
            this.questionsList.FullRowSelect = true;
            this.questionsList.GridLines = true;
            this.questionsList.Location = new System.Drawing.Point(0, 0);
            this.questionsList.MultiSelect = false;
            this.questionsList.Name = "questionsList";
            this.questionsList.Size = new System.Drawing.Size(384, 786);
            this.questionsList.TabIndex = 9;
            this.questionsList.UseCompatibleStateImageBehavior = false;
            this.questionsList.View = System.Windows.Forms.View.Details;
            this.questionsList.ItemActivate += new System.EventHandler(this.questionsList_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Question";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Level";
            this.columnHeader3.Width = 45;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.Reference);
            this.BottomPanel.Controls.Add(this.label5);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Enabled = false;
            this.BottomPanel.Location = new System.Drawing.Point(0, 644);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(794, 142);
            this.BottomPanel.TabIndex = 8;
            // 
            // Reference
            // 
            this.Reference.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Reference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Reference.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.Reference.Location = new System.Drawing.Point(0, 25);
            this.Reference.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Reference.Multiline = true;
            this.Reference.Name = "Reference";
            this.Reference.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Reference.Size = new System.Drawing.Size(794, 117);
            this.Reference.TabIndex = 8;
            this.Reference.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Reference_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Comment:";
            // 
            // Timer
            // 
            this.Timer.Interval = 2000;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.levelCBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(790, 48);
            this.panel1.TabIndex = 2;
            // 
            // QuestionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 848);
            this.Controls.Add(this.CenterPanel);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "QuestionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.Questions_Resize);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.CenterPanel.ResumeLayout(false);
            this.MainContainer.Panel1.ResumeLayout(false);
            this.MainContainer.Panel1.PerformLayout();
            this.MainContainer.Panel2.ResumeLayout(false);
            this.MainContainer.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton NewBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton OpenBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton SaveBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.TextBox Question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel CenterPanel;
        private System.Windows.Forms.TextBox Answer4;
        private System.Windows.Forms.TextBox Answer3;
        private System.Windows.Forms.TextBox Answer2;
        private System.Windows.Forms.TextBox Answer1;
        private System.Windows.Forms.TextBox RightAnswer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel BottomPanel;
        private System.Windows.Forms.TextBox Reference;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolStripButton PrevBtn;
        private System.Windows.Forms.ToolStripButton NextBtn;
        private System.Windows.Forms.ToolStripButton SaveQuestionBtn;
        private System.Windows.Forms.ToolStripButton DeleteQuestionBtn;
        private System.Windows.Forms.ToolStripStatusLabel ItemLabel;
        private System.Windows.Forms.ToolStripButton NewQuestionBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox levelCBox;
        private System.Windows.Forms.ListView questionsList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.SplitContainer MainContainer;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.Panel panel1;
    }
}
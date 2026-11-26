namespace ChristianMatch.SimpleMatch
{
    partial class GameConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameConfig));
            this.continueBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.timeLimitChBox = new System.Windows.Forms.CheckBox();
            this.topLabel = new System.Windows.Forms.Label();
            this.timeLimitsUpDown = new System.Windows.Forms.NumericUpDown();
            this.secondsLb = new System.Windows.Forms.Label();
            this.questionsChBox = new System.Windows.Forms.CheckBox();
            this.pointsUpDown = new System.Windows.Forms.NumericUpDown();
            this.pointsLb = new System.Windows.Forms.Label();
            this.possibleAnswersChBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.questionariesCBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.timeLimitsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // continueBtn
            // 
            this.continueBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.continueBtn.Enabled = false;
            this.continueBtn.FlatAppearance.BorderSize = 0;
            this.continueBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.continueBtn.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.continueBtn.Image = global::ChristianMatch.Properties.Resources.ok;
            this.continueBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.continueBtn.Location = new System.Drawing.Point(248, 597);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(190, 66);
            this.continueBtn.TabIndex = 5;
            this.continueBtn.Text = "Continuar";
            this.continueBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.continueBtn.UseVisualStyleBackColor = true;
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
            this.cancelBtn.Location = new System.Drawing.Point(12, 597);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(188, 66);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // timeLimitChBox
            // 
            this.timeLimitChBox.AutoSize = true;
            this.timeLimitChBox.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLimitChBox.Location = new System.Drawing.Point(23, 224);
            this.timeLimitChBox.Name = "timeLimitChBox";
            this.timeLimitChBox.Size = new System.Drawing.Size(351, 34);
            this.timeLimitChBox.TabIndex = 7;
            this.timeLimitChBox.Text = "Limitar el tiempo de respuesta";
            this.timeLimitChBox.UseVisualStyleBackColor = true;
            this.timeLimitChBox.CheckedChanged += new System.EventHandler(this.pointsLimitChBox_CheckedChanged);
            // 
            // topLabel
            // 
            this.topLabel.BackColor = System.Drawing.Color.DodgerBlue;
            this.topLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLabel.Font = new System.Drawing.Font("Kristen ITC", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.Color.DarkBlue;
            this.topLabel.Location = new System.Drawing.Point(0, 0);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(451, 81);
            this.topLabel.TabIndex = 8;
            this.topLabel.Text = "Reglas del juego";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLimitsUpDown
            // 
            this.timeLimitsUpDown.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.timeLimitsUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.timeLimitsUpDown.Location = new System.Drawing.Point(54, 264);
            this.timeLimitsUpDown.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.timeLimitsUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.timeLimitsUpDown.Name = "timeLimitsUpDown";
            this.timeLimitsUpDown.Size = new System.Drawing.Size(57, 38);
            this.timeLimitsUpDown.TabIndex = 9;
            this.timeLimitsUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.timeLimitsUpDown.Visible = false;
            // 
            // secondsLb
            // 
            this.secondsLb.AutoSize = true;
            this.secondsLb.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.secondsLb.Location = new System.Drawing.Point(117, 266);
            this.secondsLb.Name = "secondsLb";
            this.secondsLb.Size = new System.Drawing.Size(107, 30);
            this.secondsLb.TabIndex = 10;
            this.secondsLb.Text = "segundos";
            this.secondsLb.Visible = false;
            // 
            // questionsChBox
            // 
            this.questionsChBox.AutoSize = true;
            this.questionsChBox.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionsChBox.Location = new System.Drawing.Point(23, 348);
            this.questionsChBox.Name = "questionsChBox";
            this.questionsChBox.Size = new System.Drawing.Size(417, 64);
            this.questionsChBox.TabIndex = 7;
            this.questionsChBox.Text = "Todas las preguntas tienen el mismo \r\nvalor";
            this.questionsChBox.UseVisualStyleBackColor = true;
            this.questionsChBox.CheckedChanged += new System.EventHandler(this.questionsChBox_CheckedChanged);
            // 
            // pointsUpDown
            // 
            this.pointsUpDown.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.pointsUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.pointsUpDown.Location = new System.Drawing.Point(54, 418);
            this.pointsUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.pointsUpDown.Name = "pointsUpDown";
            this.pointsUpDown.Size = new System.Drawing.Size(57, 38);
            this.pointsUpDown.TabIndex = 9;
            this.pointsUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pointsUpDown.Visible = false;
            // 
            // pointsLb
            // 
            this.pointsLb.AutoSize = true;
            this.pointsLb.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.pointsLb.Location = new System.Drawing.Point(117, 420);
            this.pointsLb.Name = "pointsLb";
            this.pointsLb.Size = new System.Drawing.Size(81, 30);
            this.pointsLb.TabIndex = 10;
            this.pointsLb.Text = "puntos";
            this.pointsLb.Visible = false;
            // 
            // possibleAnswersChBox
            // 
            this.possibleAnswersChBox.AutoSize = true;
            this.possibleAnswersChBox.Checked = true;
            this.possibleAnswersChBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.possibleAnswersChBox.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.possibleAnswersChBox.Location = new System.Drawing.Point(23, 102);
            this.possibleAnswersChBox.Name = "possibleAnswersChBox";
            this.possibleAnswersChBox.Size = new System.Drawing.Size(385, 64);
            this.possibleAnswersChBox.TabIndex = 7;
            this.possibleAnswersChBox.Text = "Mostrar questionario con posibles\r\nrespuestas";
            this.possibleAnswersChBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label2.Location = new System.Drawing.Point(18, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 30);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cuestionario:";
            // 
            // questionariesCBox
            // 
            this.questionariesCBox.BackColor = System.Drawing.SystemColors.Info;
            this.questionariesCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questionariesCBox.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.questionariesCBox.FormattingEnabled = true;
            this.questionariesCBox.Location = new System.Drawing.Point(170, 499);
            this.questionariesCBox.Name = "questionariesCBox";
            this.questionariesCBox.Size = new System.Drawing.Size(238, 38);
            this.questionariesCBox.TabIndex = 11;
            this.questionariesCBox.SelectedIndexChanged += new System.EventHandler(this.questionariesCBox_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 686);
            this.panel1.TabIndex = 12;
            // 
            // GameConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(451, 686);
            this.Controls.Add(this.questionariesCBox);
            this.Controls.Add(this.pointsLb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.secondsLb);
            this.Controls.Add(this.pointsUpDown);
            this.Controls.Add(this.timeLimitsUpDown);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.questionsChBox);
            this.Controls.Add(this.possibleAnswersChBox);
            this.Controls.Add(this.timeLimitChBox);
            this.Controls.Add(this.continueBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameConfig";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GameConfig";
            this.Load += new System.EventHandler(this.GameConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeLimitsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.CheckBox timeLimitChBox;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.NumericUpDown timeLimitsUpDown;
        private System.Windows.Forms.Label secondsLb;
        private System.Windows.Forms.CheckBox questionsChBox;
        private System.Windows.Forms.NumericUpDown pointsUpDown;
        private System.Windows.Forms.Label pointsLb;
        private System.Windows.Forms.CheckBox possibleAnswersChBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox questionariesCBox;
        private System.Windows.Forms.Panel panel1;
    }
}
namespace ChristianMatch.FastMatch
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
            this.questionariesCBox = new System.Windows.Forms.ComboBox();
            this.pointsLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.secondsLb = new System.Windows.Forms.Label();
            this.topLabel = new System.Windows.Forms.Label();
            this.questionsChBox = new System.Windows.Forms.CheckBox();
            this.timeLimitChBox = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.continueBtn = new System.Windows.Forms.Button();
            this.pointsUpDown = new System.Windows.Forms.NumericUpDown();
            this.timeLimitsUpDown = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeLimitsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // questionariesCBox
            // 
            this.questionariesCBox.BackColor = System.Drawing.SystemColors.Info;
            this.questionariesCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questionariesCBox.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.questionariesCBox.FormattingEnabled = true;
            this.questionariesCBox.Location = new System.Drawing.Point(169, 396);
            this.questionariesCBox.Name = "questionariesCBox";
            this.questionariesCBox.Size = new System.Drawing.Size(238, 38);
            this.questionariesCBox.TabIndex = 22;
            this.questionariesCBox.SelectedIndexChanged += new System.EventHandler(this.questionariesCBox_SelectedIndexChanged);
            // 
            // pointsLb
            // 
            this.pointsLb.AutoSize = true;
            this.pointsLb.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.pointsLb.Location = new System.Drawing.Point(116, 315);
            this.pointsLb.Name = "pointsLb";
            this.pointsLb.Size = new System.Drawing.Size(81, 30);
            this.pointsLb.TabIndex = 19;
            this.pointsLb.Text = "puntos";
            this.pointsLb.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label2.Location = new System.Drawing.Point(17, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 30);
            this.label2.TabIndex = 20;
            this.label2.Text = "Cuestionario:";
            // 
            // secondsLb
            // 
            this.secondsLb.AutoSize = true;
            this.secondsLb.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.secondsLb.Location = new System.Drawing.Point(116, 162);
            this.secondsLb.Name = "secondsLb";
            this.secondsLb.Size = new System.Drawing.Size(107, 30);
            this.secondsLb.TabIndex = 21;
            this.secondsLb.Text = "segundos";
            this.secondsLb.Visible = false;
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
            this.topLabel.Size = new System.Drawing.Size(455, 81);
            this.topLabel.TabIndex = 18;
            this.topLabel.Text = "Reglas del juego";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // questionsChBox
            // 
            this.questionsChBox.AutoSize = true;
            this.questionsChBox.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionsChBox.Location = new System.Drawing.Point(22, 243);
            this.questionsChBox.Name = "questionsChBox";
            this.questionsChBox.Size = new System.Drawing.Size(417, 64);
            this.questionsChBox.TabIndex = 15;
            this.questionsChBox.Text = "Todas las preguntas tienen el mismo \r\nvalor";
            this.questionsChBox.UseVisualStyleBackColor = true;
            this.questionsChBox.CheckedChanged += new System.EventHandler(this.questionsChBox_CheckedChanged);
            // 
            // timeLimitChBox
            // 
            this.timeLimitChBox.AutoSize = true;
            this.timeLimitChBox.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLimitChBox.Location = new System.Drawing.Point(22, 120);
            this.timeLimitChBox.Name = "timeLimitChBox";
            this.timeLimitChBox.Size = new System.Drawing.Size(351, 34);
            this.timeLimitChBox.TabIndex = 17;
            this.timeLimitChBox.Text = "Limitar el tiempo de respuesta";
            this.timeLimitChBox.UseVisualStyleBackColor = true;
            this.timeLimitChBox.CheckedChanged += new System.EventHandler(this.timeLimitChBox_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.questionariesCBox);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Controls.Add(this.continueBtn);
            this.panel1.Controls.Add(this.pointsUpDown);
            this.panel1.Controls.Add(this.pointsLb);
            this.panel1.Controls.Add(this.timeLimitsUpDown);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.timeLimitChBox);
            this.panel1.Controls.Add(this.secondsLb);
            this.panel1.Controls.Add(this.questionsChBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 573);
            this.panel1.TabIndex = 23;
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelBtn.Image")));
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(22, 480);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(188, 66);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
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
            this.continueBtn.Location = new System.Drawing.Point(249, 480);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(190, 66);
            this.continueBtn.TabIndex = 13;
            this.continueBtn.Text = "Continuar";
            this.continueBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // pointsUpDown
            // 
            this.pointsUpDown.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.pointsUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.pointsUpDown.Location = new System.Drawing.Point(53, 313);
            this.pointsUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.pointsUpDown.Name = "pointsUpDown";
            this.pointsUpDown.Size = new System.Drawing.Size(57, 38);
            this.pointsUpDown.TabIndex = 10;
            this.pointsUpDown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pointsUpDown.Visible = false;
            // 
            // timeLimitsUpDown
            // 
            this.timeLimitsUpDown.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.timeLimitsUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.timeLimitsUpDown.Location = new System.Drawing.Point(53, 160);
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
            this.timeLimitsUpDown.TabIndex = 11;
            this.timeLimitsUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.timeLimitsUpDown.Visible = false;
            // 
            // GameConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(455, 573);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameConfig";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameConfig";
            this.Load += new System.EventHandler(this.GameConfig_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pointsUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeLimitsUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox questionariesCBox;
        private System.Windows.Forms.Label pointsLb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label secondsLb;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.CheckBox questionsChBox;
        private System.Windows.Forms.CheckBox timeLimitChBox;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown pointsUpDown;
        private System.Windows.Forms.NumericUpDown timeLimitsUpDown;
    }
}
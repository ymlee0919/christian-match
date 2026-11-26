namespace ChristianMatch.Baseball
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
            this.topLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.inningUpDown = new System.Windows.Forms.NumericUpDown();
            this.timeLimitsUpDown = new System.Windows.Forms.NumericUpDown();
            this.questionariesCBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.secondsLb = new System.Windows.Forms.Label();
            this.possibleAnswersChBox = new System.Windows.Forms.CheckBox();
            this.timeLimitChBox = new System.Windows.Forms.CheckBox();
            this.continueBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inningUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeLimitsUpDown)).BeginInit();
            this.SuspendLayout();
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
            this.topLabel.Size = new System.Drawing.Size(457, 81);
            this.topLabel.TabIndex = 9;
            this.topLabel.Text = "Reglas del juego";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.inningUpDown);
            this.panel1.Controls.Add(this.timeLimitsUpDown);
            this.panel1.Controls.Add(this.questionariesCBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.secondsLb);
            this.panel1.Controls.Add(this.possibleAnswersChBox);
            this.panel1.Controls.Add(this.timeLimitChBox);
            this.panel1.Controls.Add(this.continueBtn);
            this.panel1.Controls.Add(this.cancelBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 556);
            this.panel1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label1.Location = new System.Drawing.Point(18, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Total de inning a jugar:";
            // 
            // inningUpDown
            // 
            this.inningUpDown.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.inningUpDown.Location = new System.Drawing.Point(275, 270);
            this.inningUpDown.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.inningUpDown.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.inningUpDown.Name = "inningUpDown";
            this.inningUpDown.Size = new System.Drawing.Size(57, 38);
            this.inningUpDown.TabIndex = 21;
            this.inningUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // timeLimitsUpDown
            // 
            this.timeLimitsUpDown.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.timeLimitsUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.timeLimitsUpDown.Location = new System.Drawing.Point(52, 182);
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
            this.timeLimitsUpDown.TabIndex = 21;
            this.timeLimitsUpDown.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.timeLimitsUpDown.Visible = false;
            // 
            // questionariesCBox
            // 
            this.questionariesCBox.BackColor = System.Drawing.SystemColors.Info;
            this.questionariesCBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questionariesCBox.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.questionariesCBox.FormattingEnabled = true;
            this.questionariesCBox.Location = new System.Drawing.Point(170, 367);
            this.questionariesCBox.Name = "questionariesCBox";
            this.questionariesCBox.Size = new System.Drawing.Size(238, 38);
            this.questionariesCBox.TabIndex = 20;
            this.questionariesCBox.SelectedIndexChanged += new System.EventHandler(this.questionariesCBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.label2.Location = new System.Drawing.Point(18, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cuestionario:";
            // 
            // secondsLb
            // 
            this.secondsLb.AutoSize = true;
            this.secondsLb.Font = new System.Drawing.Font("Comic Sans MS", 11F);
            this.secondsLb.Location = new System.Drawing.Point(117, 182);
            this.secondsLb.Name = "secondsLb";
            this.secondsLb.Size = new System.Drawing.Size(107, 30);
            this.secondsLb.TabIndex = 19;
            this.secondsLb.Text = "segundos";
            this.secondsLb.Visible = false;
            // 
            // possibleAnswersChBox
            // 
            this.possibleAnswersChBox.AutoSize = true;
            this.possibleAnswersChBox.Checked = true;
            this.possibleAnswersChBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.possibleAnswersChBox.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.possibleAnswersChBox.Location = new System.Drawing.Point(23, 19);
            this.possibleAnswersChBox.Name = "possibleAnswersChBox";
            this.possibleAnswersChBox.Size = new System.Drawing.Size(385, 64);
            this.possibleAnswersChBox.TabIndex = 15;
            this.possibleAnswersChBox.Text = "Mostrar questionario con posibles\r\nrespuestas";
            this.possibleAnswersChBox.UseVisualStyleBackColor = true;
            // 
            // timeLimitChBox
            // 
            this.timeLimitChBox.AutoSize = true;
            this.timeLimitChBox.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLimitChBox.Location = new System.Drawing.Point(23, 140);
            this.timeLimitChBox.Name = "timeLimitChBox";
            this.timeLimitChBox.Size = new System.Drawing.Size(351, 34);
            this.timeLimitChBox.TabIndex = 16;
            this.timeLimitChBox.Text = "Limitar el tiempo de respuesta";
            this.timeLimitChBox.UseVisualStyleBackColor = true;
            this.timeLimitChBox.CheckedChanged += new System.EventHandler(this.timeLimitChBox_CheckedChanged);
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
            this.continueBtn.Location = new System.Drawing.Point(252, 469);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(190, 66);
            this.continueBtn.TabIndex = 12;
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
            this.cancelBtn.Location = new System.Drawing.Point(16, 469);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(188, 66);
            this.cancelBtn.TabIndex = 13;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // GameConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 637);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GameConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "GameConfig";
            this.Load += new System.EventHandler(this.GameConfig_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inningUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeLimitsUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox questionariesCBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label secondsLb;
        private System.Windows.Forms.CheckBox possibleAnswersChBox;
        private System.Windows.Forms.CheckBox timeLimitChBox;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown inningUpDown;
        private System.Windows.Forms.NumericUpDown timeLimitsUpDown;

    }
}
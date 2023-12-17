namespace ChristianMatch.Common
{
    partial class CharacterSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSelector));
            this.topLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTeam1 = new System.Windows.Forms.Label();
            this.labelTeam2 = new System.Windows.Forms.Label();
            this.sampleLabel = new System.Windows.Forms.Label();
            this.continueBtn = new System.Windows.Forms.Button();
            this.charactersList = new System.Windows.Forms.PictureBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.imgTeam2 = new System.Windows.Forms.PictureBox();
            this.imgTeam1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.charactersList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTeam2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTeam1)).BeginInit();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
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
            this.topLabel.Size = new System.Drawing.Size(597, 81);
            this.topLabel.TabIndex = 0;
            this.topLabel.Text = "Equipos";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Kristen ITC", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Brown;
            this.label1.Location = new System.Drawing.Point(268, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 66);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vs";
            // 
            // labelTeam1
            // 
            this.labelTeam1.AutoSize = true;
            this.labelTeam1.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeam1.Location = new System.Drawing.Point(88, 242);
            this.labelTeam1.Name = "labelTeam1";
            this.labelTeam1.Size = new System.Drawing.Size(100, 26);
            this.labelTeam1.TabIndex = 3;
            this.labelTeam1.Text = "Equipo 1";
            // 
            // labelTeam2
            // 
            this.labelTeam2.AutoSize = true;
            this.labelTeam2.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeam2.Location = new System.Drawing.Point(425, 243);
            this.labelTeam2.Name = "labelTeam2";
            this.labelTeam2.Size = new System.Drawing.Size(102, 26);
            this.labelTeam2.TabIndex = 3;
            this.labelTeam2.Text = "Equipo 2";
            // 
            // sampleLabel
            // 
            this.sampleLabel.AutoSize = true;
            this.sampleLabel.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleLabel.ForeColor = System.Drawing.Color.Ivory;
            this.sampleLabel.Location = new System.Drawing.Point(201, 243);
            this.sampleLabel.Name = "sampleLabel";
            this.sampleLabel.Size = new System.Drawing.Size(69, 29);
            this.sampleLabel.TabIndex = 6;
            this.sampleLabel.Text = "label2";
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
            this.continueBtn.Location = new System.Drawing.Point(378, 812);
            this.continueBtn.Name = "continueBtn";
            this.continueBtn.Size = new System.Drawing.Size(190, 66);
            this.continueBtn.TabIndex = 4;
            this.continueBtn.Text = "Continuar";
            this.continueBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.continueBtn.UseVisualStyleBackColor = true;
            this.continueBtn.Click += new System.EventHandler(this.continueBtn_Click);
            // 
            // charactersList
            // 
            this.charactersList.BackColor = System.Drawing.Color.White;
            this.charactersList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.charactersList.Location = new System.Drawing.Point(23, 283);
            this.charactersList.Name = "charactersList";
            this.charactersList.Size = new System.Drawing.Size(546, 514);
            this.charactersList.TabIndex = 5;
            this.charactersList.TabStop = false;
            this.charactersList.Paint += new System.Windows.Forms.PaintEventHandler(this.charactersList_Paint);
            this.charactersList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.charactersList_MouseDown);
            // 
            // cancelBtn
            // 
            this.cancelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.Image = ((System.Drawing.Image)(resources.GetObject("cancelBtn.Image")));
            this.cancelBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelBtn.Location = new System.Drawing.Point(26, 812);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(188, 66);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // imgTeam2
            // 
            this.imgTeam2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTeam2.Location = new System.Drawing.Point(395, 92);
            this.imgTeam2.Name = "imgTeam2";
            this.imgTeam2.Size = new System.Drawing.Size(150, 150);
            this.imgTeam2.TabIndex = 1;
            this.imgTeam2.TabStop = false;
            this.imgTeam2.Paint += new System.Windows.Forms.PaintEventHandler(this.imgTeam2_Paint);
            // 
            // imgTeam1
            // 
            this.imgTeam1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgTeam1.Location = new System.Drawing.Point(69, 91);
            this.imgTeam1.Name = "imgTeam1";
            this.imgTeam1.Size = new System.Drawing.Size(150, 150);
            this.imgTeam1.TabIndex = 1;
            this.imgTeam1.TabStop = false;
            this.imgTeam1.Paint += new System.Windows.Forms.PaintEventHandler(this.imgTeam1_Paint);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.statusStrip1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.continueBtn);
            this.panel1.Controls.Add(this.imgTeam1);
            this.panel1.Controls.Add(this.labelTeam1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 920);
            this.panel1.TabIndex = 7;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(338, 25);
            this.statusLabel.Text = "Haga clic sobre el personaje del equipo 1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 888);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(595, 30);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // CharacterSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(597, 992);
            this.Controls.Add(this.sampleLabel);
            this.Controls.Add(this.charactersList);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.labelTeam2);
            this.Controls.Add(this.imgTeam2);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CharacterSelector";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CharacterSelector";
            ((System.ComponentModel.ISupportInitialize)(this.charactersList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTeam2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTeam1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.PictureBox imgTeam1;
        private System.Windows.Forms.PictureBox imgTeam2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTeam1;
        private System.Windows.Forms.Label labelTeam2;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button continueBtn;
        private System.Windows.Forms.PictureBox charactersList;
        private System.Windows.Forms.Label sampleLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}
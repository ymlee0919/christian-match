namespace ChristianMatch.Baseball
{
    partial class HitSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HitSelector));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.homerunBtn = new System.Windows.Forms.Button();
            this.tripleBtn = new System.Windows.Forms.Button();
            this.doubleBtn = new System.Windows.Forms.Button();
            this.randomBtn = new System.Windows.Forms.Button();
            this.hitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.Ivory;
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mainPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanel.Controls.Add(this.homerunBtn);
            this.mainPanel.Controls.Add(this.tripleBtn);
            this.mainPanel.Controls.Add(this.doubleBtn);
            this.mainPanel.Controls.Add(this.randomBtn);
            this.mainPanel.Controls.Add(this.hitBtn);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 81);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(754, 462);
            this.mainPanel.TabIndex = 19;
            // 
            // homerunBtn
            // 
            this.homerunBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.homerunBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homerunBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homerunBtn.Location = new System.Drawing.Point(302, 351);
            this.homerunBtn.Name = "homerunBtn";
            this.homerunBtn.Size = new System.Drawing.Size(146, 98);
            this.homerunBtn.TabIndex = 18;
            this.homerunBtn.Tag = "5";
            this.homerunBtn.Text = "Homerun";
            this.homerunBtn.UseVisualStyleBackColor = true;
            this.homerunBtn.Click += new System.EventHandler(this.hitSelected);
            // 
            // tripleBtn
            // 
            this.tripleBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.tripleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tripleBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tripleBtn.Location = new System.Drawing.Point(84, 190);
            this.tripleBtn.Name = "tripleBtn";
            this.tripleBtn.Size = new System.Drawing.Size(135, 60);
            this.tripleBtn.TabIndex = 18;
            this.tripleBtn.Tag = "4";
            this.tripleBtn.Text = "Triple";
            this.tripleBtn.UseVisualStyleBackColor = true;
            this.tripleBtn.Click += new System.EventHandler(this.hitSelected);
            // 
            // doubleBtn
            // 
            this.doubleBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.doubleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.doubleBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doubleBtn.Location = new System.Drawing.Point(310, 23);
            this.doubleBtn.Name = "doubleBtn";
            this.doubleBtn.Size = new System.Drawing.Size(135, 60);
            this.doubleBtn.TabIndex = 18;
            this.doubleBtn.Tag = "3";
            this.doubleBtn.Text = "Doble";
            this.doubleBtn.UseVisualStyleBackColor = true;
            this.doubleBtn.Click += new System.EventHandler(this.hitSelected);
            // 
            // randomBtn
            // 
            this.randomBtn.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.randomBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomBtn.Location = new System.Drawing.Point(522, 369);
            this.randomBtn.Name = "randomBtn";
            this.randomBtn.Size = new System.Drawing.Size(219, 80);
            this.randomBtn.TabIndex = 18;
            this.randomBtn.Tag = "0";
            this.randomBtn.Text = "Aleatorio";
            this.randomBtn.UseVisualStyleBackColor = true;
            this.randomBtn.Visible = false;
            this.randomBtn.Click += new System.EventHandler(this.hitSelected);
            // 
            // hitBtn
            // 
            this.hitBtn.FlatAppearance.BorderColor = System.Drawing.Color.DarkBlue;
            this.hitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hitBtn.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hitBtn.Location = new System.Drawing.Point(534, 190);
            this.hitBtn.Name = "hitBtn";
            this.hitBtn.Size = new System.Drawing.Size(135, 60);
            this.hitBtn.TabIndex = 18;
            this.hitBtn.Tag = "2";
            this.hitBtn.Text = "Hit";
            this.hitBtn.UseVisualStyleBackColor = true;
            this.hitBtn.Click += new System.EventHandler(this.hitSelected);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(754, 81);
            this.label1.TabIndex = 20;
            this.label1.Text = "¿Cuánto pretendes batear?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HitSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 543);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HitSelector";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HitSelector";
            this.mainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button homerunBtn;
        private System.Windows.Forms.Button tripleBtn;
        private System.Windows.Forms.Button doubleBtn;
        private System.Windows.Forms.Button randomBtn;
        private System.Windows.Forms.Button hitBtn;
        private System.Windows.Forms.Label label1;

    }
}
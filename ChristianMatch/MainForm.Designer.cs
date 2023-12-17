namespace ChristianMatch
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.questionsBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.topLabel = new System.Windows.Forms.Label();
            this.simpleMatchBtn = new System.Windows.Forms.Button();
            this.teamsImage = new System.Windows.Forms.PictureBox();
            this.defineTeamsBtn = new System.Windows.Forms.Button();
            this.fastMatchBtn = new System.Windows.Forms.Button();
            this.wallkingUpBtn = new System.Windows.Forms.Button();
            this.baseballBtn = new System.Windows.Forms.Button();
            this.helpBtn = new System.Windows.Forms.Button();
            this.topPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsImage)).BeginInit();
            this.SuspendLayout();
            // 
            // questionsBtn
            // 
            this.questionsBtn.BackgroundImage = global::ChristianMatch.Properties.Resources.folder;
            this.questionsBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.questionsBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.questionsBtn.FlatAppearance.BorderSize = 0;
            this.questionsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.questionsBtn.Location = new System.Drawing.Point(0, 0);
            this.questionsBtn.Name = "questionsBtn";
            this.questionsBtn.Size = new System.Drawing.Size(69, 65);
            this.questionsBtn.TabIndex = 0;
            this.questionsBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.questionsBtn.UseVisualStyleBackColor = true;
            this.questionsBtn.Click += new System.EventHandler(this.questionsBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::ChristianMatch.Properties.Resources.delete;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Location = new System.Drawing.Point(1008, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(67, 65);
            this.closeBtn.TabIndex = 0;
            this.closeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.questionsBtn);
            this.topPanel.Controls.Add(this.closeBtn);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1075, 65);
            this.topPanel.TabIndex = 1;
            // 
            // topLabel
            // 
            this.topLabel.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.topLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLabel.Font = new System.Drawing.Font("Kristen ITC", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.ForeColor = System.Drawing.Color.Navy;
            this.topLabel.Location = new System.Drawing.Point(0, 65);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(1075, 181);
            this.topLabel.TabIndex = 2;
            this.topLabel.Text = "Torneos de Conocimiento Bíblico";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // simpleMatchBtn
            // 
            this.simpleMatchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("simpleMatchBtn.BackgroundImage")));
            this.simpleMatchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleMatchBtn.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleMatchBtn.Location = new System.Drawing.Point(9, 249);
            this.simpleMatchBtn.Name = "simpleMatchBtn";
            this.simpleMatchBtn.Size = new System.Drawing.Size(160, 160);
            this.simpleMatchBtn.TabIndex = 3;
            this.simpleMatchBtn.Text = "Cara a cara";
            this.simpleMatchBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.simpleMatchBtn.UseVisualStyleBackColor = true;
            this.simpleMatchBtn.Visible = false;
            this.simpleMatchBtn.Click += new System.EventHandler(this.simpleMatchBtn_Click);
            // 
            // teamsImage
            // 
            this.teamsImage.Location = new System.Drawing.Point(325, 249);
            this.teamsImage.Name = "teamsImage";
            this.teamsImage.Size = new System.Drawing.Size(750, 400);
            this.teamsImage.TabIndex = 4;
            this.teamsImage.TabStop = false;
            this.teamsImage.Paint += new System.Windows.Forms.PaintEventHandler(this.teamsImage_Paint);
            // 
            // defineTeamsBtn
            // 
            this.defineTeamsBtn.Enabled = false;
            this.defineTeamsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.defineTeamsBtn.Font = new System.Drawing.Font("Lucida Handwriting", 9F);
            this.defineTeamsBtn.Location = new System.Drawing.Point(776, 264);
            this.defineTeamsBtn.Name = "defineTeamsBtn";
            this.defineTeamsBtn.Size = new System.Drawing.Size(287, 110);
            this.defineTeamsBtn.TabIndex = 5;
            this.defineTeamsBtn.Text = "Cargando...";
            this.defineTeamsBtn.UseVisualStyleBackColor = true;
            this.defineTeamsBtn.Click += new System.EventHandler(this.defineTeamsBtn_Click);
            // 
            // fastMatchBtn
            // 
            this.fastMatchBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fastMatchBtn.BackgroundImage")));
            this.fastMatchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fastMatchBtn.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fastMatchBtn.Location = new System.Drawing.Point(9, 415);
            this.fastMatchBtn.Name = "fastMatchBtn";
            this.fastMatchBtn.Size = new System.Drawing.Size(160, 160);
            this.fastMatchBtn.TabIndex = 3;
            this.fastMatchBtn.Text = "El rápido";
            this.fastMatchBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fastMatchBtn.UseVisualStyleBackColor = true;
            this.fastMatchBtn.Visible = false;
            this.fastMatchBtn.Click += new System.EventHandler(this.fastMatchBtn_Click);
            // 
            // wallkingUpBtn
            // 
            this.wallkingUpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("wallkingUpBtn.BackgroundImage")));
            this.wallkingUpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.wallkingUpBtn.Font = new System.Drawing.Font("Lucida Handwriting", 9F);
            this.wallkingUpBtn.Location = new System.Drawing.Point(175, 249);
            this.wallkingUpBtn.Name = "wallkingUpBtn";
            this.wallkingUpBtn.Size = new System.Drawing.Size(160, 160);
            this.wallkingUpBtn.TabIndex = 6;
            this.wallkingUpBtn.Text = "Escalando";
            this.wallkingUpBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.wallkingUpBtn.UseVisualStyleBackColor = true;
            this.wallkingUpBtn.Visible = false;
            this.wallkingUpBtn.Click += new System.EventHandler(this.wallkingUpBtn_Click);
            // 
            // baseballBtn
            // 
            this.baseballBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("baseballBtn.BackgroundImage")));
            this.baseballBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.baseballBtn.Font = new System.Drawing.Font("Lucida Handwriting", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baseballBtn.Location = new System.Drawing.Point(175, 415);
            this.baseballBtn.Name = "baseballBtn";
            this.baseballBtn.Size = new System.Drawing.Size(160, 160);
            this.baseballBtn.TabIndex = 3;
            this.baseballBtn.Text = "Baseball";
            this.baseballBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.baseballBtn.UseVisualStyleBackColor = true;
            this.baseballBtn.Visible = false;
            this.baseballBtn.Click += new System.EventHandler(this.baseballBtn_Click);
            // 
            // helpBtn
            // 
            this.helpBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("helpBtn.BackgroundImage")));
            this.helpBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.helpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpBtn.Font = new System.Drawing.Font("Lucida Handwriting", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpBtn.Location = new System.Drawing.Point(12, 581);
            this.helpBtn.Name = "helpBtn";
            this.helpBtn.Size = new System.Drawing.Size(125, 125);
            this.helpBtn.TabIndex = 3;
            this.helpBtn.Text = "Tu ayuda";
            this.helpBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.helpBtn.UseVisualStyleBackColor = true;
            this.helpBtn.Visible = false;
            this.helpBtn.Click += new System.EventHandler(this.helpBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1075, 737);
            this.Controls.Add(this.baseballBtn);
            this.Controls.Add(this.wallkingUpBtn);
            this.Controls.Add(this.defineTeamsBtn);
            this.Controls.Add(this.teamsImage);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.helpBtn);
            this.Controls.Add(this.fastMatchBtn);
            this.Controls.Add(this.simpleMatchBtn);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Torneos de conocimiento bíblico";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.topPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teamsImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button questionsBtn;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button simpleMatchBtn;
        private System.Windows.Forms.PictureBox teamsImage;
        private System.Windows.Forms.Button defineTeamsBtn;
        private System.Windows.Forms.Button fastMatchBtn;
        private System.Windows.Forms.Button wallkingUpBtn;
        private System.Windows.Forms.Button baseballBtn;
        private System.Windows.Forms.Button helpBtn;
    }
}


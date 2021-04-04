namespace TheObstacleRunnerMiniGame
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.hero = new System.Windows.Forms.PictureBox();
            this.pillar = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ground = new System.Windows.Forms.PictureBox();
            this.birds = new System.Windows.Forms.PictureBox();
            this.plane = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.hero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plane)).BeginInit();
            this.SuspendLayout();
            // 
            // hero
            // 
            this.hero.BackColor = System.Drawing.Color.Transparent;
            this.hero.Image = ((System.Drawing.Image)(resources.GetObject("hero.Image")));
            this.hero.Location = new System.Drawing.Point(51, 330);
            this.hero.Name = "hero";
            this.hero.Size = new System.Drawing.Size(330, 85);
            this.hero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hero.TabIndex = 0;
            this.hero.TabStop = false;
            // 
            // pillar
            // 
            this.pillar.BackColor = System.Drawing.Color.Transparent;
            this.pillar.Image = ((System.Drawing.Image)(resources.GetObject("pillar.Image")));
            this.pillar.Location = new System.Drawing.Point(-106, 382);
            this.pillar.Name = "pillar";
            this.pillar.Size = new System.Drawing.Size(113, 359);
            this.pillar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pillar.TabIndex = 1;
            this.pillar.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.BackColor = System.Drawing.Color.Transparent;
            this.scoreText.Font = new System.Drawing.Font("Wide Latin", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreText.ForeColor = System.Drawing.Color.Red;
            this.scoreText.Location = new System.Drawing.Point(12, 20);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(230, 37);
            this.scoreText.TabIndex = 2;
            this.scoreText.Text = "Score: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(-2, 700);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1484, 41);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.ground.TabIndex = 3;
            this.ground.TabStop = false;
            // 
            // birds
            // 
            this.birds.BackColor = System.Drawing.Color.Transparent;
            this.birds.Image = ((System.Drawing.Image)(resources.GetObject("birds.Image")));
            this.birds.Location = new System.Drawing.Point(1474, 259);
            this.birds.Name = "birds";
            this.birds.Size = new System.Drawing.Size(233, 156);
            this.birds.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.birds.TabIndex = 4;
            this.birds.TabStop = false;
            // 
            // plane
            // 
            this.plane.BackColor = System.Drawing.Color.Transparent;
            this.plane.Image = ((System.Drawing.Image)(resources.GetObject("plane.Image")));
            this.plane.Location = new System.Drawing.Point(557, -26);
            this.plane.Name = "plane";
            this.plane.Size = new System.Drawing.Size(833, 195);
            this.plane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.plane.TabIndex = 5;
            this.plane.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1482, 753);
            this.Controls.Add(this.birds);
            this.Controls.Add(this.pillar);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.hero);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.plane);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "HeroGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.hero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hero;
        private System.Windows.Forms.PictureBox pillar;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox birds;
        private System.Windows.Forms.PictureBox plane;
    }
}


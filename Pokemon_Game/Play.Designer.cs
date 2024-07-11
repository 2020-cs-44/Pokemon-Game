
namespace Pokemon_Game
{
    partial class Play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Play));
            this.Charmander = new System.Windows.Forms.PictureBox();
            this.Bulbasaur = new System.Windows.Forms.PictureBox();
            this.HealthLabel = new System.Windows.Forms.Label();
            this.HealthBar = new System.Windows.Forms.ProgressBar();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.gameArea = new System.Windows.Forms.Panel();
            this.razorLeaf = new System.Windows.Forms.PictureBox();
            this.Ember = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Charmander)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bulbasaur)).BeginInit();
            this.gameArea.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.razorLeaf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ember)).BeginInit();
            this.SuspendLayout();
            // 
            // Charmander
            // 
            this.Charmander.BackColor = System.Drawing.Color.Transparent;
            this.Charmander.Image = ((System.Drawing.Image)(resources.GetObject("Charmander.Image")));
            this.Charmander.Location = new System.Drawing.Point(81, 272);
            this.Charmander.Name = "Charmander";
            this.Charmander.Size = new System.Drawing.Size(91, 119);
            this.Charmander.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Charmander.TabIndex = 1;
            this.Charmander.TabStop = false;
            // 
            // Bulbasaur
            // 
            this.Bulbasaur.BackColor = System.Drawing.Color.Transparent;
            this.Bulbasaur.Image = ((System.Drawing.Image)(resources.GetObject("Bulbasaur.Image")));
            this.Bulbasaur.Location = new System.Drawing.Point(568, 258);
            this.Bulbasaur.Name = "Bulbasaur";
            this.Bulbasaur.Size = new System.Drawing.Size(163, 133);
            this.Bulbasaur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bulbasaur.TabIndex = 2;
            this.Bulbasaur.TabStop = false;
            // 
            // HealthLabel
            // 
            this.HealthLabel.AutoSize = true;
            this.HealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.HealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HealthLabel.Location = new System.Drawing.Point(30, 50);
            this.HealthLabel.Name = "HealthLabel";
            this.HealthLabel.Size = new System.Drawing.Size(108, 31);
            this.HealthLabel.TabIndex = 4;
            this.HealthLabel.Text = "Health :";
            // 
            // HealthBar
            // 
            this.HealthBar.Location = new System.Drawing.Point(144, 58);
            this.HealthBar.Name = "HealthBar";
            this.HealthBar.Size = new System.Drawing.Size(136, 23);
            this.HealthBar.TabIndex = 5;
            this.HealthBar.Value = 100;
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // gameArea
            // 
            this.gameArea.BackColor = System.Drawing.Color.Transparent;
            this.gameArea.Controls.Add(this.razorLeaf);
            this.gameArea.Controls.Add(this.Ember);
            this.gameArea.Controls.Add(this.Charmander);
            this.gameArea.Controls.Add(this.HealthLabel);
            this.gameArea.Controls.Add(this.HealthBar);
            this.gameArea.Controls.Add(this.Bulbasaur);
            this.gameArea.Location = new System.Drawing.Point(12, 12);
            this.gameArea.Name = "gameArea";
            this.gameArea.Size = new System.Drawing.Size(776, 392);
            this.gameArea.TabIndex = 6;
            // 
            // razorLeaf
            // 
            this.razorLeaf.Image = ((System.Drawing.Image)(resources.GetObject("razorLeaf.Image")));
            this.razorLeaf.Location = new System.Drawing.Point(558, 327);
            this.razorLeaf.Name = "razorLeaf";
            this.razorLeaf.Size = new System.Drawing.Size(38, 30);
            this.razorLeaf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.razorLeaf.TabIndex = 7;
            this.razorLeaf.TabStop = false;
            // 
            // Ember
            // 
            this.Ember.Image = ((System.Drawing.Image)(resources.GetObject("Ember.Image")));
            this.Ember.Location = new System.Drawing.Point(169, 310);
            this.Ember.Name = "Ember";
            this.Ember.Size = new System.Drawing.Size(66, 47);
            this.Ember.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ember.TabIndex = 6;
            this.Ember.TabStop = false;
            // 
            // Play
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gameArea);
            this.Name = "Play";
            this.Text = "Play";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.Charmander)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bulbasaur)).EndInit();
            this.gameArea.ResumeLayout(false);
            this.gameArea.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.razorLeaf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ember)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox Charmander;
        private System.Windows.Forms.PictureBox Bulbasaur;
        private System.Windows.Forms.Label HealthLabel;
        private System.Windows.Forms.ProgressBar HealthBar;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.Panel gameArea;
        private System.Windows.Forms.PictureBox Ember;
        private System.Windows.Forms.PictureBox razorLeaf;
    }
}
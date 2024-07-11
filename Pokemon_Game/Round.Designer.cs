
namespace Pokemon_Game
{
    partial class Round
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Round));
            this.Round1 = new System.Windows.Forms.Button();
            this.Round2 = new System.Windows.Forms.Button();
            this.Round3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Round1
            // 
            this.Round1.Location = new System.Drawing.Point(207, 85);
            this.Round1.Name = "Round1";
            this.Round1.Size = new System.Drawing.Size(75, 23);
            this.Round1.TabIndex = 0;
            this.Round1.Text = "Round 1";
            this.Round1.UseVisualStyleBackColor = true;
            this.Round1.Click += new System.EventHandler(this.Round1_Click);
            // 
            // Round2
            // 
            this.Round2.Location = new System.Drawing.Point(207, 130);
            this.Round2.Name = "Round2";
            this.Round2.Size = new System.Drawing.Size(75, 23);
            this.Round2.TabIndex = 1;
            this.Round2.Text = "Round 2";
            this.Round2.UseVisualStyleBackColor = true;
            this.Round2.Click += new System.EventHandler(this.Round2_Click);
            // 
            // Round3
            // 
            this.Round3.Location = new System.Drawing.Point(207, 175);
            this.Round3.Name = "Round3";
            this.Round3.Size = new System.Drawing.Size(75, 23);
            this.Round3.TabIndex = 2;
            this.Round3.Text = "Round 3";
            this.Round3.UseVisualStyleBackColor = true;
            this.Round3.Click += new System.EventHandler(this.Round3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(207, 219);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Return";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Round
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(500, 279);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Round3);
            this.Controls.Add(this.Round2);
            this.Controls.Add(this.Round1);
            this.Name = "Round";
            this.Text = "Round";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Round1;
        private System.Windows.Forms.Button Round2;
        private System.Windows.Forms.Button Round3;
        private System.Windows.Forms.Button button1;
    }
}